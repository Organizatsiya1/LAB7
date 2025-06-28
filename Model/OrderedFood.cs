using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderedFood:IDomainObject
    {
        public int Id { get; set; }
        public Food Food { get; set; }
        public bool IsReady {  get; set; }
    }
}
