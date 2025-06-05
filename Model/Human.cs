using BusinessLogic;

namespace Model
{
    public class Human:IDomainObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }
        public Permissions Permissions { get; set; }
    }
}
