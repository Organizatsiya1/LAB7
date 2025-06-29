using Logic;
using Model;
using System.Data;

namespace Lab_7
{
    public partial class LoginForm : Form
    {
        private string verificationCode;
        private bool loadingCanceled;

        /// <summary>
        /// Экземпляр бизнес-логики всего приложения.
        /// </summary>
        public BusinessLogic Logic = new BusinessLogic();

        /// <summary>
        /// Инициализирует компоненты LoginForm, подписывается на переключение между
        /// режимами «Сотрудник» и «Клиент».
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            Task.Run(() => Logic.LoadClientsAsync());

            // По умолчанию выбираем «Сотрудник»
            radioEmployee.Checked = true;
            ToggleUserTypeFields();

            // Подписываемся на смену режима
            radioEmployee.CheckedChanged += (s, e) => ToggleUserTypeFields();
            radioClient.CheckedChanged += (s, e) => ToggleUserTypeFields();
        }

        /// <summary>
        /// Переключает видимость полей ввода в зависимости от того,
        /// вошёл ли пользователь как сотрудник (логин/пароль) или клиент (телефон/код).
        /// </summary>
        private void ToggleUserTypeFields()
        {
            bool isEmployee = radioEmployee.Checked;

            // Элементы для сотрудника
            labelLogin.Visible = isEmployee;
            textBoxLogin.Visible = isEmployee;
            labelPassword.Visible = isEmployee;
            textBoxPassword.Visible = isEmployee;

            // Элементы для клиента
            labelPhone.Visible = !isEmployee;
            maskedTextBoxPhone.Visible = !isEmployee;
            buttonSendCode.Visible = !isEmployee;
            labelCode.Visible = !isEmployee;
            maskedTextBoxCode.Visible = !isEmployee;

            // Очищаем неактивные поля
            if (isEmployee)
            {
                maskedTextBoxPhone.Clear();
                maskedTextBoxCode.Clear();
            }
            else
            {
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                maskedTextBoxPhone.Focus();
            }
        }

