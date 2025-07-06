using Model;

namespace Logic
{
    public class BusinessLogic
    {
        public Human FixedUser { get; set; }
        private UserStatus Status { get; set; }
        private int OrdersID = 1;

        private readonly DataConverter converter = new DataConverter();

        public List<Client> Clients { get; private set; } = new List<Client>();
        public List<Food> Dishes { get; private set; } = new List<Food>();
        public List<Order> AllOrders { get; private set; } = new List<Order>();
        public List<Human> Workers { get; private set; } = new List<Human>();

        /// <summary> 
        /// Загружает из файлов клиентов, блюда и заказы 
        /// </summary>
        public async Task ReadAsync()
        {
            Clients = await converter.ReadClientsAsync();
            Dishes = await converter.ReadDishesAsync();
            AllOrders = await converter.ReadOrdersAsync();
            Workers = await converter.ReadWorkersAsync();
        }

        /// <summary> 
        /// Сохраняет в файлы клиентов, блюда (по необходимости) и заказы 
        /// </summary>
        public async Task WriteAsync()
        {
            await converter.WriteClientsAsync(Clients);
            await converter.WriteOrdersAsync(AllOrders);
            await converter.WriteWorkersAsync(Workers);
        }

        /// <summary>
        /// Возвращает список блюд, название которых содержит переданную подстроку
        /// </summary>
        /// <param name="nameContains"> Подстрока для фильтрации в названиях (регистр игнорируется) </param>
        /// <returns> Список Food, у которых Name содержит nameContains </returns>
        public List<Food> GetFoodsByFilter(string nameContains)
        {
            if (string.IsNullOrWhiteSpace(nameContains))
                return Dishes.ToList();

            string filter = nameContains.Trim().ToLower();
            return Dishes
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
        /// <summary>
        /// Создаёт новый заказ, добавляет в AllOrders и сразу сохраняет в файл
        /// </summary>
        public async Task<Order> CreateOrderForClientAsync(
            Client client,
            List<Food> cartFoods,
            int tableID,
            int waiterID,
            PayementType payementType,
            bool isDelivery = false,
            Adress deliveryAdress = null,
            int courierId = 0)

        {
            if (client == null || cartFoods.Count == 0)
                return null;

            var orderedFoods = cartFoods.Select(f => new OrderedFood
            {
                Food = f,
                IsReady = false
            }).ToList();

            // Сгенерируем новый Id по текущему файлу
            int newId = AllOrders.Any() ? AllOrders.Max(o => o.Id) + 1 : 1;

            Order newOrder = isDelivery
                ? new DeliveredOrder
                {
                    Id = newId,
                    Foods = orderedFoods,
                    Date = DateTime.Now,
                    IsDelivered = false,
                    IsPayed = false,
                    TableID = 0,
                    WaiterID = waiterID,
                    PayementType = payementType,
                    Behavior = OrderBehavior.IsCoocking,
                    CourierId = courierId,
                    DeliveryAdress = deliveryAdress
                }
                : new Order
                {
                    Id = newId,
                    Foods = orderedFoods,
                    Date = DateTime.Now,
                    IsDelivered = false,
                    IsPayed = false,
                    TableID = tableID,
                    WaiterID = waiterID,
                    PayementType = payementType,
                    Behavior = OrderBehavior.IsCoocking
                };

            AllOrders.Add(newOrder);

            if (client.Orders == null)
                client.Orders = new List<int>();
            client.Orders.Add(newId);

            // Сохраняем сразу и клиентов (т.к. мы добавили новый order.Id в client.Orders)
            await WriteAsync();
            return newOrder;
        }

        public async Task<Order> CreateOrderForWaiterAsync(
            Waiter waiter,
            List<Food> cartFoods,
            int tableID,
            bool isDelivery,
            int clientId)
        {
            if (waiter == null || cartFoods == null || cartFoods.Count == 0)
                return null;

            // Конвертируем Food → OrderedFood
            var orderedFoods = cartFoods
                .Select(f => new OrderedFood { Food = f, IsReady = false })
                .ToList();

            // Генерируем новый ID
            int newId = AllOrders.Any() ? AllOrders.Max(o => o.Id) + 1 : 1;

            // Создаём заказ
            Order newOrder = isDelivery
                ? new DeliveredOrder
                {
                    Id = newId,
                    Foods = orderedFoods,
                    Date = DateTime.Now,
                    IsDelivered = false,
                    IsPayed = false,
                    TableID = 0,
                    WaiterID = waiter.Id,
                    PayementType = PayementType.Cash,
                    Behavior = OrderBehavior.IsCoocking,
                    CourierId = 0,
                    DeliveryAdress = null
                }
                : new Order
                {
                    Id = newId,
                    Foods = orderedFoods,
                    Date = DateTime.Now,
                    IsDelivered = false,
                    IsPayed = false,
                    TableID = tableID,
                    WaiterID = waiter.Id,
                    PayementType = PayementType.Cash,
                    Behavior = OrderBehavior.IsCoocking
                };

            // Считаем стоимость сразу
            newOrder.Cost = newOrder.Foods.Sum(of => of.Food.Cost);

            // Добавляем в общие и сохраняем
            AllOrders.Add(newOrder);
            await WriteAsync();

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
        public Order MakeOrder(List<OrderedFood> foods, int tableID, int waiterID, PayementType payementType)
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
            }
        }

