namespace RestaurantApp.Models
{
    public class DeliveryMan
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Rating Rating { get; set; }
        public int SuccessfulDeliveries { get; set; }

    }
}
