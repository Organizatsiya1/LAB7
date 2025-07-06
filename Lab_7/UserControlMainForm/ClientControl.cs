using Logic;
using Model;
using System.Data;

namespace Lab_7
{
    public partial class ClientControl : UserControl
    {
        private readonly Client currentClient;      // Текущий клиент
        private readonly BusinessLogic Logic;
        private List<Food> allFoods = new List<Food>();   // Список всех блюд (меню)
        private List<Food> cartFoods = new List<Food>();  // Корзина клиента

        /// <summary>
        /// При создании этот конструктор получает объект Client и сохраняет его во внутреннем поле
        /// Затем загружает меню и подписывает обработчик для кнопки "Профиль"
        /// </summary>
        /// <param name="clientFromLogin">Объект Client, соответствующий вошедшему пользователю</param>
        public ClientControl(Client clientFromLogin, BusinessLogic logic)
        {
            InitializeComponent();
            currentClient = clientFromLogin;
            Logic = logic;
        }

        public async Task InitializeAsync()
        {
            allFoods = Logic.Dishes.ToList();
            PopulateMenu(allFoods);
            UpdateTotalPrice();
        }

        /// <summary>
        /// Заполняет список меню передачными блюдами (без учёта корзины)
        /// </summary>
        /// <param name="foods">Список Food для отображения</param>
        private void PopulateMenu(List<Food> foods)
        {
            listViewClientMenu.Items.Clear();
            imageListDishes.Images.Clear(); // Очищаем предыдущие изображения

            foreach (var food in foods)
            {
                // Загружаем изображение
                Image foodImage = DataConverter.LoadFoodImage(food.PhotoFile);

                // Добавляем изображение в список
                if (foodImage != null)
                {
                    imageListDishes.Images.Add(food.Id.ToString(), foodImage);
                }

                // Создаем элемент списка
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
                        item.Group = listViewClientMenu.Groups["Аперитив"];
                        break;
                    case FoodCategory.Entree:
                        item.Group = listViewClientMenu.Groups["Антре"];
                        break;
                    case FoodCategory.MainCourse:
                        item.Group = listViewClientMenu.Groups["Основное блюдо"];
                        break;
                    case FoodCategory.Entremets:
                        item.Group = listViewClientMenu.Groups["Антреме"];
                        break;
                    case FoodCategory.Desserts:
                        item.Group = listViewClientMenu.Groups["Десерт"];
                        break;
                    case FoodCategory.Digestif:
                        item.Group = listViewClientMenu.Groups["Дижестив"];
                        break;
                }

                listViewClientMenu.Items.Add(item);
            }
        }

        /// <summary>
        /// Фильтрует меню по введённому названию
        /// </summary>
        /// <param name="sender">Ссылка на TextBox с поиском</param>
        /// <param name="e">Аргументы события</param>
        private void textBoxClientSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxClientSearch.Text.Trim().ToLower();
            var filtered = string.IsNullOrEmpty(filter)
                ? allFoods.ToList()
                : allFoods.Where(f => f.Name.ToLower().Contains(filter)).ToList();

            PopulateMenu(filtered);
        }

        /// <summary>
        /// Добавляет выбранное блюдо в корзину
        /// </summary>
        /// <param name="sender">Ссылка на ListView с меню</param>
        /// <param name="e">Аргументы события</param>
        private void listViewClientMenu_DoubleClick(object sender, EventArgs e)
        {
            if (listViewClientMenu.SelectedItems.Count == 0)
                return;

            var food = (Food)listViewClientMenu.SelectedItems[0].Tag;
            using (var detail = new FoodForm(food))
            {
                // Показываем форму как диалог
                if (detail.ShowDialog() == DialogResult.OK && detail.AddToCart)
                {
                    // Пользователь нажал «Добавить в корзину»
                    cartFoods.Add(food);
                    RefreshCartListView();
                    UpdateTotalPrice();
                }
            }
        }

        /// <summary>
        /// Обновляет отображение корзины: группирует по Id блюда и показывает
        /// количество и общую сумму по каждому виду
        /// </summary>
        private void RefreshCartListView()
        {
            listViewClientCart.Items.Clear();

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
                listViewClientCart.Items.Add(item);
            }
        }

        /// <summary>
        /// Пересчитывает и отображает общую сумму корзины в метке "Итого" на форме
        /// </summary>
        private void UpdateTotalPrice()
        {
            double total = cartFoods.Sum(f => f.Cost);
            labelClientTotalPrice.Text = $"Итого:   \t{total:F2} руб.";
        }

        /// <summary>
        /// Если выбрана вкладка "Текущий заказ",
        /// заполняет список готовности блюд данными из последнего «открытого» заказа клиента (кнопка формирования заказа!)
        /// </summary>
        /// <param name="sender">Ссылка на TabControl</param>
        /// <param name="e">Аргументы события</param>
        private void tabControlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlClient.SelectedTab == tabPageClientCurrentOrder)
            {
                listViewClientCurrentOrder.Items.Clear();

                if (currentClient == null)
                    return;

                var order = Logic.GetCurrentOrderForClient(currentClient);
                if (order == null)
                    return;

                foreach (var food in order.Foods)
                {
                    var status = order.Behavior >= OrderBehavior.Coocked ? "Готово" : "В процессе";
                    var item = new ListViewItem(new[] { food.Food.Name, status });
                    listViewClientCurrentOrder.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Открывает ProfileForm для текущего клиента по нажатию на кнопку "Профиль"
        /// </summary>
        /// <param name="sender">Ссылка на кнопку "Профиль"</param>
        /// <param name="e">Аргументы события</param>
        private void buttonClientProfile_Click(object sender, EventArgs e)
        {
            // currentClient гарантированно не null, потому что мы передали его в конструкторе
            using (var profileForm = new ProfileForm(currentClient, Logic))
            {
                profileForm.ShowDialog();
            }
        }

        /// <summary>
        /// Закрывает окно для текущего клиента после нажатия кнопки "Выход" и открывает LoginForm
        /// </summary>
        /// <param name="sender">Ссылка на кнопку "Выход"</param>
        /// <param name="e">Аргументы события</param>
        private void buttonClientLogout_Click(object sender, EventArgs e)
        {
            // Скрываем текущее окно
            var currentForm = this.FindForm();
            currentForm.Hide();

            // Открываем форму входа
            var loginForm = new LoginForm(Logic);
            loginForm.Show();

            // Закрываем окно после открытия loginForm
            currentForm.Close();
        }

        private async void buttonFormClientOrder_Click(object sender, EventArgs e)
        {
            // 1) Открываем форму оформитель заказа
            using (var dlg = new OrderForClientForm(currentClient, Logic, cartFoods))
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
            }

            // 2) просто сбрасываем корзину
            cartFoods.Clear();
            RefreshCartListView();
            UpdateTotalPrice();
        }
    }
}
