using Logic;
using Model;

namespace Lab_7
{
    public partial class StatisticsForm : Form
    {
        private BusinessLogic Logic;
        private List<Order> AllOrders;
        List<GroupedFood> foods = new List<GroupedFood>();
        List<GroupedClient> clients = new List<GroupedClient>();

        public StatisticsForm(BusinessLogic logic)
        {
            InitializeComponent();
            Logic = logic;

            // Показываем общее количество заказов сверху
            labelAllOrders.Text = $"Всего заказов: {Logic.AllOrders?.Count ?? 0}";

            Logic.GroupFoods(Logic.AllOrders, foods);
            Logic.GroupClients(Logic.Clients, clients);
            RefreshFoodGrid();
            RefreshClientGrid();
        }

        private void RefreshFoodGrid()
        {
            dataGridView2.Rows.Clear();
            foreach (var food in foods)
            {
                dataGridView2.Rows.Add(food.Name, food.Category, food.Count);
            }
        }

        private void RefreshClientGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var client in clients)
            {
                dataGridView1.Rows.Add(client.Id, client.Name, client.Orders.Count, client.Spent);
            }
        }

        private void SortFoodByName_Click(object sender, EventArgs e)
        {
            Logic.SortByFoodName(foods);
            RefreshFoodGrid();
        }

        private void SortFoodByType_Click(object sender, EventArgs e)
        {
            Logic.SortByFoodType(foods);
            RefreshFoodGrid();
        }

        private void SortFoodByNumber_Click(object sender, EventArgs e)
        {
            Logic.SortByFoodCount(foods);
            RefreshFoodGrid();
        }

        private void SortClientsByID_Click(object sender, EventArgs e)
        {
            Logic.SortByClientID(clients);
            RefreshClientGrid();
        }

        private void SortClientsByName_Click(object sender, EventArgs e)
        {
            Logic.SortByClientName(clients);
            RefreshClientGrid();
        }

        private void SortClientsByOrders_Click(object sender, EventArgs e)
        {
            Logic.SortByClientOrders(clients);
            RefreshClientGrid();
        }

        private void SortClientsByMoney_Click(object sender, EventArgs e)
        {
            Logic.SortByClientSpent(clients);
            RefreshClientGrid();
        }

        private void buttonFilterByDate_Click(object sender, EventArgs e)
        {
            var filtered = Logic.GetOrdersByDateRange(
                dateTimePickerFrom.Value,
                dateTimePickerTo.Value);

            foods.Clear();
            Logic.GroupFoods(filtered, foods);
            RefreshFoodGrid();
        }


        private void comboBoxFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxFoodCategory.SelectedItem.ToString();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                string type = row.Cells["TypeDishes"].Value?.ToString();

                // Показываем всё — если выбрано "Все"
                row.Visible = selectedCategory == "Все" || type == selectedCategory;
            }
        }
    }
}
