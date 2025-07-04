using Logic;

namespace Model
{
    public class Client:Human
    {
        public Adress Adress { get; set; }
        public Permissions Permissions = Permissions.BookTable|Permissions.MakeOrder;
        public Client()
        {
            Adress = new Adress();
            Orders = new List<int>();
        }
    }
}
