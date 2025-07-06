using System.Data;
using Logic;
using Model;

namespace Lab_7
{
    public partial class OrderForClientForm : Form
    {
        private readonly Client currentClient;
        private readonly BusinessLogic Logic;
        private readonly List<Food> cartFoods;
        private double orderCost;
        private double deliveryCost;

        public OrderForClientForm(Client client, BusinessLogic logic, List<Food> cartFoods)
        {
            InitializeComponent();

            currentClient = client;
            Logic = logic;
            this.cartFoods = cartFoods;

            // заполняем меню и корзину
            PopulateCart();
            UpdateCosts();

            // настройка доставки
            cbDeliveryType.SelectedIndex = 0;
            cbDeliveryType.SelectedIndexChanged += (s, e) =>
            {
                deliveryCost = cbDeliveryType.SelectedIndex == 1 ? CalculateDeliveryCost() : 0;
                gbRecipient.Enabled = cbDeliveryType.SelectedIndex == 1;
                UpdateCosts();
            };

            // переключатели получателя
            rbSelf.CheckedChanged += (s, e) => ToggleRecipientFields();
            rbOther.CheckedChanged += (s, e) => ToggleRecipientFields();
            ToggleRecipientFields();

            // подтверждение
            btnConfirm.Click += async (s, e) =>
            {
                if (cbDeliveryType.SelectedIndex == 1 && rbOther.Checked)
                {
                    if (string.IsNullOrWhiteSpace(tbStreet.Text) ||
                        string.IsNullOrWhiteSpace(tbHouse.Text) ||
                        string.IsNullOrWhiteSpace(tbApartment.Text) ||
                        string.IsNullOrWhiteSpace(tbRecipientName.Text) ||
                        string.IsNullOrWhiteSpace(tbRecipientPhone.Text))
                    {
                        MessageBox.Show("Заполните все данные получателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // готовим адрес
                Adress addr = null;
                if (cbDeliveryType.SelectedIndex == 1)
                {
                    addr = new Adress
                    {
                        Street = tbStreet.Text.Trim(),
                        HouseNumb = int.Parse(tbHouse.Text),
                        FlatNumb = int.Parse(tbApartment.Text),
                        // координаты присваиваются внутри DataConverter/Logic
                    };
                }

                // создаём заказ
                var newOrder = await Logic.CreateOrderForClientAsync(
                    currentClient,
                    cartFoods,
                    tableID: 0,
                    waiterID: 0,
                    payementType: (PayementType)cbPaymentType.SelectedIndex,
                    isDelivery: cbDeliveryType.SelectedIndex == 1,
                    deliveryAdress: addr,
                    courierId: 0);

                if (newOrder == null)
                {
                    MessageBox.Show("Не удалось оформить заказ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // показываем итоговый экран
                using (var preview = new OrderForm(newOrder))
                    preview.ShowDialog();

                DialogResult = DialogResult.OK;
            };

            btnBack.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void PopulateCart()
        {
            // cartFoods уже сформирован в ClientControl
            listViewCart.BeginUpdate();
            listViewCart.Items.Clear();
            var grouped = cartFoods
                .GroupBy(f => f.Id)
                .Select(g => new
                {
                    Dish = g.First(),
                    Quantity = g.Count(),
                    Sum = g.Sum(x => x.Cost)
                });
            foreach (var e in grouped)
            {
                var item = new ListViewItem(new[] {
                    e.Dish.Name,
                    e.Quantity.ToString(),
                    e.Sum.ToString("F2")
                })
                { Tag = e.Dish };
                listViewCart.Items.Add(item);
            }
            listViewCart.EndUpdate();

            orderCost = grouped.Sum(x => x.Sum);
        }

        private double CalculateDeliveryCost()
        {
            // например фиксированная плата 200
            return 200;
        }

        private void UpdateCosts()
        {
            lblOrderCost.Text = $"Стоимость заказа: {orderCost:F2} руб.";
            lblDeliveryCost.Text = $"Стоимость доставки: {deliveryCost:F2} руб.";
            lblTotalCost.Text = $"Итоговая сумма: {(orderCost + deliveryCost):F2} руб.";
        }

        private void ToggleRecipientFields()
        {
            bool other = rbOther.Checked;
            tbStreet.Enabled = other;
            tbHouse.Enabled = other;
            tbApartment.Enabled = other;
            tbRecipientName.Enabled = other;
            tbRecipientPhone.Enabled = other;
        }

        private void listViewCart_DoubleClick(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count == 0) return;
            var food = (Food)listViewCart.SelectedItems[0].Tag;
            using (var detail = new FoodForm(food))
                detail.ShowDialog();
        }
    }
}
