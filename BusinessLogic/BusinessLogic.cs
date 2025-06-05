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
        public static List<Human> Users = new List<Human>() // пока для наглядности
        {
            new Waiter { Name = "Анна", Login = "anna", Password = "1234" },
            new Chef { Name = "Борис", Login = "boris", Password = "chefpass" },
            new Admin { Name = "Админ", Login = "admin", Password = "adminpass" },
            new Courier { Name = "Пётр", Login = "petya", Password = "cour123" }
        };

        public List<IWorker> Workers { get; set; } = new List<IWorker>();
        public List<Client> Clients { get; set; } = new List<Client> { };


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

        public void FixateUser(Human user)//хз зачем это
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
    }
}
