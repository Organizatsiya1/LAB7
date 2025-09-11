using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adress:IDomainObject
    {
        public int Id {  get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Street { get; set; }
        public int HouseNumb { get; set; }
        public int FlatNumb { get; set; }
    }
}
