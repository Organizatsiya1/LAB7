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
    public partial class Profile : Form
    {
        public Client User { get; set; }
        public Profile(Client client)
        {
            InitializeComponent();
            User = client;
            IDBox.Text = User.Id.ToString();
            NameBox.Text = User.Name;
            PhoneBox.Text = User.PhoneNumber;
            StreetBox.Text = User.Adress.Street;
            HouseBox.Text = User.Adress.HouseNumb.ToString();
            FlatBox.Text = User.Adress.FlatNumb.ToString();
        }

        private void OrdersGrid_CellDoubleClick(object sender, EventArgs e)
        {
            Model.Order selected = sender as Model.Order;
            Order OrderForm = new Order(selected);
        }

        private void SaveProfile_Click(object sender, EventArgs e)
        {
            User.Name = NameBox.Text;
            User.PhoneNumber = PhoneBox.Text;
            int.TryParse(IDBox.Text, out int value);
            User.Id = value;
            User.Adress.Street = StreetBox.Text;
            int.TryParse(HouseBox.Text, out int valueHnumb);
            User.Adress.HouseNumb = valueHnumb;
            int.TryParse(FlatBox.Text, out int valueFlat);
            User.Adress.FlatNumb = valueFlat;
        }
    }
}
