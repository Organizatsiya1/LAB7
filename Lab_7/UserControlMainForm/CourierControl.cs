using Logic;
using Model;
using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace Lab_7
{
    public partial class CourierControl : UserControl
    {
        public BusinessLogic Logic;
        public List<DeliveredOrder> OrdersTook { get; set; }
        public DeliveredOrder MarkedOrder_Taking { get; set; }
        public DeliveredOrder MarkedOrder_Paying { get; set; }
        private List<Point> routePoints = new List<Point>();
        private Point currentCourierPosition;
        private Timer routeTimer;
        private int currentTargetIndex = 0;
        private int courierVelocity;

        public CourierControl(BusinessLogic logic)
        {
            InitializeComponent();
            Logic = logic;
            OrdersTook = new List<DeliveredOrder>();

            routeTimer = new Timer();
            routeTimer.Interval = 50;
            routeTimer.Tick += RouteTimer_Tick;
        }

        public async Task InitializeAsync()
        {
            // 2) гарантированно «чистим–добавляем» колонку
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "ID Заказа");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("ID", "ID Заказа");
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.ReadOnly = true;

            // 2) заполнение «активных» и «взятых» заказов
            RefreshGrid(dataGridView1, Logic.AllOrders
                                       .OfType<DeliveredOrder>()
                                       .Where(o => !o.IsDelivered)
                                       .ToList());
            RefreshGrid(dataGridView2, OrdersTook);


        }

        public void RefreshGrid(DataGridView grid, List<DeliveredOrder> orders)
        {
            grid.Rows.Clear();
            foreach (Order order in orders)
            {
                if (order is DeliveredOrder)
                {
                    var idx = grid.Rows.Add(order.Id);
                    grid.Rows[idx].Tag = order;
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
                // заказ доставлен
                var delivered = OrdersTook[0];
                delivered.IsDelivered = true;
                delivered.Behavior = OrderBehavior.IsDone;
                delivered.IsPayed = false;
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

        private void buttonWaiterProfile_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MarkedOrder_Taking = dataGridView1.SelectedRows[0].Tag as DeliveredOrder;
            }
            buttonCourierTakeOrder.Enabled = MarkedOrder_Taking != null;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                MarkedOrder_Paying = dataGridView2.SelectedRows[0].Tag as DeliveredOrder;
            }
            buttonCourierPayOrder.Enabled = MarkedOrder_Paying != null
                                           && MarkedOrder_Paying.Behavior == OrderBehavior.Coocked;
        }

        private void buttonCourierStartRoute_Click(object sender, EventArgs e)
        {
            Courier courier = (Courier)Logic.FixedUser;
            int velocity;
            Pen PenCourier = new Pen(Color.Green, 5);
            Pen PenPlaces = new Pen(Color.Blue, 5);
            switch (courier.TransportType)
            {
                case (TransportType.Car):
                    velocity = 60;
                    break;
                case (TransportType.Motorbike):
                    velocity = 90;
                    break;
                case (TransportType.Bicycle):
                    velocity = 30;
                    break;
            }
            routePoints = OrdersTook.Select(o =>
            {
                int x = Convert.ToInt32(Math.Round(o.DeliveryAdress.X));
                int y = Convert.ToInt32(Math.Round(o.DeliveryAdress.Y));
                return new Point(x, y);
            }).ToList();

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

        private void buttonCourierTakeOrder_Click(object sender, EventArgs e)
        {
            if (MarkedOrder_Taking == null) return;

            // фиксируем курьера
            MarkedOrder_Taking.CourierId = (Logic.FixedUser as Courier).Id;
            // оставляем IsDelivered = false до фактической доставки

            Logic.WriteAsync();    // сохраняем изм.

            Logic.AllOrders.Remove(MarkedOrder_Taking);
            RefreshGrid(dataGridView1, Logic.AllOrders.OfType<DeliveredOrder>().Where(o => !o.IsDelivered).ToList());

            OrdersTook.Add(MarkedOrder_Taking);
            RefreshGrid(dataGridView2, OrdersTook);

            // кнопка «Начать маршрут» активна, если есть хотя бы один взятый заказ
            buttonCourierStartRoute.Enabled = OrdersTook.Any();
        }

        private async void buttonCourierPayOrder_Click(object sender, EventArgs e)
        {
            if (MarkedOrder_Paying == null)
                return;

            Logic.MarkPayed(MarkedOrder_Paying);
            MarkedOrder_Paying.Behavior = OrderBehavior.IsDone;
            await Logic.WriteAsync();

            OrdersTook.Remove(MarkedOrder_Paying);
            RefreshGrid(dataGridView1, OrdersTook);
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
    }
}
