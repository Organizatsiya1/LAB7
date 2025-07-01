using Logic;
using Model;

namespace Lab_7
{
    public partial class Registration : Form
    {

        public BusinessLogic Logic { set; get; }

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
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string phnumber = PhoneBox.Text;

            // Проверка правильности ввода
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите имя сотрудника");
                return;
            }

            if (phnumber.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Length != 10)
            {
                MessageBox.Show("Введите корректный номер телефона");
                return;
            }

            UserStatus status = (UserStatus)StatusBox.SelectedValue;


            try
            {
                Logic.RegistrateWorker(name, status, phnumber);

                // получаем последнего зарегистрированного сотрудника
                var lastWorker = BusinessLogic.Workers[^1] as IWorker;

                if (lastWorker != null)
                {
                    LoginLabe.Text = lastWorker.Login;
                    PasswordLabe.Text = lastWorker.Password;

                    MessageBox.Show("Регистрация успешно завершена!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка регистрации: {ex.Message}");
            }
        }
    }
}
