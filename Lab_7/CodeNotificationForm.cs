namespace Lab_7
{
    public partial class CodeNotification : Form
    {
        /// <summary>
        /// Отображает переданный код в текстовом поле формы
        /// </summary>
        /// <param name="code">Строка кода, которая будет отображена в текстовом поле уведомления</param>
        public CodeNotification(string code)
        {
            InitializeComponent();
            textBoxCodNotification.Text = code;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки отмены (закрытия уведомления)
        /// Закрывает текущую форму
        /// </summary>
        /// <param name="sender">Источник события: кнопка отмены</param>
        /// <param name="e">Объект, содержащий данные события</param>
        private void buttonCancelCode_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
