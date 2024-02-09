﻿namespace RestaurantApp.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Rating Rating { get; set; }
        public double Price { get; set; }
        public TimeSpan CookingTime { get; set; }
    }
}
