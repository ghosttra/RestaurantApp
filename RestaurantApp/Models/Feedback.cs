namespace RestaurantApp.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public short Stars { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public int DeliveryManId { get; set; }
        public Customer Customer { get; set; }
        public DeliveryMan DeliveryMan { get; set; }
    }
}
