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

        private async Task LoadDataAsync()  // загрузка имитация работы
        {
            progressBar.Value = 0;
            progressBar.ForeColor = Color.LimeGreen;

            for (int i = 0; i <= 10; i++)
            {
                if (loadingCanceled)
                {
                    progressBar.ForeColor = Color.Red;
                    MessageBox.Show("Загрузка отменена", "Прерывание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                progressBar.Value = i * 10;
                await Task.Delay(200);
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


        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (radioEmployee.Checked)
            {
                string login = textBoxLogin.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                var worker = BusinessLogic.Workers
                    .OfType<IWorker>()
                    .FirstOrDefault(w => w.Login == login && w.Password == password);

                if (worker != null)
                {
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

                    // здесь вызывается загрузка
                    progressBar.Visible = true;
                    buttonCancel.Visible = true;
                    loadingCanceled = false;

                    await LoadDataAsync();

                    if (!loadingCanceled)
                    {
                        ShowMainForm(role);
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
            else if (radioClient.Checked)
            {
                // Аналогичная логика — только если проверка пройдена
                progressBar.Visible = true;
                buttonCancel.Visible = true;
                loadingCanceled = false;

                await LoadDataAsync();

                if (!loadingCanceled)
                {
                    ShowMainForm(UserStatus.Client);
                }
            }
        }
    }
}
