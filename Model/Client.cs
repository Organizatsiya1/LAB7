using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client:Human
    {
        public Adress Adress { get; set; }
        public Permissions Permissions = Permissions.BookTable|Permissions.MakeOrder;
        public Client()
        {
            Adress = new Adress();
            Orders = new List<Order>();
        }
    }
}
