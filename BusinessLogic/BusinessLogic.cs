using Model;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Logic
{
    public class BusinessLogic
    {
        Human FixedUser { get; set; }
        UserStatus Status { get; set; }
        int OrdersID = 1;
        int WorkersID = 1;

        public List<Client> Clients { get; set; } = new List<Client> { };
        // Все доступные блюда (меню)
        public static List<Food> Foods { get; private set; } = new List<Food>();

        public static List<Human> Workers = new List<Human>() // пока для наглядности
        {
            new Waiter { Name = "Анна", Login = "anna", Password = "1234" },
            new Chef { Name = "Борис", Login = "boris", Password = "chefpass" },
            new Admin { Name = "Админ", Login = "admin", Password = "adminpass" },
            new Courier { Name = "Пётр", Login = "petya", Password = "cour123" }
        };

        #region Menu

        /// <summary>
        /// Вызвать сразу при инициализации (например, после логина) для загрузки меню
        /// Здесь приведён упрощённый пример: в реальности данные придут из файла/БД (DataConverter)
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
                    Priority = FoodCategory.Snacks,
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
                    Priority = FoodCategory.Soups,
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
                    Priority = FoodCategory.SecondCourses,
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
                    Priority = FoodCategory.Drinks,
                    Formula = new List<string> { "Вода", "Сахар", "Газ" }
                }
            };
        }

        #endregion

        public List<Food> GetFoodsByFilter(string nameContains)
        {
            if (string.IsNullOrWhiteSpace(nameContains))
                return Foods.ToList();
            nameContains = nameContains.Trim().ToLower();
            return Foods
                .Where(f => f.Name.ToLower().Contains(nameContains))
                .ToList();
        }

        

        public Order GetCurrentOrderForClient(Client client)
        {
            if (client == null || client.Orders == null || client.Orders.Count == 0)
                return null;

            foreach (var oid in client.Orders.AsEnumerable().Reverse())
            {
                // ??? В ТЗ здесь нужно хранить все заказы в каком-то общем списке.
                // пока чисто для демонстрации, если AllOrders отсутствует, оставим заглушку:
            }
            return null;
        }


        public string GenerateNumber()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }

        public Order MakeOrder(List<Food> foods, int tableID, int waiterID, PayementType payementType)//вроде с этим ок
        {
            if (FixedUser.Permissions.HasFlag(Permissions.MakeOrder))
            {
                Order Made = new Order() { PayementType = payementType, Behavior = OrderBehavior.IsCoocking, Foods = foods, Id = OrdersID, TableID = tableID, WaiterID = waiterID, IsDelivered = false, IsPayed = false };
                OrdersID += 1;
                return Made;
            }
            else
            {
                return null;
            }
        }

        public void FixateUser(Human user)
        {
            if (user is Admin)
            {
                FixedUser = user;
                Status = UserStatus.Admin;
            }
            if (user is Client)
            {
                FixedUser = user;
                Status = UserStatus.Client;
            }
            if (user is Waiter)
            {
                FixedUser = user;
                Status = UserStatus.Waiter;
            }
            if (user is Chef)
            {
                FixedUser = user;
                Status = UserStatus.Chef;
            }
            if (user is Courier)
            {
                FixedUser = user;
                Status = UserStatus.Courier;
            }
        }

        public void MarkPayed(Order order)
        {
            if (FixedUser.Permissions.HasFlag(Permissions.MarkPayed))
            {
                order.IsPayed = true;
            }
        }

        public void RegistrateWorker(string name, UserStatus status, string phone)
        {
            if (status == UserStatus.Admin)
            {
                Workers.Add(new Admin() { Id = WorkersID, Login = name+phone, Password = GeneratePassword(), Name = name });

            }
            if(status == UserStatus.Chef)
            {
                Workers.Add(new Chef() { Name = name, Password = GeneratePassword(), Login = name+phone, Id = WorkersID });
            }
            if (status == UserStatus.Waiter)
            {
                Workers.Add(new Waiter() { Id = WorkersID, Password = GeneratePassword(), Name = name, Login = name + phone });
            }
            if (status == UserStatus.Courier)
            {
                Workers.Add(new Courier() { Id = WorkersID, Name = name, Login = name + phone, Password = GeneratePassword() });
            }
            
        }
        public string GeneratePassword()
        {
            string letters = "qwertyuioplkjhgfdsazxcvbnm";
            string bigletters = "QWERTYUIOPLKJHGFDSAZXCVBNM";
            string numbers = "1234567890";
            string symbols = "!@#$%^&*?";
            Random r = new Random();
            string all = letters + bigletters + numbers+symbols;
            char[] password = new char[10];
            password[0] = letters[r.Next(letters.Length)];
            password[1] = bigletters[r.Next(bigletters.Length)];
            password[2] = numbers[r.Next(numbers.Length)];
            password[3] = symbols[r.Next(symbols.Length)];
            for (int i = 4; i < 10; i++)
            {
                password[i] = all[r.Next(all.Length)];
            }
            return new string(password.OrderBy(x => r.Next()).ToArray());
        }
        public void GroupFoods(List<Food> foods, List<GroupedFood> groupedFoods) 
        {
           
        }
    }
}
