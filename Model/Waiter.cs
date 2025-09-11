using Logic;

namespace Model
{
    public class Waiter:Human,IWorker
    {
        public string Password { get; set; }
        public string Login { get; set; }
        public int Efficiency { get; set; }
        public Permissions Permissions = Permissions.MarkDelivered|Permissions.MarkPayed;
    }
}
