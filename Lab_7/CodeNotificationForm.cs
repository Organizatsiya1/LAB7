namespace Lab_7
{
    public partial class CodeNotification : Form
    {
        public CodeNotification(string code)
        {
            InitializeComponent();
            textBoxCodNotification.Text = code;
        }

        private void buttonCancelCode_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
