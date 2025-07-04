using Model;

namespace Logic
{
    public class BusinessLogic
    {
        public Human FixedUser { get; set; }
        private UserStatus Status { get; set; }
        private int OrdersID = 1;
        private int WorkersID = 1;

        private readonly DataConverter converter = new DataConverter();
        private const string ClientsFileName = "DataClients.json";

        public List<Client> Clients { get; private set; } = new List<Client>();

        /// <summary>
        /// Загружает клиентов из файла (вызывается при старте формы)
        /// </summary>
        public async Task LoadClientsAsync()
        {
            Clients = await converter.ReadClientsAsync(ClientsFileName);
        }

        /// <summary>
        /// Сохраняет текущих клиентов в файл (вызывается после добавления/изменения)
        /// </summary>
        public async Task SaveClientsAsync()
        {
            await converter.WriteClientsAsync(Clients, ClientsFileName);
        }

        // Статический список всех блюд (меню) в системе.
        public static List<Food> Foods { get; private set; } = new List<Food>();

        // Список всех заказов, созданных в системе.
        public List<Order> AllOrders { get; } = new List<Order>();
        public List<Order> CurrentOrders { get; set; } = new List<Order>();
        public List<Order> PayedOrders { get; set; } = new List<Order>();

        // Статический список всех сотрудников (Waiter, Chef, Admin, Courier).
        public static List<Human> Workers = new List<Human>()
        {
            new Waiter { Id = 1, Name = "Анна", Login = "anna", Password = "1234" },
            new Chef   { Id = 2, Name = "Борис", Login = "boris", Password = "chefpass" },
            new Admin  { Id = 3, Name = "Админ", Login = "admin", Password = "adminpass" },
            new Courier{ Id = 4, Name = "Пётр", Login = "petya", Password = "cour123" }
        };

        #region Menu

        /// <summary>
        /// Загрузка меню (Food) из какого-то источника (пока для наглядности)
        /// </summary>
        public void LoadFoods()
        {
            Foods = new List<Food>()
            {
                new Food
                {
                    Id = 1,
                    Name = "Брускетта с помидорами",
                    Description = "Классическая итальянская закуска",
                    Weight = 120,
                    CoockingTime = 5,
                    Cost = 150,
                    Priority = FoodCategory.Entree,
                    Formula = new List<string> { "Хлеб", "Томаты", "Оливковое масло", "Базилик" }
                },
                new Food
                {
                    Id = 2,
                    Name = "Томатный суп",
                    Description = "Тёплый суп с ароматом базилика",
                    Weight = 350,
                    CoockingTime = 10,
                    Cost = 200,
                    Priority = FoodCategory.MainCourse,
                    Formula = new List<string> { "Томаты", "Лук", "Чеснок", "Базилик" }
                },
                new Food
                {
                    Id = 3,
                    Name = "Стейк из говядины",
                    Description = "Стейк средней прожарки с соусом",
                    Weight = 250,
                    CoockingTime = 15,
                    Cost = 450,
                    Priority = FoodCategory.Entremets,
                    Formula = new List<string> { "Говядина", "Соль", "Перец", "Соус" }
                },
                new Food
                {
                    Id = 4,
                    Name = "Чизкейк",
                    Description = "Классический чизкейк с ягодным соусом",
                    Weight = 100,
                    CoockingTime = 20,
                    Cost = 250,
                    Priority = FoodCategory.Desserts,
                    Formula = new List<string> { "Сыр", "Печенье", "Сахар", "Ягоды" }
                },
                new Food
                {
                    Id = 5,
                    Name = "Кола",
                    Description = "Охлаждающий напиток",
                    Weight = 330,
                    CoockingTime = 0,
                    Cost = 100,
                    Priority = FoodCategory.Digestif,
                    Formula = new List<string> { "Вода", "Сахар", "Газ" }
                }
            };
        }

        #endregion

        /// <summary>
        /// Возвращает список блюд, название которых содержит переданную подстроку
        /// </summary>
        /// <param name="nameContains"> Подстрока для фильтрации в названиях (регистр игнорируется) </param>
        /// <returns> Список Food, у которых Name содержит nameContains </returns>
        public List<Food> GetFoodsByFilter(string nameContains)
        {
            if (string.IsNullOrWhiteSpace(nameContains))
                return Foods.ToList();

            string filter = nameContains.Trim().ToLower();
            return Foods
                .Where(f => f.Name.ToLower().Contains(filter))
                .ToList();
        }

