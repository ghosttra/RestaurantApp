namespace RestaurantApp.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<DishCategory> DishCategories { get; set; }
        public Order Order { get; set; }
        public double Price { get; set; }
        public TimeSpan CookingTime { get; set; }
    }
}
