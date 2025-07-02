using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class StatisticsForm : Form
    {
        BusinessLogic BusinessLogic { get; set; }
        List<GroupedFood> foods = new List<GroupedFood>();
        List<GroupedClient> clients = new List<GroupedClient>();
        public StatisticsForm()
        {
            InitializeComponent();

            BusinessLogic.GroupFoods(BusinessLogic.AllOrders, foods);
            BusinessLogic.Group_Clients(BusinessLogic.Clients, clients);
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            foreach (GroupedFood food in foods)
            {
                dataGridView2.Rows.Add(food.Name, food.Count);
            }
            foreach (GroupedClient client in clients)
            {
                dataGridView1.Rows.Add(client.Id, client.Name, client.Orders.Count, client.Spent);
            }
        }

        private void SortFoodByName_Click(object sender, EventArgs e)
        {
            BusinessLogic.Sort_By_FoodName(foods);
            dataGridView2.Rows.Clear();
            foreach (GroupedFood food in foods)
            {
                dataGridView2.Rows.Add(food.Name, food.Count);
            }
        }

        private void SortFoodByNumber_Click(object sender, EventArgs e)
        {
            BusinessLogic.Sort_By_FoodCount(foods);
            dataGridView2.Rows.Clear();
            foreach (GroupedFood food in foods)
            {
                dataGridView2.Rows.Add(food.Name, food.Count);
            }
        }

        private void SortClientsByID_Click(object sender, EventArgs e)
        {
            BusinessLogic.Sort_By_ClientID(clients);
            dataGridView1.Rows.Clear();
            foreach (GroupedClient client in clients)
            {
                dataGridView1.Rows.Add(client.Id, client.Name, client.Orders.Count, client.Spent);
            }
        }

        private void SortClientsByName_Click(object sender, EventArgs e)
        {
            BusinessLogic.Sort_By_ClientName(clients);
            dataGridView1.Rows.Clear();
            foreach (GroupedClient client in clients)
            {
                dataGridView1.Rows.Add(client.Id, client.Name, client.Orders.Count, client.Spent);
            }
        }

        private void SortClientsByOrders_Click(object sender, EventArgs e)
        {
            BusinessLogic.Sort_By_ClientOrders(clients);
            dataGridView1.Rows.Clear();
            foreach (GroupedClient client in clients)
            {
                dataGridView1.Rows.Add(client.Id, client.Name, client.Orders.Count, client.Spent);
            }
        }

        private void SortClientsByMoney_Click(object sender, EventArgs e)
        {
            BusinessLogic.Sort_By_ClientSpent(clients);
            dataGridView1.Rows.Clear();
            foreach (GroupedClient client in clients)
            {
                dataGridView1.Rows.Add(client.Id, client.Name, client.Orders.Count, client.Spent);
            }
        }
    }
}
