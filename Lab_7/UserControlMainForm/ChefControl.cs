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
    public partial class ChefControl : UserControl
    {
        public BusinessLogic Logic { get; set; }
        public OrderedFood orderedFood { get; set; }
        public Order FixatedOrder { get; set; }
        public ChefControl()
        {
            InitializeComponent();
            foreach (Model.Order order in Logic.AllOrders)
            {
                IDGrid.Rows.Add(order.Id);
            }
        }

        /// <summary>
        /// Закрывает окно для текущего клиента после нажатия кнопки "Выход" и открывает LoginForm
        /// </summary>
        /// <param name="sender">Ссылка на кнопку "Выход"</param>
        /// <param name="e">Аргументы события</param>
        private void buttonAdminLogout_Click(object sender, EventArgs e)
        {
            // Скрываем текущее окно
            var currentForm = this.FindForm();
            currentForm.Hide();

            // Открываем форму входа
            var loginForm = new LoginForm();
            loginForm.Show();

            // Закрываем окно после открытия loginForm
            currentForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logic.Cook_Food(orderedFood);
            NotGrid.Rows.Clear();
            YeGrid.Rows.Clear();
            foreach (OrderedFood food in FixatedOrder.Foods)
            {
                if (!food.IsReady)
                {
                    NotGrid.Rows.Add(food.Food.Name);
                }
                else
                {
                    YeGrid.Rows.Add(food.Food.Name);
                }
            }
        }

        private void IDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NotGrid.Rows.Clear();
            YeGrid.Rows.Clear();
            foreach (Order order in Logic.AllOrders)
            {
                if (order.Id == (int)IDGrid.Rows[e.RowIndex].Tag)
                {
                    FixatedOrder = order;
                    break;
                }
            }
            foreach (OrderedFood food in FixatedOrder.Foods)
            {
                if (!food.IsReady)
                {
                    NotGrid.Rows.Add(food.Food.Name);
                }
                else
                {
                    YeGrid.Rows.Add(food.Food.Name);
                }
            }
        }

        private void NotGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(OrderedFood food in FixatedOrder.Foods)
            {
                if(food.Food.Name == NotGrid.Rows[e.RowIndex].Tag.ToString())
                {
                    orderedFood = food;
                    break;
                }
            }
        }
    }
}
