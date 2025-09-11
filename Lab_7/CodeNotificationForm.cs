namespace Lab_7
{
    public partial class CodeNotification : Form
    {
        /// <summary>
        /// ���������� ���������� ��� � ��������� ���� �����
        /// </summary>
        /// <param name="code">������ ����, ������� ����� ���������� � ��������� ���� �����������</param>
        public CodeNotification(string code)
        {
            InitializeComponent();
            textBoxCodNotification.Text = code;
        }

        /// <summary>
        /// ���������� ������� ������� ������ ������ (�������� �����������)
        /// ��������� ������� �����
        /// </summary>
        /// <param name="sender">�������� �������: ������ ������</param>
        /// <param name="e">������, ���������� ������ �������</param>
        private void buttonCancelCode_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
