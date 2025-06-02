using BusinessLogic;

namespace Model
{
    public class Human:IDomainObject
    {
        public int Id { get; set; }
        private string Name { get; set; }
        public long PhoneNumber { get; set; }
        public List<int> Orders { get; set; }
        public Permissions Permissions { get; set; }
    }
}
