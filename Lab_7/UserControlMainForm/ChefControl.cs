using Logic;
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
    public partial class ChefControl : UserControl
    {
        public BusinessLogic Logic { get; set; }
        public ChefControl()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
