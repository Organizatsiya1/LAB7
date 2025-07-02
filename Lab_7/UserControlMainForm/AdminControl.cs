using Logic;
using Model;

namespace Lab_7
{
    public partial class AdminControl : UserControl
    {
        private readonly BusinessLogic Logic;

        public AdminControl(BusinessLogic logic)
        {
            InitializeComponent();
            Logic = logic;

            comboBoxAdminEmployeeType.SelectedIndex = 0;

            LoadEmployees();
        }

        /// <summary>
        /// При смене фильтра – обновляем список
        /// </summary>
        private void comboBoxAdminEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
            => LoadEmployees();

        /// <summary>
        /// Заполняем listView и считаем метрику админа
        /// </summary>
        private void LoadEmployees()
        {
            // 1) Фильтрация
            string sel = comboBoxAdminEmployeeType.SelectedItem.ToString();
            var filtered = sel switch
            {
                "Официант" => Logic.Workers.OfType<Waiter>().Cast<Human>(),
                "Повар" => Logic.Workers.OfType<Chef>().Cast<Human>(),
                "Курьер" => Logic.Workers.OfType<Courier>().Cast<Human>(),
                "Администратор" => Logic.Workers.OfType<Admin>().Cast<Human>(),
                _ => Logic.Workers
            };

            // 2) Сортировка по эффективности IWorker
            var sorted = filtered
                .OrderByDescending(h => (h as IWorker)?.Efficiency ?? 0)
                .ToList();

            // 3) Наполнение ListView
            listViewAdminEmployees.Items.Clear();
            foreach (var h in sorted)
            {
                int eff = (h as IWorker)?.Efficiency ?? 0;
                var item = new ListViewItem(new[]
                {
                    h.Id.ToString(),
                    h.Name,
                    h.GetType().Name,
                    h.PhoneNumber,
                    (h as IWorker)?.Login ?? "",
                    eff.ToString()
                });
                item.Tag = h;
                listViewAdminEmployees.Items.Add(item);
            }

            if (Logic.FixedUser is Admin)
            {
                int total = Logic.Workers
                                 .OfType<IWorker>()
                                 .Sum(w => w.Efficiency);
                labelAdminMetric.Text = $"Эффективность администратора: {total}";
            }
        }

        /// <summary>
        /// Открываем окно статистики клиентов
        /// </summary>
        private void buttonStatsAdmin_Click(object sender, EventArgs e)
        {
            using var stats = new StatisticsForm(Logic);
            stats.ShowDialog();
        }

        /// <summary>Открываем форму регистрации нового сотрудника</summary>
        private void buttonAdminRegisterEmployee_Click(object sender, EventArgs e)
        {
            using var reg = new Registration(Logic);
            if (reg.ShowDialog() == DialogResult.OK)
                LoadEmployees();
        }

        private void buttonAdminProfile_Click(object sender, EventArgs e)
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

        
    }
}