        /// <summary>
        /// Ищет в в списке всех заказов заказы этого клиента, сортирует по убыванию Id
        /// и возвращает первый, который ещё не оплачен или не доставлен или статус не готов
        /// </summary>
        /// <param name="client"> Объект Client, для которого ищем заказ </param>
        /// <returns> заказ, который считается «текущим», либо null, если таких нет </returns>
        public Order GetCurrentOrderForClient(Client client)
        {
            if (client == null || client.Orders == null || client.Orders.Count == 0)
                return null;

            var clientOrders = AllOrders
                .Where(o => client.Orders.Contains(o.Id))
                .OrderByDescending(o => o.Id)
                .ToList();

            foreach (var o in clientOrders)
            {
                if (!o.IsPayed || !o.IsDelivered || o.Behavior != OrderBehavior.IsDone)
                    return o;
            }
            return null;
        }

        /// <summary>
        /// Создаёт новый заказ для клиента (доставка или самовывоз) и добавляет его в список всех заказов
        /// </summary>
        /// <param name="client"> Клиент, который оформляет заказ </param>
        /// <param name="cartFoods"> Список блюд, которые входят в заказ </param>
        /// <param name="tableID"> Номер стола (если самовывоз), иначе 0 </param>
        /// <param name="waiterID"> ID официанта, оформившего заказ </param>
        /// <param name="payementType"> Тип оплаты (наличные, карта и т. д.) </param>
        /// <param name="isDelivery"> Флаг, указывающий, что заказ – на доставку </param>
        /// <param name="deliveryAdress"> Адрес доставки (если isDelivery = true) </param>
        /// <param name="courierId"> ID курьера (если доставка).</param>
        /// <returns> Созданный объект заказа или доставки заказа, либо null при ошибке входных данных </returns>
        public Order CreateOrderForClient(
            Client client,
            List<Food> cartFoods,
            int tableID,
            int waiterID,
            PayementType payementType,
            bool isDelivery = false,
            Adress deliveryAdress = null,
            int courierId = 0)
        {
            if (client == null || cartFoods == null || cartFoods.Count == 0)
                return null;

            Order newOrder;
            if (isDelivery)
            {
                var dOrder = new DeliveredOrder
                {
                    Id = OrdersID,
                    Foods = cartFoods.ToList(),
                    IsDelivered = false,
                    IsPayed = false,
                    TableID = 0,
                    WaiterID = waiterID,
                    PayementType = payementType,
                    Behavior = OrderBehavior.IsCoocking,
                    CourierId = courierId,
                    DeliveryAdress = deliveryAdress
                };
                newOrder = dOrder;
                dOrder.Date = DateTime.Now;
            }
            else
            {
                newOrder = new Order
                {
                    Id = OrdersID,
                    Foods = cartFoods.ToList(),
                    IsDelivered = false,
                    IsPayed = false,
                    TableID = tableID,
                    WaiterID = waiterID,
                    PayementType = payementType,
                    Behavior = OrderBehavior.IsCoocking
                };
                newOrder.Date = DateTime.Now;
            }

            OrdersID++;
            AllOrders.Add(newOrder);
            CurrentOrders.Add(newOrder);
            if (client.Orders == null)
                client.Orders = new List<int>();
            client.Orders.Add(newOrder.Id);

            return newOrder;
        }

        /// <summary>
        /// Генерация случайного четырёхзначного кода (строка из цифр)
        /// </summary>
        /// <returns>Четырёхзначная строка, сгенерированная случайно</returns>
        public string GenerateNumber()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }

        /// <summary>
        /// Проверяет, может ли текущий пользователь сделать заказ
        /// Если да, создаёт Order со статусом "готовится"
        /// </summary>
        /// <param name="foods">Список Food, включённых в заказ</param>
        /// <param name="tableID">Номер стола</param>
        /// <param name="waiterID">ID официанта</param>
        /// <param name="payementType">Тип оплаты</param>
        /// <returns>Новый объект заказа или null</returns>
        public Order MakeOrder(List<Food> foods, int tableID, int waiterID, PayementType payementType)
        {
            if (FixedUser?.Permissions.HasFlag(Permissions.MakeOrder) == true)
            {
                var made = new Order
                {
                    Id = OrdersID,
                    Foods = foods,
                    IsDelivered = false,
                    IsPayed = false,
                    TableID = tableID,
                    WaiterID = waiterID,
                    PayementType = payementType,
                    Behavior = OrderBehavior.IsCoocking
                };
                made.Date = DateTime.Now;

                OrdersID++;
                AllOrders.Add(made);
                CurrentOrders.Add(made);
                return made;
            }
            return null;
        }

