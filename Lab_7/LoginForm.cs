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

namespace Lab_7
{
    public partial class LoginForm : Form
    {
        private string verificationCode;
        private bool loadingCanceled;

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
            Random random = new Random();
            verificationCode = random.Next(1000, 9999).ToString();

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

        private void ShowMainForm()
        {
            // Создаем и переходим в главное окно
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // Закрываем текущее окно входа
            this.Hide();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            // Блокируем кнопку входа
            buttonLogin.Enabled = false;
            progressBar.Visible = true;
            buttonCancel.Visible = true;
            loadingCanceled = false;

            try
            {
                // Имитация загрузки данных
                await LoadDataAsync();

                if (!loadingCanceled)
                {
                    // Переход в главное окно
                    ShowMainForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка входа",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonLogin.Enabled = true;
                progressBar.Visible = false;
                buttonCancel.Visible = false;
            }
        }
    }
}
