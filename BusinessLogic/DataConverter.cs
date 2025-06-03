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
        async void WriteFood(List<Food> foods, string filename)
        {
            FileInfo fileinfo = new FileInfo(filename);
            FileStream stream = fileinfo.Create();
            //тут применяются методы на фильтрацию, и группировку блюд из условия
            stream.Write(Encoding.UTF8.GetBytes($"\n"));
            
        }
        async void WriteOrders(List<Order> orders, string filename)
        {
            FileInfo fileinfo = new FileInfo(filename);
            FileStream stream = fileinfo.Create();
            //тут применяются методы на фильтрацию, и группировку заказов из условия
            stream.Write(Encoding.UTF8.GetBytes($"\n"));
            
        }
        async void WriteClients(List<Client> clients, string filename)
        {
            FileInfo fileinfo = new FileInfo(filename);
            FileStream stream = fileinfo.Create();
            //тут применяются методы на фильтрацию, и группировку клиент-заказы
            stream.Write(Encoding.UTF8.GetBytes($"\n"));

        }
    }
}