        /// <summary>
        /// Регистрирует нового сотрудника
        /// генерирует для него логин и пароль и добавляет в список Workers
        /// </summary>
        /// <param name="name">Имя нового сотрудника</param>
        /// <param name="status">Роль сотрудника</param>
        /// <param name="phone">Телефон (используется для формирования логина)</param>
        public async Task RegistrateWorkerAsync(string name, UserStatus status, string phone)
        {
            int newId = Workers.Any() ? Workers.Max(w => w.Id) + 1 : 1;
            Human worker = status switch
            {
                UserStatus.Admin => new Admin { Id = newId, Name = name, PhoneNumber = phone, Login = $"{status}_{newId}", Password = GeneratePassword() },
                UserStatus.Chef => new Chef { Id = newId, Name = name, PhoneNumber = phone, Login = $"{status}_{newId}", Password = GeneratePassword() },
                UserStatus.Waiter => new Waiter { Id = newId, Name = name, PhoneNumber = phone, Login = $"{status}_{newId}", Password = GeneratePassword() },
                UserStatus.Courier => new Courier { Id = newId, Name = name, PhoneNumber = phone, Login = $"{status}_{newId}", Password = GeneratePassword() },
                _ => throw new ArgumentException("Неверный статус")
            };
            Workers.Add(worker);
            await WriteAsync();
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
        /// Группировка списка блюд
        /// </summary>
        /// <param name="foods">Список Food, который нужно сгруппировать</param>
        /// <param name="groupedFoods">Сюда складываем результат</param>
        public void GroupFoods(List<Order> orders, List<GroupedFood> groupedFoods)
        {
            groupedFoods.Clear();
            var temp = orders
            .Where(order => order != null && order.Foods != null)
            .SelectMany(order => order.Foods) // "Разворачиваем" все блюда из всех заказов
            .Where(food => food != null && food.Food != null)
            .GroupBy(food => food.Food.Name)       // Группируем по названию блюда ключ - строка
            .Select(g => {
                var name = g.Key;
                // найти в справочном списке блюд:
                var dish = Dishes.FirstOrDefault(d => d.Name == name);

                // Категория по умолчанию "Другое"
                string category = "Другое";

                if (dish != null)
                {
                    category = dish.Priority switch
                    {
                        FoodCategory.Aperitif => "Аперитив",
                        FoodCategory.Entree => "Антре",
                        FoodCategory.MainCourse => "Основное блюдо",
                        FoodCategory.Entremets => "Антреме",
                        FoodCategory.Desserts => "Десерт",
                        FoodCategory.Digestif => "Дижестив",
                        _ => "Другое"
                    };
                }
                return new GroupedFood
                {
                    Name = name,
                    Category = category,
                    Count = g.Count()
                };
            }).ToList();
            groupedFoods.AddRange(temp);
        }

        /// <summary>
        /// Сортировка списка блюд по названиям
        /// </summary>
        /// <param name="groupedFoods">Отсортированый список</param>
        public void SortByFoodName(List<GroupedFood> groupedFoods)
        {
            if (groupedFoods == null) 
                return;

            groupedFoods.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));
        }

