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
    public partial class CourierControl : UserControl
    {
        public BusinessLogic Logic { get; set; }
        public List<Order> OrdersTook { get; set; }
        public Order MarkedOrder_Taking { get; set; }
        public Order MarkedOrder_Paying { get; set; }
        public CourierControl()
        {
            InitializeComponent();
            foreach(Order order in Logic.CurrentOrders)
            {
                dataGridView1.Rows.Add(order.Id);
            }
        }

        private void buttonCourierTakeOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonCourierPayOrder_Click(object sender, EventArgs e)
        {
            Logic.MarkPayed(MarkedOrder_Taking);
        }

        private void buttonCourierLogout_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Order order in Logic.CurrentOrders)
            {
                if (order.Id == e.RowIndex) 
                {

                }
            }
        }
    }
}
