using Logic;
using Model;

namespace Lab_7
{
    public partial class ProfileForm : Form
    {
        private readonly BusinessLogic Logic;
        public Human User { get; set; } // клиент, чьи данные показываются/редактируются в форме

        /// <summary>
        /// Конструктор, инициализирует поля формы значениями из объекта Client
        /// </summary>
        /// <param name="client">Экземпляр Client, чьё свойство отображается</param>
        public ProfileForm(Human user, BusinessLogic logic)
        {
            InitializeComponent();
            User = user;
            Logic = logic;

            // Заполняем текстовые поля общими данными
            NameBox.Text = User.Name;
            PhoneBox.Text = User.PhoneNumber;

            // Если это клиент — покажем адрес и заказы
            if (User is Client client)
            {
                IDBox.Text = User.Id.ToString();
                StreetBox.Text = client.Adress?.Street;
                HouseBox.Text = client.Adress?.HouseNumb.ToString();
                FlatBox.Text = client.Adress?.FlatNumb.ToString();

                // Заполнить таблицу заказов клиента:
                // OrdersGrid.DataSource = logic.AllOrders.Where(o => client.Orders.Contains(o.Id)).ToList();
            }
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

            // Только для клиента — адрес
            if (User is Client client)
            {
                client.Adress ??= new Adress();
                client.Adress.Street = StreetBox.Text;
                if (int.TryParse(HouseBox.Text, out int hn)) client.Adress.HouseNumb = hn;
                if (int.TryParse(FlatBox.Text, out int fn)) client.Adress.FlatNumb = fn;
            }

            await Logic.WriteAsync();
            MessageBox.Show("Профиль сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
