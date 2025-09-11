using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Courier: Waiter
    {
        public TransportType TransportType { get; set; }
        public Permissions Permissions = Permissions.MarkGiven|Permissions.MarkDelivered|Permissions.MarkPayed;
    }
}
