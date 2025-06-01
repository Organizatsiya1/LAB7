using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class DeliveredOrder : Order
    {
        public int CourierId { get; set; }
        public Adress DeliveryAdress { get; set; }
    }
}
