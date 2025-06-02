using Model;
namespace BusinessLogic
{
    public class BusinessLogic
    {
        int OrdersID = 1;
        public string GenerateNumber() 
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }
        public Order MakeOrder(List<Food> foods, int tableID, int waiterID, PayementType payementType) 
        {
            Order Made = new Order() { PayementType = payementType, Behavior = OrderBehavior.IsCoocking, Foods = foods, Id = OrdersID, TableID = tableID, WaiterID = waiterID, IsDelivered = false, IsPayed = false};
            OrdersID += 1;
            return Made;
            
        }
        public void UpdateOrderStatus(Order order, OrderBehavior newbehavior) 
        {
            order.Behavior = newbehavior;
        } 

    }
}