        /// <summary>
        /// Возвращает клиента по его уникальному ID (или null, если не найден)
        /// </summary>
        /// <param name="clientId">ID клиента, которого ищем</param>
        /// <returns>Объект Client с заданным ID либо null</returns>
        public Client GetClientById(int clientId)
        {
            return Clients.FirstOrDefault(c => c.Id == clientId);
        }

        /// <summary>
        /// Возвращает официанта (Waiter) по его уникальному ID (или null, если не найден)
        /// </summary>
        /// <param name="waiterId">ID официанта</param>
        /// <returns>Объект Waiter с заданным ID либо null</returns>
        public Waiter GetWaiterById(int waiterId)
        {
            return Workers
                .OfType<Waiter>()
                .FirstOrDefault(w => w.Id == waiterId);
        }

        /// <summary>
        /// Фиксирует текущего пользователя (FixedUser) и его роль (Status)
        /// </summary>
        /// <param name="user">Объект Human</param>
        public void FixateUser(Human user)
        {
            if (user is Admin)
            {
                FixedUser = user;
                Status = UserStatus.Admin;
            }
            else if (user is Client)
            {
                FixedUser = user;
                Status = UserStatus.Client;
            }
            else if (user is Waiter)
            {
                FixedUser = user;
                Status = UserStatus.Waiter;
            }
            else if (user is Chef)
            {
                FixedUser = user;
                Status = UserStatus.Chef;
            }
            else if (user is Courier)
            {
                FixedUser = user;
                Status = UserStatus.Courier;
            }
        }

        /// <summary>
        /// Помечает заказ как оплаченный, если у FixedUser есть право MarkPayed
        /// </summary>
        /// <param name="order">Объект Order, который нужно пометить как оплаченный</param>
        public void MarkPayed(Order order)
        {
            if (FixedUser?.Permissions.HasFlag(Permissions.MarkPayed) == true)
            {
                order.IsPayed = true;
                CurrentOrders.Remove(order);
                PayedOrders.Add(order);
            }
        }

        /// <summary>
        /// Регистрирует нового сотрудника
        /// генерирует для него логин и пароль и добавляет в список Workers
        /// </summary>
        /// <param name="name">Имя нового сотрудника</param>
        /// <param name="status">Роль сотрудника</param>
        /// <param name="phone">Телефон (используется для формирования логина)</param>
        public void RegistrateWorker(string name, UserStatus status, string phone)
        {
            if (status == UserStatus.Admin)
            {
                Workers.Add(new Admin
                {
                    Id = WorkersID,
                    Login = name + phone,
                    Password = GeneratePassword(),
                    Name = name
                });
            }
            else if (status == UserStatus.Chef)
            {
                Workers.Add(new Chef
                {
                    Id = WorkersID,
                    Login = name + phone,
                    Password = GeneratePassword(),
                    Name = name
                });
            }
            else if (status == UserStatus.Waiter)
            {
                Workers.Add(new Waiter
                {
                    Id = WorkersID,
                    Login = name + phone,
                    Password = GeneratePassword(),
                    Name = name
                });
            }
            else if (status == UserStatus.Courier)
            {
                Workers.Add(new Courier
                {
                    Id = WorkersID,
                    Login = name + phone,
                    Password = GeneratePassword(),
                    Name = name
                });
            }

            WorkersID++;
        }

        /// <summary>
        /// Генерирует случайный пароль длиной 10 символов,
        /// включающий прописные буквы, цифры и спецсимволы
        /// </summary>
        /// <returns>Сгенерированная строка-пароль из 10 символов</returns>
        public string GeneratePassword()
        {
            string letters = "qwertyuioplkjhgfdsazxcvbnm";
            string bigletters = "QWERTYUIOPLKJHGFDSAZXCVBNM";
            string numbers = "1234567890";
            string symbols = "!@#$%^&*?";
            Random r = new Random();
            string all = letters + bigletters + numbers + symbols;
            char[] password = new char[10];

            password[0] = letters[r.Next(letters.Length)];
            password[1] = bigletters[r.Next(bigletters.Length)];
            password[2] = numbers[r.Next(numbers.Length)];
            password[3] = symbols[r.Next(symbols.Length)];

            for (int i = 4; i < 10; i++)
            {
                password[i] = all[r.Next(all.Length)];
            }

            // Перемешиваем символы
            return new string(password.OrderBy(x => r.Next()).ToArray());
        }

        /// <summary>
        /// Пример метода, который мог бы группировать список блюд
        /// </summary>
        /// <param name="foods">Список Food, который нужно сгруппировать</param>
        /// <param name="groupedFoods">Сюда складываем результат</param>
        public void GroupFoods(List<Food> foods, List<GroupedFood> groupedFoods)
        {

        }
    }
}
