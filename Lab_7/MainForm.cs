using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Lab_7
{
    public partial class MainForm : Form
    {
        private UserStatus Role;

        public MainForm(UserStatus role)
        {
            InitializeComponent();
            Role = role;
            LoadRoleInterface();
        }

        private void LoadRoleInterface()
        {
            UserControl userControl = null;

            switch (Role)
            {
                case UserStatus.Client:
                    userControl = new ClientControl() { Dock = DockStyle.Fill };
                    break;
                case UserStatus.Waiter:
                    userControl = new WaiterControl() { Dock = DockStyle.Fill };
                    break;
                case UserStatus.Chef:
                    userControl = new ChefControl() { Dock = DockStyle.Fill };
                    break;
                case UserStatus.Courier:
                    userControl = new CourierControl() { Dock = DockStyle.Fill };
                    break;
                case UserStatus.Admin:
                    userControl = new AdminControl() { Dock = DockStyle.Fill };
                    break;
            }
            if (userControl != null)
            {
                this.Controls.Clear();      // убираем всё, что могло быть на форме
                this.Controls.Add(userControl);      // и заполняем главную панель нужными элементами
            }
        }
    }
}
