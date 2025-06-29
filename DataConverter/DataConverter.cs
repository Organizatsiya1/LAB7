using Model;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Logic
{
    public class DataConverter
    {
        private const string DishesFileName = "DataDishes.json";
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
            if (!File.Exists(dishesPath))
            {
                var defaultDishes = new List<Food>
                {
                    new Food {
                        Id = 1,
                        Name = "Брускетта с помидорами",
                        Description = "Классическая итальянская закуска",
                        Weight = 120,
                        CoockingTime = 5,
                        Cost = 150,
                        Priority = FoodCategory.Entree,
                        Formula = new List<string> { "Хлеб", "Томаты", "Оливковое масло", "Базилик" },
                        PhotoFile = "bruschetta.jpg"
                    },
                    // … ваш оставшийся набор блюд …
                };

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
                };
                using var fs = new FileStream(dishesPath, FileMode.CreateNew, FileAccess.Write, FileShare.None);
                JsonSerializer.Serialize(fs, defaultDishes, options);
            }
        }


        /// <summary>
        /// Асинхронно записывает упорядоченный по идентификаторам список клиентов в JSON-файл
        /// </summary>
        /// <param name="clients">Список клиентов, который нужно сохранить</param>
        /// <param name="filename">Путь к JSON-файлу для записи (создается или перезаписывается) </param>
        /// <returns>Задача, представляющая асинхронную операцию записи</returns>
        public async Task WriteClientsAsync(List<Client> clients, string filename)
        {

            string fullPath = Path.Combine(DataBase, filename);

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
        /// <param name="filename">Путь к JSON-файлу для чтения</param>
        /// <returns>Задача, результатом которой является список клиентов (или пустой список если файл не найден)</returns>
        public async Task<List<Client>> ReadClientsAsync(string filename)
        {
            string fullPath = Path.Combine(DataBase, filename);

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
        /// <param name="filename">Путь к JSON-файлу для чтения</param>
        /// <returns>Задача, результатом которой является список клиентов (или пустой список если файл не найден)</returns>
        public async Task<List<Food>> ReadDishesAsync(string filename)
        {
            string fullPath = Path.Combine(DataBase, filename);

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

        ///// <summary>
        ///// Асинхронно должен записывать данные о БЛЮДАХ в файл с применением фильтрации и группировки
        ///// </summary>
        ///// <param name="foods">Список блюд для записи</param>
        ///// <param name="filename">Путь к файлу для сохранения</param>
        //async void WriteFood(List<Food> foods, string filename)
        //{
        //    FileInfo fileinfo = new FileInfo(filename);
        //    FileStream stream = fileinfo.Create();
        //    //тут применяются методы на фильтрацию, и группировку блюд из условия
        //    stream.Write(Encoding.UTF8.GetBytes($"\n"));

        //}

        ///// <summary>
        ///// Асинхронно должен записывать данные о ЗАКАЗАХ в файл с применением фильтрации и группировки
        ///// </summary>
        ///// <param name="orders">Список заказов для записи</param>
        ///// <param name="filename">Путь к файлу для сохранения</param>
        //async void WriteOrders(List<Order> orders, string filename)
        //{
        //    FileInfo fileinfo = new FileInfo(filename);
        //    FileStream stream = fileinfo.Create();
        //    //тут применяются методы на фильтрацию, и группировку заказов из условия
        //    stream.Write(Encoding.UTF8.GetBytes($"\n"));

        //}
    }
}
