using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Logic;
using Model;

namespace Lab_7
{
    public partial class LoginForm : Form
    {
        private string verificationCode;
        private bool loadingCanceled;
        public Logic.BusinessLogic Logic = new Logic.BusinessLogic();
        public LoginForm()
        {
            InitializeComponent();

            // По умолчанию выбран сотрудник
            radioEmployee.Checked = true;
            ToggleUserTypeFields();

            // Подписка на изменение выбора
            radioEmployee.CheckedChanged += (s, e) => ToggleUserTypeFields();
            radioClient.CheckedChanged += (s, e) => ToggleUserTypeFields();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ToggleUserTypeFields()
        {
            bool isEmployee = radioEmployee.Checked;

            // Показываем/скрываем элементы для сотрудника
            labelLogin.Visible = isEmployee;
            textBoxLogin.Visible = isEmployee;
            labelPassword.Visible = isEmployee;
            textBoxPassword.Visible = isEmployee;

            // Показываем/скрываем элементы для клиента
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

        private void ButtonSendCode_Click(object sender, EventArgs e)
        {
            string phoneDigits = new string(maskedTextBoxPhone.Text.Where(char.IsDigit).ToArray());

            // Проверка длины номера
            if (phoneDigits.Length != 10)
            {
                MessageBox.Show("Номер должен содержать 10 цифр!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на наличие номера в базе данных
            bool phoneExists = CheckPhoneExists(phoneDigits);

            if (!phoneExists)
            {
                var result = MessageBox.Show("Номер не найден в базе. Продолжить?", "Внимание",
                                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            // Генерация и показ кода
            GenerateAndShowCode();
        }

        private bool CheckPhoneExists(string phoneDigits) => false;
        // В реальном приложении здесь будет обращение к базе данных

        // Генерация кода и открытие уведомления
        private void GenerateAndShowCode()
        {
            verificationCode = Logic.GenerateNumber();

            // Показываем форму с кодом
            using (CodeNotification codeForm = new CodeNotification(verificationCode))
            {
                codeForm.ShowDialog();
            }
        }

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

        private async Task LoadDataAsync()
        {
            // Имитация загрузки данных
            for (int i = 0; i <= 10; i++)
            {
                if (loadingCanceled)
                    return;

                progressBar.Value = i * 10;
                await Task.Delay(300); // Задержка для имитации работы
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            loadingCanceled = true;
        }

        private void ShowMainForm(UserStatus role)
        {
            MainForm mainForm = new MainForm(role);
            mainForm.Show();
            this.Hide();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (radioEmployee.Checked)
            {
                string login = textBoxLogin.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Введите логин и пароль.");
                    return;
                }

                // Поиск среди сотрудников, реализующих IWorker
                var worker = BusinessLogic.Workers
                    .OfType<IWorker>()
                    .FirstOrDefault(w => w.Login == login && w.Password == password);

                if (worker != null)
                {
                    // Находим оригинальный объект Human (чтобы знать, кто он — Waiter, Chef и т.д.)
                    var human = BusinessLogic.Workers.First(h => (h as IWorker)?.Login == login);

                    string roleName = human.GetType().Name;
                    MessageBox.Show($"Вход выполнен как {roleName}!");

                    UserStatus role = roleName switch
                    {
                        nameof(Admin) => UserStatus.Admin,
                        nameof(Chef) => UserStatus.Chef,
                        nameof(Waiter) => UserStatus.Waiter,
                        nameof(Courier) => UserStatus.Courier,
                        _ => UserStatus.Client                  // если не совпало ни с кем — значит клиент
                    };

                    MainForm mainForm = new MainForm(role);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
            else if (radioClient.Checked)
            {
                // Проверка (код) уже пройдена в ValidateInput
                MessageBox.Show("Вход выполнен как клиент!");
                ShowMainForm(UserStatus.Client);
            }
        }
    }
}