        /// <summary>
        /// Обработчик клика по кнопке «Отправить код» для клиента.
        /// Проверяет корректность телефона, при необходимости спрашивает,
        /// создавать ли нового клиента, и генерирует проверочный код.
        /// </summary>
        /// <param name="sender">Ссылка на саму кнопку</param>
        /// <param name="e">Аргументы события</param>
        private void ButtonSendCode_Click(object sender, EventArgs e)
        {
            // Вынимаем из маскированного поля только цифры
            string phoneDigits = new string(maskedTextBoxPhone.Text.Where(char.IsDigit).ToArray());

            // Проверка длины номера
            if (phoneDigits.Length != 10)
            {
                MessageBox.Show("Номер должен содержать 10 цифр!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка, есть ли уже клиент с таким телефоном
            bool phoneExists = CheckPhoneExists(phoneDigits);

            if (!phoneExists)
            {
                var result = MessageBox.Show(
                    "Номер не найден в базе. Продолжить?",
                    "Внимание",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                    return;
            }

            // Генерируем код и показываем уведомление
            GenerateAndShowCode();
        }

        /// <summary>
        /// Проверяет, существует ли клиент с указанным номером телефона
        /// Пока всегда возвращает false (заглушка)
        /// </summary>
        /// <param name="phoneDigits">Набор из 10 цифр без скобок и пробелов</param>
        /// <returns>True, если в базе уже есть клиент с таким телефоном; иначе false</returns>
        private bool CheckPhoneExists(string phoneDigits)
            => Logic.Clients.Any(c => c.PhoneNumber == phoneDigits);

        /// <summary>
        /// Генерирует четырёхзначный проверочный код и открывает форму уведомления.
        /// </summary>
        private void GenerateAndShowCode()
        {
            verificationCode = Logic.GenerateNumber();

            using (CodeNotification codeForm = new CodeNotification(verificationCode))
            {
                codeForm.ShowDialog();
            }
        }

        /// <summary>
        /// Проверяет корректность введённых данных: 
        /// если выбран «Сотрудник», проверяет логин/пароль;
        /// если «Клиент», проверяет формат телефона и введённый код.
        /// </summary>
        /// <returns>True, если всё введено корректно; иначе false.</returns>
        private bool ValidateInput()
        {
            if (radioEmployee.Checked)
            {
                if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
                {
                    MessageBox.Show("Введите логин", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    MessageBox.Show("Введите пароль", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                string phoneDigits = new string(maskedTextBoxPhone.Text.Where(char.IsDigit).ToArray());

                if (phoneDigits.Length != 10)
                {
                    MessageBox.Show("Номер должен содержать 10 цифр", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (maskedTextBoxCode.Text != verificationCode)
                {
                    MessageBox.Show("Неверный код подтверждения", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Асинхронная имитация загрузки данных с прогресс-баром.
        /// Позволяет отменять процесс через поле loadingCanceled.
        /// </summary>
        /// <returns>Task, завершающийся после симуляции загрузки.</returns>
        private async Task LoadDataAsync()
        {
            progressBar.Value = 0;
            progressBar.ForeColor = Color.LimeGreen;

            for (int i = 0; i <= 10; i++)
            {
                if (loadingCanceled)
                {
                    progressBar.ForeColor = Color.Red;
                    MessageBox.Show("Загрузка отменена", "Прерывание",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                progressBar.Value = i * 10;
                await Task.Delay(200);
            }
        }

        /// <summary>
        /// Обработчик кнопки «Отмена» во время загрузки.
        /// Устанавливает флаг loadingCanceled = true, чтобы прервать LoadDataAsync.
        /// </summary>
        /// <param name="sender">Ссылка на кнопку «Отмена»</param>
        /// <param name="e">Аргументы события</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            loadingCanceled = true;
        }

        /// <summary>
        /// Открывает главное окно MainForm, передаёт в него роль и объект клиента,
        /// затем скрывает текущую форму LoginForm.
        /// </summary>
        /// <param name="role">Роль пользователя (Client, Waiter, Admin и т. д.)</param>
        /// <param name="existingClient">Объект Client, соответствующий вошедшему клиенту</param>
        private void ShowMainForm(UserStatus role, Client existingClient)
        {
            MainForm mainForm = new MainForm(role, existingClient, Logic);
            mainForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Обработчик кнопки «Вход» (login). Проверяет введённые данные и, если всё верно,
        /// запускает симуляцию загрузки, затем открывает главное окно MainForm для нужной роли.
        /// </summary>
        /// <param name="sender">Ссылка на кнопку «Вход»</param>
        /// <param name="e">Аргументы события</param>
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (radioEmployee.Checked)
            {
                // Проверяем логин/пароль среди сотрудников
                string login = textBoxLogin.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                var worker = BusinessLogic.Workers
                    .OfType<IWorker>()
                    .FirstOrDefault(w => w.Login == login && w.Password == password);

                if (worker != null)
                {
                    // Нашли сотрудника; определяем его тип и роль
                    var human = BusinessLogic.Workers.First(h => (h as IWorker)?.Login == login);
                    string roleName = human.GetType().Name;

                    UserStatus role = roleName switch
                    {
                        nameof(Admin) => UserStatus.Admin,
                        nameof(Chef) => UserStatus.Chef,
                        nameof(Waiter) => UserStatus.Waiter,
                        nameof(Courier) => UserStatus.Courier,
                        _ => UserStatus.Client
                    };

                    // Начинаем симуляцию загрузки
                    progressBar.Visible = true;
                    buttonCancel.Visible = true;
                    loadingCanceled = false;

                    await LoadDataAsync();

                    if (!loadingCanceled)
                    {
                        await Logic.LoadDishesAsync();
                        // Передаём сотрудника (приведём к Client?)
                        // Здесь для «сотрудников» MainForm умеет принимать Human,
                        // но сигнатура ShowMainForm сейчас настроена только на Client.
                        // Для простоты, если это официант, приведём его к Client (неуместно),
                        // но оптимально — предусмотреть перегрузку, например:
                        // ShowMainForm(role, human as Client), но это плохо.
                        // В реальности лучше сделать перегрузку:
                        // ShowMainForm(UserStatus role, Human existingHuman).
                        // Ниже временная заглушка:
                        ShowMainForm(role, existingClient: null);
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (radioClient.Checked)
            {
                // Показ прогресса
                progressBar.Visible = true;
                buttonCancel.Visible = true;
                loadingCanceled = false;
                await LoadDataAsync();
                if (loadingCanceled) return;

                // 1) Загружаем список клиентов, если ещё не загружен
                if (Logic.Clients.Count == 0)
                    await Logic.LoadClientsAsync();

                // 2) Достаём цифры из маски и ищем клиента
                string phoneDigits = new string(maskedTextBoxPhone.Text.Where(char.IsDigit).ToArray());
                var existingClient = Logic.Clients.FirstOrDefault(c => c.PhoneNumber == phoneDigits);

                Client clientToShow;
                if (existingClient == null)
                {
                    await Logic.LoadDishesAsync();

                    // 3) Если клиента нет — создаём нового
                    clientToShow = new Client
                    {
                        Id = Logic.Clients.Any() ? Logic.Clients.Max(c => c.Id) + 1 : 1,
                        Name = "Новый клиент",
                        PhoneNumber = phoneDigits,
                        Adress = new Adress(),
                        Orders = new List<int>()
                    };

                    Logic.Clients.Add(clientToShow);
                    // 4) Сохраняем сразу же в JSON
                    await Logic.SaveClientsAsync();
                }
                else
                {
                    clientToShow = existingClient;
                }

                // 5) Фиксируем и уходим в MainForm
                Logic.FixateUser(clientToShow);
                ShowMainForm(UserStatus.Client, clientToShow);
            }
        }
    }
}
