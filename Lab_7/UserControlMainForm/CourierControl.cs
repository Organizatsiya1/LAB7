using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();
        public void RefreshGrid(DataGridView grid, List<Order> orders)
        {
            grid.Rows.Clear();
            foreach (Order order in orders)
            {
                grid.Rows.Add(order.Id);
            }
        }
        public CourierControl()
        {
            InitializeComponent();
            foreach (Order order in Logic.CurrentOrders)
            {
                dataGridView1.Rows.Add(order.Id);
            }
        }

        private void buttonCourierTakeOrder_Click(object sender, EventArgs e)
        {
            OrdersTook.Add(MarkedOrder_Taking);
            Logic.CurrentOrders.Remove(MarkedOrder_Taking);
            RefreshGrid(dataGridView1, Logic.CurrentOrders);
            RefreshGrid(dataGridView2, OrdersTook);
        }

        private void buttonCourierPayOrder_Click(object sender, EventArgs e)
        {
            Logic.MarkPayed(MarkedOrder_Paying);
            RefreshGrid(dataGridView1, Logic.CurrentOrders);
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
                if (order.Id == (int)dataGridView1.Rows[e.RowIndex].Tag)
                {
                    MarkedOrder_Taking = order;
                    break;
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Order order in OrdersTook)
            {
                if (order.Id == (int)dataGridView1.Rows[e.RowIndex].Tag)
                {
                    MarkedOrder_Paying = order;
                    break;
                }
            }
        }

        private void buttonCourierStartRoute_Click(object sender, EventArgs e)
        {
            Courier courier = (Courier)Logic.FixedUser;
            int velocity;
            Pen PenCourier = new Pen(Color.Green, 5);
            Pen PenPlaces = new Pen(Color.Blue, 5);
            switch (courier.TransportType)
            {
                case(TransportType.Car):
                    velocity = 60;
                    break;
                case (TransportType.Motorbike):
                    velocity = 90;
                    break;
                case (TransportType.Bicycle):
                    velocity = 30;
                    break;
            }
            
        }

    }
}
