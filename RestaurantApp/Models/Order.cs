namespace RestaurantApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<Dish> Dishes { get; set; }
        public Destination Destination { get; set; }
        public Customer Customer { get; set; }
        public bool IsCash { get; set; }
        public double FinalCheck { get; set; }
        public DateTime OrderDateTime { get; set; }
        public TimeSpan DeliveryTime { get; set; }
    }
}
