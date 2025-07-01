using Logic;
using Model;

namespace Lab_7
{
    public partial class ProfileForm : Form
    {
        private readonly BusinessLogic Logic;
        public Client User { get; set; } // клиент, чьи данные показываются/редактируются в форме

        /// <summary>
        /// Конструктор, инициализирует поля формы значениями из объекта Client
        /// </summary>
        /// <param name="client">Экземпляр Client, чьё свойство отображается</param>
        public ProfileForm(Client client, BusinessLogic logic)
        {
            InitializeComponent();
            User = client;
            Logic = logic;

            // Заполняем текстовые поля данными клиента
            IDBox.Text = User.Id.ToString();
            NameBox.Text = User.Name;
            PhoneBox.Text = User.PhoneNumber;

            // Адрес может быть не заполнен – тогда свойства Adress будут default
            StreetBox.Text = User.Adress?.Street;
            HouseBox.Text = User.Adress?.HouseNumb.ToString();
            FlatBox.Text = User.Adress?.FlatNumb.ToString();
        }

        /// <summary>
        /// Открывает форму OrderForm для выбранного заказа двойным щелчком
        /// </summary>
        /// <param name="sender">Ссылка на DataGridView</param>
        /// <param name="e">Аргументы события CellDoubleClick</param>
        private void OrdersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Предполагается, что в каждой строке в скрытом столбце содержится объект Order
            var selectedOrder = OrdersGrid.Rows[e.RowIndex].Tag as Order;
            if (selectedOrder != null)
            {
                var orderForm = new OrderForm(selectedOrder);
                orderForm.ShowDialog();
            }
        }

        /// <summary>
        /// Сохраняет изменения полей в свойствах объекта User
        /// </summary>
        /// <param name="sender">Ссылка на кнопку "«Сохранить»"</param>
        /// <param name="e">Аргументы события</param>
        private async void SaveProfile_Click(object sender, EventArgs e)
        {
            User.Name = NameBox.Text.Trim();
            User.PhoneNumber = new string(PhoneBox.Text.Where(char.IsDigit).ToArray());

            if (int.TryParse(IDBox.Text, out int newId))
                User.Id = newId;

            // Если у User.Adress есть значение, записываем в него; иначе сначала создаём
            if (User.Adress == null)
                User.Adress = new Adress();

            User.Adress.Street = StreetBox.Text;

            if (int.TryParse(HouseBox.Text, out int hn))
                User.Adress.HouseNumb = hn;

            if (int.TryParse(FlatBox.Text, out int fn))
                User.Adress.FlatNumb = fn;

            await Logic.WriteAsync();

            MessageBox.Show("Профиль сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
