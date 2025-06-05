using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Food:IDomainObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Weight {  get; set; }
        public int CoockingTime {  get; set; }
        public int Cost {  get; set; }
        public FoodCategory Priority { get; set; }
        public List<string> Formula { get; set; }
    }
}
