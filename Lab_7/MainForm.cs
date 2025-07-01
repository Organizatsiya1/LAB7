using Logic;
using Model;

namespace Lab_7
{
    public partial class MainForm : Form
    {
        private UserStatus Role;
        private Client Client;
        private BusinessLogic Logic;

        /// <summary>
        /// Инициализирует главное окно
        /// </summary>
        /// <param name="role">Роль текущего пользователя</param>
        /// <param name="client">Объект Client, или null, если пользователь – не клиент</param>
        /// <param name="logic">Единый экземпляр BusinessLogic для всего приложения</param>
        public MainForm(UserStatus role, Client client, BusinessLogic logic)
        {
            InitializeComponent();
            Role = role;
            Client = client;
            Logic = logic;

            LoadRoleInterfaceAsync();
        }

        /// <summary>
        /// в зависимости от роли создаёт соответствующий UserControl
        /// передаёт ему нужные параметры и добавляет на форму
        /// </summary>
        private async Task LoadRoleInterfaceAsync()
        {
            UserControl userControl = null;

            switch (Role)
            {
                case UserStatus.Client:
                    {
                        // Для клиента передаём объект client в конструктор контролла
                        var clientControl = new ClientControl(Client, Logic)
                        {
                            Dock = DockStyle.Fill
                        };
                        Controls.Clear();
                        Controls.Add(clientControl);
                        await clientControl.InitializeAsync();
                    }
                    break;

                //case UserStatus.Waiter:
                //    {
                //        var waiterControl = new WaiterControl(Client)
                //        {
                //            Dock = DockStyle.Fill
                //        };
                //        this.Controls.Clear();
                //        this.Controls.Add(waiterControl);
                //    }
                //    break;

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
