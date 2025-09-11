namespace Model
{
    public class DeliveredOrder : Order
    {
        public int CourierId { get; set; }
        public Adress DeliveryAdress { get; set; }
    }
}
