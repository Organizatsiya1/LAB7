using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace Lab_7
{
    public partial class MainForm : Form
    {
        private UserStatus Role;
        private Client client;
        private BusinessLogic logic;

        /// <summary>
        /// Инициализирует главное окно
        /// </summary>
        /// <param name="role">Роль текущего пользователя</param>
        /// <param name="existingClient">Объект Client, или null, если пользователь – не клиент</param>
        /// <param name="sharedLogic">Единый экземпляр BusinessLogic для всего приложения</param>
        public MainForm(UserStatus role, Client existingClient, BusinessLogic sharedLogic)
        {
            InitializeComponent();
            Role = role;
            client = existingClient;
            logic = sharedLogic;
            LoadRoleInterface();
        }

        /// <summary>
        /// в зависимости от роли создаёт соответствующий UserControl
        /// передаёт ему нужные параметры и добавляет на форму
        /// </summary>
        private void LoadRoleInterface()
        {
            UserControl userControl = null;

            switch (Role)
            {
                case UserStatus.Client:
                    {
                        // Для клиента передаём объект client в конструктор контролла
                        var clientControl = new ClientControl(client)
                        {
                            Dock = DockStyle.Fill
                        };
                        this.Controls.Clear();
                        this.Controls.Add(clientControl);
                    }
                    break;

                case UserStatus.Waiter:
                    {
                        var waiterControl = new WaiterControl()
                        {
                            Dock = DockStyle.Fill
                        };
                        this.Controls.Clear();
                        this.Controls.Add(waiterControl);
                    }
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
                this.Controls.Clear();
                this.Controls.Add(userControl);
            }
        }
    }
}
