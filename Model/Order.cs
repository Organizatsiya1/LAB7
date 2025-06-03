using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order:IDomainObject
    {
        public int Id { get; set; }
        public bool IsDelivered { get; set; }
        public List<Food> Foods { get; set; }
        public  int TableID {  get; set; } //sealed не применяется!?//
        public int WaiterID { get; set; }
        public bool IsPayed { get; set; }
        public OrderBehavior Behavior { get; set; }
        public PayementType PayementType { get; set; }
    }
}
