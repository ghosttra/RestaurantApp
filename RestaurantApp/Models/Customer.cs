namespace RestaurantApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public double Balance { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
