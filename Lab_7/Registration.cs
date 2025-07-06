using Logic;
using Model;

namespace Lab_7
{
    public partial class Registration : Form
    {

        private readonly BusinessLogic Logic;

        /// <summary>
        /// Устанавливает источник данных для выбора статуса пользователя
        /// </summary>
        /// <param name="logic">Объект бизнес-логики, используемый для регистрации</param>
        public Registration(BusinessLogic logic)
        {
            InitializeComponent();
            Logic = logic;
            StatusBox.DataSource = Enum.GetValues(typeof(UserStatus));
        }

        /// <summary>
        /// Обработчик события нажатия кнопки регистрации
        /// Выполняет проверку введённых данных и регистрирует нового сотрудника
        /// </summary>
        /// <param name="sender">Источник события: кнопка регистрации</param>
        /// <param name="e">Объект, содержащий данные события.</param>
        private async void registrationButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;

            // Проверка правильности ввода
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Оставляем только цифры
            string phnumber = new string(PhoneBox.Text.Where(char.IsDigit).ToArray());
            if (phnumber.Length != 10)
            {
                MessageBox.Show("Введите корректный номер телефона");
                return;
            }

            UserStatus status = (UserStatus)StatusBox.SelectedItem;


            try
            {
                await Logic.RegistrateWorkerAsync(NameBox.Text.Trim(), status, phnumber);

                // получаем последнего зарегистрированного сотрудника
                var lastWorker = Logic.Workers.Last() as IWorker;

                LoginLabel.Text = lastWorker!.Login;
                PasswordLabel.Text = lastWorker.Password;

                MessageBox.Show("Сотрудник успешно зарегистрирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
