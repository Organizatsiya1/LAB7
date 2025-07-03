using Logic;
using Model;

namespace Lab_7
{
    public partial class ChefControl : UserControl
    {
        public BusinessLogic Logic;
        public OrderedFood orderedFood { get; set; }
        public Order FixatedOrder { get; set; }

        public ChefControl(BusinessLogic logic)
        {
            InitializeComponent();
            Logic = logic;

            // Настройка стилей для всех таблиц
            ConfigureDataGridView(IDGrid);
            ConfigureDataGridView(NotGrid);
            ConfigureDataGridView(YeGrid);

            RefreshOrdersList();
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            // 1. Отключаем стандартные визуальные стили
            dgv.EnableHeadersVisualStyles = false;

            // 2. Настройка основного стиля ячеек
            dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(234, 215, 209), // Светло-бежевый
                ForeColor = Color.Black,                   // Черный текст
                SelectionBackColor = Color.FromArgb(99, 58, 52), // Темно-бордовый при выделении
                SelectionForeColor = Color.White,
                Font = new Font("Segoe UI", 9F)
            };

            // 3. Стиль заголовков столбцов
            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(99, 58, 52), // Темно-бордовый
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            // 4. Стиль заголовков строк
            dgv.RowHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(99, 58, 52), // Темно-бордовый
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F)
            };

            // 5. Настройка границ
            dgv.GridColor = SystemColors.ControlDark;
            dgv.BorderStyle = BorderStyle.FixedSingle;

            // 6. Дополнительные настройки для улучшения внешнего вида
            dgv.ColumnHeadersHeight = 28;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.RowHeadersWidth = 40;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
        }

        private void RefreshOrdersList()
        {
            IDGrid.Rows.Clear();

            // Получаем только активные заказы (в процессе приготовления)
            var activeOrders = Logic.AllOrders
                .Where(o => o.Behavior == OrderBehavior.IsCoocking)
                .ToList();

            foreach (var order in activeOrders)
            {
                var row = new DataGridViewRow();
                row.CreateCells(IDGrid);
                row.Cells[0].Value = order.Id;
                row.Tag = order; // Сохраняем ссылку на заказ
                IDGrid.Rows.Add(row);
            }
        }

        private void RefreshFoodLists()
        {
            NotGrid.Rows.Clear();
            YeGrid.Rows.Clear();

            if (FixatedOrder == null) return;

            var groupedFoods = FixatedOrder.Foods
                .GroupBy(f => f.Food.Priority)
                .OrderBy(g => g.Key);

            foreach (var group in groupedFoods)
            {
                NotGrid.Rows.Add($"--- {GetCategoryName(group.Key)} ---");
                YeGrid.Rows.Add($"--- {GetCategoryName(group.Key)} ---");

                foreach (var food in group)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(food.IsReady ? YeGrid : NotGrid);
                    row.Cells[0].Value = food.Food.Name;
                    row.Tag = food;

                    if (food.IsReady) YeGrid.Rows.Add(row);
                    else NotGrid.Rows.Add(row);
                }
            }
        }

        private string GetCategoryName(FoodCategory category)
        {
            return category switch
            {
                FoodCategory.Aperitif => "Аперитив",
                FoodCategory.Entree => "Антре",
                FoodCategory.MainCourse => "Основное блюдо",
                FoodCategory.Entremets => "Антреме",
                FoodCategory.Desserts => "Десерт",
                FoodCategory.Digestif => "Дижестив",
                _ => "Другое"
            };
        }

        private void IDGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = IDGrid.Rows[e.RowIndex];

            FixatedOrder = row.Tag as Order;

            orderedFood = null;
            RefreshFoodLists();
        }

        private void NotGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            orderedFood = NotGrid.Rows[e.RowIndex].Tag as OrderedFood;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (orderedFood == null)
            {
                MessageBox.Show("Выберите блюдо для отметки");
                return;
            }

            Logic.CookFood(orderedFood);
            if (FixatedOrder.Foods.All(f => f.IsReady))
                FixatedOrder.Behavior = OrderBehavior.Coocked;

            // Обновляем интерфейс
            RefreshOrdersList();
            RefreshFoodLists();
        }

        private void buttonChefProfile_Click(object sender, EventArgs e)
        {
            if (Logic.FixedUser != null)
            {
                using var profile = new ProfileForm(Logic.FixedUser, Logic);
                profile.ShowDialog();
            }
        }

        /// <summary>
        /// Закрывает окно для текущего клиента после нажатия кнопки "Выход" и открывает LoginForm
        /// </summary>
        /// <param name="sender">Ссылка на кнопку "Выход"</param>
        /// <param name="e">Аргументы события</param>
        private void buttonChefLogout_Click(object sender, EventArgs e)
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
    }
}
