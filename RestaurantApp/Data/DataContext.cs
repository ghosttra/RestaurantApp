using Microsoft.EntityFrameworkCore;
using RestaurantApp.Models;

namespace RestaurantApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeliveryMan> DeliveryMen { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DishCategory> DishCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishCategory>()
                 .HasKey(dc => new { dc.DishId, dc.CategoryId });
            modelBuilder.Entity<DishCategory>()
                .HasOne(d => d.Dish)
                .WithMany(dc => dc.DishCategories)
                .HasForeignKey(c => c.DishId);
            modelBuilder.Entity<DishCategory>()
                .HasOne(d => d.Category)
                .WithMany(dc => dc.DishCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Feedback>()
                 .HasKey(fb => new { fb.Id, fb.CustomerId, fb.DeliveryManId });
            modelBuilder.Entity<Feedback>()
                .HasOne(fb => fb.Customer)
                .WithMany(dc => dc.Feedbacks)
                .HasForeignKey(c => c.CustomerId);
            modelBuilder.Entity<Feedback>()
                .HasOne(d => d.DeliveryMan)
                .WithMany(dc => dc.Feedbacks)
                .HasForeignKey(c => c.DeliveryManId);
        }
    }
}
