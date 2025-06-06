using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Logic
{
    public class DataConverter
    {
        /// <summary>
        /// Асинхронно должен записывать данные о БЛЮДАХ в файл с применением фильтрации и группировки
        /// </summary>
        /// <param name="foods">Список блюд для записи</param>
        /// <param name="filename">Путь к файлу для сохранения</param>
        async void WriteFood(List<Food> foods, string filename)
        {
            FileInfo fileinfo = new FileInfo(filename);
            FileStream stream = fileinfo.Create();
            //тут применяются методы на фильтрацию, и группировку блюд из условия
            stream.Write(Encoding.UTF8.GetBytes($"\n"));
            
        }

        /// <summary>
        /// Асинхронно должен записывать данные о ЗАКАЗАХ в файл с применением фильтрации и группировки
        /// </summary>
        /// <param name="orders">Список заказов для записи</param>
        /// <param name="filename">Путь к файлу для сохранения</param>
        async void WriteOrders(List<Order> orders, string filename)
        {
            FileInfo fileinfo = new FileInfo(filename);
            FileStream stream = fileinfo.Create();
            //тут применяются методы на фильтрацию, и группировку заказов из условия
            stream.Write(Encoding.UTF8.GetBytes($"\n"));
            
        }

        /// <summary>
        /// Асинхронно должен записывать данные о КЛИЕНТАХ и их заказах в файл
        /// </summary>
        /// <param name="clients">Список клиентов для записи</param>
        /// <param name="filename">Путь к файлу для сохранения</param>
        async void WriteClients(List<Client> clients, string filename)
        {
            FileInfo fileinfo = new FileInfo(filename);
            FileStream stream = fileinfo.Create();
            //тут применяются методы на фильтрацию, и группировку клиент-заказы
            stream.Write(Encoding.UTF8.GetBytes($"\n"));

        }
    }
}
