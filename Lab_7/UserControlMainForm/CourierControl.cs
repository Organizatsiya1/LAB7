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
    public partial class CourierControl : UserControl
    {
        public CourierControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрывает окно для текущего клиента после нажатия кнопки "Выход" и открывает LoginForm
        /// </summary>
        /// <param name="sender">Ссылка на кнопку "Выход"</param>
        /// <param name="e">Аргументы события</param>
        private void buttonCourierTakeOrder_Click(object sender, EventArgs e)
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
