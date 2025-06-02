using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Admin : Human, IWorker
    {
        public string Password { get; set; }
        public string Login { get; set; }
        public int Efficiency { get; set; }
        public Permissions Permissions = Permissions.Register | Permissions.ShowInfo;
    }
}
