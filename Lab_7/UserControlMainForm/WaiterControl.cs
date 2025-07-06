using Logic;
using Model;
using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace Lab_7
{
    public partial class WaiterControl : UserControl
    {
        private readonly Waiter currentWaiter;
        private readonly BusinessLogic Logic;
        private List<Food> allFoods = new List<Food>();
        private List<Food> cartFoods = new List<Food>();

        private Timer ordersRefreshTimer;
        private List<int> KnownOrderIds = new List<int>();
        private DateTime NotificationSilenceUntil = DateTime.MinValue;
        private int TimerMinutesLeft = 0;

        /// <summary>
        /// При создании этот конструктор получает объект Waiter и сохраняет его во внутреннем поле
        /// Затем загружает меню и подписывает обработчик для кнопки "Профиль"
        /// </summary>
        /// <param name="waiterFromLogin"></param>
        /// <param name="logic"></param>
        public WaiterControl(Waiter waiterFromLogin, BusinessLogic logic)
        {
            InitializeComponent();
            currentWaiter = waiterFromLogin;
            Logic = logic;

            InitializeTimer();
        }

        public async Task InitializeAsync()
        {
            allFoods = Logic.Dishes.ToList();
            PopulateMenu(allFoods);
            UpdateTotalPrice();
            await RefreshOrdersAsync();
        }

        private void InitializeTimer()
        {
            ordersRefreshTimer = new Timer();
            ordersRefreshTimer.Interval = 5000; // 5 seconds
            ordersRefreshTimer.Tick += async (s, e) => await RefreshOrdersAsync();
            ordersRefreshTimer.Start();
        }

        private void PopulateMenu(List<Food> foods)
        {
            listViewWaiterMenu.Items.Clear();
            imageListDishes.Images.Clear();

            foreach (var food in foods)
            {
                Image foodImage = DataConverter.LoadFoodImage(food.PhotoFile);
                if (foodImage != null)
                {
                    imageListDishes.Images.Add(food.Id.ToString(), foodImage);
                }

                var item = new ListViewItem(new[]
                {
                    food.Name,
                    food.Cost.ToString("C0")
                })
                {
                    Tag = food,
                    ImageKey = food.Id.ToString()
                };

                // Назначение группы по категории
                switch (food.Priority)
                {
                    case FoodCategory.Aperitif:
                        item.Group = listViewWaiterMenu.Groups["Аперитив"];
                        break;
                    case FoodCategory.Entree:
                        item.Group = listViewWaiterMenu.Groups["Антре"];
                        break;
                    case FoodCategory.MainCourse:
                        item.Group = listViewWaiterMenu.Groups["Основное блюдо"];
                        break;
                    case FoodCategory.Entremets:
                        item.Group = listViewWaiterMenu.Groups["Антреме"];
                        break;
                    case FoodCategory.Desserts:
                        item.Group = listViewWaiterMenu.Groups["Десерт"];
                        break;
                    case FoodCategory.Digestif:
                        item.Group = listViewWaiterMenu.Groups["Дижестив"];
                        break;
                }

                listViewWaiterMenu.Items.Add(item);
            }
        }

        private void textBoxWaiterSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxWaiterSearch.Text.Trim().ToLower();
            var filtered = string.IsNullOrEmpty(filter)
                ? allFoods.ToList()
                : allFoods.Where(f => f.Name.ToLower().Contains(filter)).ToList();

            PopulateMenu(filtered);
        }

        private void listViewWaiterMenu_DoubleClick(object sender, EventArgs e)
        {
            if (listViewWaiterMenu.SelectedItems.Count == 0)
                return;

            var food = (Food)listViewWaiterMenu.SelectedItems[0].Tag;
            using (var detail = new FoodForm(food))
            {
                if (detail.ShowDialog() == DialogResult.OK && detail.AddToCart)
                {
                    cartFoods.Add(food);
                    RefreshCartListView();
                    UpdateTotalPrice();
                }
            }
        }

        private void RefreshCartListView()
        {
            listViewWaiterCart.Items.Clear();

            var grouped = cartFoods
                .GroupBy(f => f.Id)
                .Select(g => new
                {
                    Dish = g.First(),
                    Quantity = g.Count(),
                    Sum = g.Sum(x => x.Cost)
                });

            foreach (var entry in grouped)
            {
                var item = new ListViewItem(new[]
                {
                    entry.Dish.Name,
                    entry.Quantity.ToString(),
                    entry.Sum.ToString("F2")
                });
                item.Tag = entry.Dish;
                listViewWaiterCart.Items.Add(item);
            }
        }

        private void UpdateTotalPrice()
        {
            double total = cartFoods.Sum(f => f.Cost);
            labelWaiterTotalPrice.Text = $"Итого:   \t{total:F2} руб.";
        }

        private async void buttonFormWaiterOrder_Click(object sender, EventArgs e)
        {
            if (cartFoods.Count == 0)
            {
                MessageBox.Show("Корзина пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Открываем форму детализации заказа у официанта
            using (var orderDialog = new OrderForWaiterForm(currentWaiter, Logic, cartFoods))
            {
                if (orderDialog.ShowDialog() != DialogResult.OK)
                    return;

                // 1) создаём и сохраняем заказ
                var newOrder = await Logic.CreateOrderForWaiterAsync(
                    currentWaiter,
                    cartFoods,
                    orderDialog.TableID,
                    orderDialog.IsDelivery,
                    orderDialog.ClientId);

                if (newOrder == null)
                {
                    MessageBox.Show("Не удалось создать заказ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2) сразу показываем форму с деталями нового заказа
                using (var details = new OrderForm(newOrder))
                {
                    details.ShowDialog();
                }

                // 3) очищаем корзину и обновляем интерфейс
                cartFoods.Clear();
                RefreshCartListView();
                UpdateTotalPrice();
                await RefreshOrdersAsync();
            }
        }

        private async Task RefreshOrdersAsync()
        {
            // Сохраним текущее время
            var now = DateTime.Now;

            if (Logic?.AllOrders == null || currentWaiter == null)
            {
                return;
            }

            var waiterOrders = Logic.AllOrders
                .Where(o => o != null && o.WaiterID == currentWaiter.Id && !o.IsDelivered)
                .ToList();

            // Если появились новые ID — оповестить
            var newIds = waiterOrders.Select(o => o.Id).Except(KnownOrderIds).ToList();
            if (newIds.Any() && now >= NotificationSilenceUntil)
            {
                // Оповещение
                var msg = $"Появились новые заказы: {string.Join(", ", newIds)}";
                MessageBox.Show(msg, "Новые заказы", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Добавляем 5 минут «тишины» на новое оповещение
                TimerMinutesLeft += 5;
                NotificationSilenceUntil = now.AddMinutes(TimerMinutesLeft);
            }

            KnownOrderIds = waiterOrders.Select(o => o.Id).ToList();

            listViewWaiterOrders.Items.Clear();
            foreach (var order in waiterOrders)
            {
                var status = GetOrderStatusText(order);
                var item = new ListViewItem(new[] { order.Id.ToString(), status })
                {
                    Tag = order
                };
                listViewWaiterOrders.Items.Add(item);
            }
        }

        private string GetOrderStatusText(Order order)
        {
            return order.Behavior switch
            {
                OrderBehavior.IsCoocking => "Готовится",
                OrderBehavior.Coocked => "Готов",
                OrderBehavior.IsDone => "Завершен",
                _ => "Новый"
            };
        }

        private void listViewWaiterOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewWaiterOrderItems.Items.Clear();
            buttonWaiterPayOrder.Enabled = false;

            if (listViewWaiterOrders.SelectedItems.Count == 0)
                return;

            var selectedOrder = (Order)listViewWaiterOrders.SelectedItems[0].Tag;
            buttonWaiterPayOrder.Enabled = !selectedOrder.IsPayed;

            foreach (var orderedFood in selectedOrder.Foods)
            {
                var status = orderedFood.IsReady ? "Готово" : "Готовится";
                var item = new ListViewItem(new[]
                {
                    orderedFood.Food.Name,
                    status
                });
                listViewWaiterOrderItems.Items.Add(item);
            }
        }

        private void buttonWaiterPayOrder_Click(object sender, EventArgs e)
        {
            if (listViewWaiterOrders.SelectedItems.Count == 0) return;
            var order = (Order)listViewWaiterOrders.SelectedItems[0].Tag;

            using var payForm = new PaymentForm(order, Logic);
            if (payForm.ShowDialog() == DialogResult.OK)
            {
                // отметим оплаченным
                Logic.MarkPayed(order);
                listViewWaiterOrders_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        private void buttonWaiterProfile_Click(object sender, EventArgs e)
        {
            if (Logic.FixedUser != null)
            {
                using var profile = new ProfileForm(Logic.FixedUser, Logic);
                profile.ShowDialog();
            }
        }

        private void buttonWaiterLogout_Click(object sender, EventArgs e)
        {
            ordersRefreshTimer.Stop();
            var currentForm = this.FindForm();
            currentForm.Hide();

            var loginForm = new LoginForm(Logic);
            loginForm.Show();
            currentForm.Close();
        }

        
    }
}
