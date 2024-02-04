namespace RestaurantApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Dish> dishes { get; set; }
        public double FinalCheck
        {
            get
            {
                double finalCheck = 0;
                foreach (Dish dish in dishes)
                {
                    finalCheck += dish.Price;
                }
                return finalCheck;
            }
        }
        public DateTime OrderDateTime { get; set; }
        public TimeSpan DeliveryTime { get; set; }
    }
}
