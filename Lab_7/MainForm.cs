using Logic;
using Model;

namespace Lab_7
{
    public partial class MainForm : Form
    {
        private UserStatus Role;
        private readonly Human CurrentUser;
        private BusinessLogic Logic;

        /// <summary>
        /// Инициализирует главное окно
        /// </summary>
        /// <param name="role">Роль текущего пользователя</param>
        /// <param name="client">Объект Client, или null, если пользователь – не клиент</param>
        /// <param name="logic">Единый экземпляр BusinessLogic для всего приложения</param>
        public MainForm(UserStatus role, Human currentUser, BusinessLogic logic)
        {
            InitializeComponent();
            Role = role;
            CurrentUser = currentUser;
            Logic = logic;

            Logic.FixateUser(currentUser);
            this.Shown += async (_, __) => await LoadRoleInterfaceAsync();
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
                        var clientControl = new ClientControl(CurrentUser as Client, Logic)
                        {
                            Dock = DockStyle.Fill
                        };
                        Controls.Clear();
                        Controls.Add(clientControl);
                        await clientControl.InitializeAsync();
                    }
                    break;

                case UserStatus.Waiter:
                    {
                        var waiterControl = new WaiterControl(CurrentUser as Waiter, Logic)
                        {
                            Dock = DockStyle.Fill
                        };
                        this.Controls.Clear();
                        this.Controls.Add(waiterControl);
                        await waiterControl.InitializeAsync();
                    }
                    break;

                case UserStatus.Chef:
                    userControl = new ChefControl(Logic) { Dock = DockStyle.Fill };
                    break;

                case UserStatus.Courier:
                    userControl = new CourierControl(Logic) { Dock = DockStyle.Fill };
                    break;

                case UserStatus.Admin:
                    userControl = new AdminControl(Logic) { Dock = DockStyle.Fill };
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
