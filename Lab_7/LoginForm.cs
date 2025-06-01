using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class LoginForm : Form
    {
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
            }
        }

        private void maskedTextBoxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string digits = new string(maskedTextBoxPhone.Text.Where(char.IsDigit).ToArray());

            // Сдвигаем номер влево удаляя префикс 8 или 7
            if (digits.StartsWith("7") || digits.StartsWith("8"))
            {
                digits = digits.Substring(1);
            }

            maskedTextBoxPhone.Text = digits;
        }

        private void maskedTextBoxCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Проверяем, что номер заполнен полностью
            if (maskedTextBoxPhone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Length != 10)
            {
                MessageBox.Show("Номер должен содержать 10 цифр!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
