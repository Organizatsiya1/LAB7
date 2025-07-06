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
        public List<DeliveredOrder> OrdersTook { get; set; }
        public DeliveredOrder MarkedOrder_Taking { get; set; }
        public DeliveredOrder MarkedOrder_Paying { get; set; }
        private List<Point> routePoints = new List<Point>();
        private Point currentCourierPosition;
        private System.Windows.Forms.Timer routeTimer;
        private int currentTargetIndex = 0;
        private int courierVelocity;
        public void RefreshGrid(DataGridView grid, List<Order> orders)
        {
            grid.Rows.Clear();
            foreach (Order order in orders)
            {
                if (order is DeliveredOrder)
                {
                    grid.Rows.Add(order.Id);
                }
            }
        }
        public void RefreshGrid(DataGridView grid, List<DeliveredOrder> orders)
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
            routeTimer = new System.Windows.Forms.Timer();
            routeTimer.Interval = 50; 
            routeTimer.Tick += RouteTimer_Tick;
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
            var loginForm = new LoginForm(Logic);
            loginForm.Show();

            // Закрываем окно после открытия loginForm
            currentForm.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DeliveredOrder order in Logic.CurrentOrders)
            {
                if ((order.Id == (int)dataGridView1.Rows[e.RowIndex].Tag)&& order is DeliveredOrder)
                {
                    MarkedOrder_Taking = order;
                    break;
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DeliveredOrder order in OrdersTook)
            {
                if (order.Id == (int)dataGridView1.Rows[e.RowIndex].Tag)
                {
                    MarkedOrder_Paying = order;
                    break;
                }
            }
        }
        public double CountLength(double x1, double y1, double x2, double y2) 
        {
            double dist_x = x2 - x1;
            double dist_y = y2 - y1;
            double way = Math.Sqrt(Math.Pow(dist_x, 2) + Math.Pow(dist_y, 2));
            return way;
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
            routePoints = OrdersTook.Select(order => new Point(order.DeliveryAdress.X, order.DeliveryAdress.Y)).ToList();

            if (routePoints.Count == 0)
            {
                MessageBox.Show("Нет заказов для доставки!");
                return;
            }

            // Начальная позиция курьера (например, точка ресторана)
            currentCourierPosition = new Point(10, 10);

            // Запуск анимации
            currentTargetIndex = 0;
            routeTimer.Start();
        }
        private void RouteTimer_Tick(object sender, EventArgs e)
        {
            if (currentTargetIndex >= routePoints.Count)
            {
                routeTimer.Stop();
                MessageBox.Show("Маршрут завершен!");
                return;
            }

            Point target = routePoints[currentTargetIndex];

            // Расчет направления движения
            int dx = target.X - currentCourierPosition.X;
            int dy = target.Y - currentCourierPosition.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            // Если достигли текущей цели
            if (distance < courierVelocity)
            {
                currentCourierPosition = target;
                currentTargetIndex++;
                OrdersTook.RemoveAt(0); // Удаляем доставленный заказ
                RefreshGrid(dataGridView2, OrdersTook);
            }
            else
            {
                // Двигаемся к цели
                double ratio = courierVelocity / distance;
                currentCourierPosition = new Point(
                    currentCourierPosition.X + (int)(dx * ratio),
                    currentCourierPosition.Y + (int)(dy * ratio));
            }

            Map.Invalidate();
        }
        private void Map_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Map.BackColor);

            // Рисуем все точки маршрута (синие)
            foreach (Point point in routePoints)
            {
                g.FillEllipse(Brushes.Blue, point.X - 4, point.Y - 4, 8, 8);
            }

            // Рисуем пройденный путь (серая линия)
            if (routePoints.Count > 0 && currentTargetIndex > 0)
            {
                Point[] passedPoints = new Point[currentTargetIndex + 1];
                passedPoints[0] = new Point(10, 10); // Начальная точка
                Array.Copy(routePoints.ToArray(), 0, passedPoints, 1, currentTargetIndex);
                g.DrawLines(Pens.Gray, passedPoints);
            }

            // Рисуем текущую позицию курьера (зеленая точка)
            g.FillEllipse(Brushes.Green, currentCourierPosition.X - 5, currentCourierPosition.Y - 5, 10, 10);

            // Рисуем линию к текущей цели (красная)
            if (currentTargetIndex < routePoints.Count)
            {
                g.DrawLine(Pens.Red, currentCourierPosition, routePoints[currentTargetIndex]);
            }
        }


    }
}
