using Model;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Drawing;

namespace Logic
{
    public class DataConverter
    {
        private const string ClientsFileName = "DataClients.json";
        private const string DishesFileName = "DataDishes.json";
        private const string OrdersFileName = "DataOrders.json";
        private const string WorkersFileName = "DataWorkers.json";
        public static string DataBase { get; }

        /// <summary>
        /// 
        /// </summary>
        static DataConverter()
        {
            //Базовая папка для всех файлов приложения
            // %AppData%\Organization Sigma Cat\ULTIMATE SEVEN LAB
            DataBase = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Organization Sigma Cat",
                "ULTIMATE SEVEN LAB",
                "DataBase"); Directory.CreateDirectory(DataBase);

            Directory.CreateDirectory(Path.Combine(DataBase, "Images"));

            string dishesPath = Path.Combine(DataBase, DishesFileName);
            
        }

        /// <summary>
        /// Асинхронно записывает упорядоченный по идентификаторам список клиентов в JSON-файл
        /// </summary>
        /// <param name="clients">Список клиентов, который нужно сохранить</param>
        /// <returns>Задача, представляющая асинхронную операцию записи</returns>
        public async Task WriteClientsAsync(List<Client> clients)
        {

            string fullPath = Path.Combine(DataBase, ClientsFileName);

            // Обрабатываем ситуацию, если каталог вдруг исчез:
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            // Сортируем по Id, чтобы файл был человекочитаем и клиенты упорядочены
            var toWrite = clients.OrderBy(c => c.Id).ToList();

            // Опции форматированного (отступы) JSON
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };


            // Открываем поток с асинхронной записью
            using var stream = new FileStream(
                fullPath,
                FileMode.Create,    // создаёт или перезаписывает файл
                FileAccess.Write,
                FileShare.None,
                bufferSize: 4096,
                useAsync: true);

            // Сериализуем сразу в поток
            await JsonSerializer.SerializeAsync(stream, toWrite, options);
        }

        /// <summary>
        /// Асинхронно читает из JSON-файла список КЛИЕНТОВ
        /// </summary>
        /// <returns>Задача, результатом которой является список клиентов (или пустой список если файл не найден)</returns>
        public async Task<List<Client>> ReadClientsAsync()
        {
            string fullPath = Path.Combine(DataBase, ClientsFileName);

            // Если файла нет — возвращаем пустой список
            if (!File.Exists(fullPath))
                return new List<Client>();

            using var stream = new FileStream(
                fullPath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read,
                bufferSize: 4096,
                useAsync: true);

            // Десериализуем
            var clients = await JsonSerializer.DeserializeAsync<List<Client>>(stream);

            // Если файл был пустой или испорченный — защитимся от null
            return clients ?? new List<Client>();
        }

        /// <summary>
        /// Асинхронно читает из JSON-файла данные о БЛЮДЕ
        /// </summary>
        /// <returns>Задача, результатом которой является список клиентов (или пустой список если файл не найден)</returns>
        public async Task<List<Food>> ReadDishesAsync()
        {
            string fullPath = Path.Combine(DataBase, DishesFileName);

            // Если файла нет — возвращаем пустой список
            if (!File.Exists(fullPath))
                return new List<Food>();

            using var stream = new FileStream(
                fullPath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read,
                bufferSize: 4096,
                useAsync: true);

            // Десериализуем
            var dishes = await JsonSerializer.DeserializeAsync<List<Food>>(stream);

            // Если файл был пустой или испорченный — защитимся от null
            return dishes ?? new List<Food>();
        }

        public static Image LoadFoodImage(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
                return null;

            string imagesDir = Path.Combine(DataBase, "Images");
            string fullPath = Path.Combine(imagesDir, imageName);

            if (!File.Exists(fullPath))
                return null; // Вернем null, обработка будет в UI

            try
            {
                // Загрузка без блокировки файла
                using var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                return Image.FromStream(stream);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Асинхронно читает список заказов из JSON
        /// </summary>
        public async Task<List<Order>> ReadOrdersAsync()
        {
            string fullPath = Path.Combine(DataBase, OrdersFileName);
            if (!File.Exists(fullPath)) return new List<Order>();

            using var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, useAsync: true);
            using var doc = await JsonDocument.ParseAsync(stream);

            var list = new List<Order>();
            foreach (var elem in doc.RootElement.EnumerateArray())
            {
                string rawJson;
                string typeName;

                // если есть обёртка — читаем её
                if (elem.TryGetProperty("OrderType", out var tProp) &&
                    elem.TryGetProperty("Data", out var dProp))
                {
                    typeName = tProp.GetString()!;
                    rawJson = dProp.GetRawText();
                }
                else
                {
                    // иначе весь элемент — это сам Order/DeliveredOrder
                    typeName = nameof(Order);
                    rawJson = elem.GetRawText();
                }

                Order? order = typeName switch
                {
                    nameof(DeliveredOrder) => JsonSerializer.Deserialize<DeliveredOrder>(rawJson),
                    nameof(Order) => JsonSerializer.Deserialize<Order>(rawJson),
                    _ => null
                };

                if (order != null)
                    list.Add(order);
            }

            return list;
        }

        /// <summary>
        /// Асинхронно записывает список заказов в JSON
        /// </summary>
        public async Task WriteOrdersAsync(List<Order> orders)
        {
            string fullPath = Path.Combine(DataBase, OrdersFileName);
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);

            var options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) };

            var wrapper = orders
                .Select(o => new {
                    OrderType = o.GetType().Name,
                    Data = o
                })
                .ToList();

            using var stream = new FileStream(fullPath, FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true);
            await JsonSerializer.SerializeAsync(stream, wrapper, options);
        }

        /// <summary>
        /// Асинхронно читает из JSON-файла список сотрудников
        /// </summary>
        public async Task<List<Human>> ReadWorkersAsync()
        {
            var fullPath = Path.Combine(DataBase, WorkersFileName);
            if (!File.Exists(fullPath))
                return new List<Human>();

            using var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            using var doc = await JsonDocument.ParseAsync(stream);

            var list = new List<Human>();
            foreach (var elem in doc.RootElement.EnumerateArray())
            {
                string userType = elem.GetProperty("UserType").GetString()!;
                var dataJson = elem.GetProperty("Data").GetRawText();
                Human? obj = userType switch
                {
                    nameof(Admin) => JsonSerializer.Deserialize<Admin>(dataJson),
                    nameof(Chef) => JsonSerializer.Deserialize<Chef>(dataJson),
                    nameof(Waiter) => JsonSerializer.Deserialize<Waiter>(dataJson),
                    nameof(Courier) => JsonSerializer.Deserialize<Courier>(dataJson),
                    _ => JsonSerializer.Deserialize<Human>(dataJson)
                };
                if (obj != null) list.Add(obj);
            }
            return list;
        }

        /// <summary>
        /// Асинхронно записывает в JSON-файл список сотрудников
        /// </summary>
        public async Task WriteWorkersAsync(List<Human> workers)
        {
            var fullPath = Path.Combine(DataBase, WorkersFileName);
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };

            var toWrite = workers.Select(w => new {
                UserType = w.GetType().Name,
                Data = JsonSerializer.SerializeToElement(w, w.GetType(), options)
            }).ToList();

            using var stream = new FileStream(fullPath, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true);
            await JsonSerializer.SerializeAsync(stream, toWrite, options);

        }
    }
}
