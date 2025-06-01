namespace BusinessLogic
{
    public class BusinessLogic
    {
        public int GenerateNumber() 
        {
            Random random = new Random();
            
            return random.Next(1000, 9999);
        }

    }
}
