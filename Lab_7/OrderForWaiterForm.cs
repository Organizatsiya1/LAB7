using Model;
using Logic;

namespace Lab_7
{
    public partial class OrderForWaiterForm : Form
    {
        private readonly BusinessLogic Logic;
        private readonly Waiter currentWaiter;
        private readonly List<Food> CartFoods;

        public int TableID { get; private set; }
        public bool IsDelivery { get; private set; }
        public int ClientId { get; private set; }
        public string Comments { get; private set; }

        public OrderForWaiterForm(Waiter waiter, BusinessLogic logic, List<Food> cartFoods)
        {
            InitializeComponent();

            currentWaiter = waiter;
            Logic = logic;
            CartFoods = cartFoods;

            var total = CartFoods.Sum(f => f.Cost);
            labelTotalCost.Text = $"Стоимость заказа: {total:F2} руб.";

            // настройка по умолчанию
            rbStandardGrouping.Checked = true;
            cbDeliveryType.SelectedIndex = 0;
            cbTableNumber.SelectedIndex = 0;

            // события
            rbStandardGrouping.CheckedChanged += (s, e) => ApplyGrouping();
            rbCustomGrouping.CheckedChanged += (s, e) => ApplyGrouping();
            btnConfirm.Click += BtnConfirm_Click;
            btnBack.Click += (s, e) => { DialogResult = DialogResult.Cancel; };

            PopulateListView();
        }

        private void PopulateListView()
        {
            listViewDishes.BeginUpdate();
            listViewDishes.Items.Clear();
            listViewDishes.Groups.Clear();

            // создаём группы по всем значениям enum, чтобы в стнд. режиме они всегда есть
            foreach (FoodCategory cat in Enum.GetValues(typeof(FoodCategory)))
                listViewDishes.Groups.Add(cat.ToString(), cat.ToString());

            // наполняем
            foreach (var food in CartFoods)
            {
                var item = new ListViewItem(new[]
                {
                    food.Name,
                    food.Cost.ToString("F2")
                })
                {
                    Tag = food
                };
                listViewDishes.Items.Add(item);
            }

            ApplyGrouping();
            listViewDishes.EndUpdate();
        }

        private void ApplyGrouping()
        {
            if (rbStandardGrouping.Checked)
            {
                listViewDishes.ShowGroups = true;
                // распределяем по Priority
                foreach (ListViewItem item in listViewDishes.Items)
                {
                    var food = (Food)item.Tag;
                    item.Group = listViewDishes.Groups[food.Priority.ToString()];
                }
            }
            else // кастомная
            {
                listViewDishes.ShowGroups = false;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            // валидация
            if (!int.TryParse(tbClientId.Text.Trim(), out var cid))
            {
                MessageBox.Show("Неверный ID клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClientId = cid;
            TableID = int.Parse(cbTableNumber.SelectedItem.ToString());
            IsDelivery = cbDeliveryType.SelectedIndex == 1;
            Comments = tbComments.Text.Trim();

            // закрываем форму, вызывающий код в WaiterControl сделает фактический create
            DialogResult = DialogResult.OK;
        }
    }
}
