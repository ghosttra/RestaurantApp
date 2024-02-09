namespace RestaurantApp.Models
{
    public class Rating
    {
        public short Stars { get; set; }
        public string Feedback { get; set; }
        public Customer Reviewer { get; set; }
    }
}