        /// <summary>
        /// Сортировка списка блюд по названиям категорий
        /// </summary>
        /// <param name="groupedFoods">Отсортированый список</param>
        public void SortByFoodType(List<GroupedFood> groupedFoods)
        {
            if (groupedFoods == null)
                return;

            groupedFoods.Sort((a, b) => string.Compare(a.Category, b.Category, StringComparison.CurrentCulture));
        }

        /// <summary>
        /// Сортировка списка блюд по ID
        /// </summary>
        /// <param name="groupedFoods">Отсортированый список</param>
        public void SortByFoodCount(List<GroupedFood> groupedFoods)
        {
            if (groupedFoods == null) 
                return;

            // По убыванию, чтобы самые популярные шли первыми
            groupedFoods.Sort((a, b) => b.Count.CompareTo(a.Count));
        }
        
        /// <summary>
        /// Группировка списка клиентов
        /// </summary>
        /// <param name="clients">Группируемый список</param>
        /// <param name="grouped">Сгруппированый список</param>
        public void GroupClients(List<Client> clients, List<GroupedClient> groupedClients)
        {
            groupedClients.Clear();
            var temp = clients
                .Select(client => new GroupedClient()
                {
                    Id = client.Id,
                    Name = client.Name,
                    Orders = client.Orders,
                    Spent = AllOrders
                        .Where(order => client.Orders.Contains(order.Id))
                        .Sum(order => order.Cost)
                }).ToList();
            groupedClients.AddRange(temp);
        }

        /// <summary>
        /// Сортировка списка клиентов по ID
        /// </summary>
        /// <param name="groupedClients">Отсортированый список</param>
        public void SortByClientID(List<GroupedClient> groupedClients)
        {
            if (groupedClients == null) 
                return;

            groupedClients.Sort((a, b) => a.Id.CompareTo(b.Id));
        }

        /// <summary>
        /// Сортировка списка клиентов по именам
        /// </summary>
        /// <param name="groupedClients">Отсортированый список</param>
        public void SortByClientName(List<GroupedClient> groupedClients)
        {
            if (groupedClients == null) 
                return;

            groupedClients.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));
        }

        /// <summary>
        /// Сортировка списка клиентов по кол-ву заказов
        /// </summary>
        /// <param name="groupedClients">Отсортированый список</param>
        public void SortByClientOrders(List<GroupedClient> groupedClients)
        {
            if (groupedClients == null) 
                return;

            groupedClients.Sort((a, b) => b.Orders.Count.CompareTo(a.Orders.Count));
        }
        /// <summary>
        /// Сортировка списка клиентов по потраченым средствам
        /// </summary>
        /// <param name="groupedClients">Отсортированый список</param>
        public void SortByClientSpent(List<GroupedClient> groupedClients)
        {
            if (groupedClients == null) 
                return;

            groupedClients.Sort((a, b) => b.Spent.CompareTo(a.Spent));
        }

        /// <summary>
        /// Возвращает заказы за указанный период (включительно)
        /// </summary>
        public List<Order> GetOrdersByDateRange(DateTime from, DateTime to)
        {
            return AllOrders
                .Where(o => o.Date.Date >= from.Date && o.Date.Date <= to.Date)
                .ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="food"></param>
        public void CookFood(OrderedFood food) 
        {
            food.IsReady = true;
        }
    }
}
