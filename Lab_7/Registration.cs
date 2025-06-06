using Logic;
using Model;
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
    public partial class Registration : Form
    {

        public BusinessLogic Logic { set; get; }


        public Registration(BusinessLogic logic)
        {
            InitializeComponent();
            Logic = logic;
            StatusBox.DataSource = Enum.GetValues(typeof(UserStatus));
        }

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
