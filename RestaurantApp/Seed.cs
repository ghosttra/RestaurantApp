using RestaurantApp.Data;
using RestaurantApp.Models;
using System.Diagnostics.Metrics;

namespace RestaurantApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (dataContext != null)
            {
                if (!dataContext.Customers.Any())
                {
                    var Customers = new List<Customer>()
                        {
                            new Customer()
                                {
                                   Name="Kira",
                                   Email="gladowl.artist@gmail.com",
                                   Password="12345",
                                   Phone="0959025306",
                                   Balance = 1520.2f,
                                },
                            new Customer()
                                {
                                   Name="Masya",
                                   Email="skoromny.m@gmail.com",
                                   Password="20052005",
                                   Phone="0966999845",
                                   Balance = 51552.62f,
                                },
                            new Customer()
                                {
                                   Name="Oleg",
                                   Email="skoromny.o@gmail.com",
                                   Password="olegthebest",
                                   Phone="0965188826",
                                   Balance = 250.55f,
                                }
                        };
                    dataContext.Customers.AddRange(Customers);
                }
                if (!dataContext.Dishes.Any())
                {
                    var Dishes = new List<Dish>()
                        {
                            new Dish()
                            {
                                Name = "Pizza",
                                Description = "A beloved dish enjoyed for its delicious combination of flavors and aromas. The smell of baking pizza is mouthwatering.",
                                Price = 10,
                                CookingTime = new TimeSpan(0,25,0)
                            },
                            new Dish()
                            {
                                Name = "Pasta",
                                Description = "A classic Italian dish featuring al dente noodles topped with savory sauce and grated cheese.",
                                Price = 12,
                                CookingTime = new TimeSpan(0, 20, 0)
                            },
                            new Dish()
                            {
                                Name = "Burger",
                                Description = "An American favorite, comprising a juicy grilled patty sandwiched between soft buns, layered with fresh vegetables and condiments.",
                                Price = 8,
                                CookingTime = new TimeSpan(0, 15, 0)
                            },
                            new Dish()
                            {
                                Name = "Sushi",
                                Description = "A Japanese delicacy consisting of vinegared rice combined with various ingredients like raw fish, vegetables, and seaweed, skillfully rolled into bite-sized pieces.",
                                Price = 15,
                                CookingTime = new TimeSpan(0, 30, 0)
                            },
                            new Dish()
                            {
                                Name = "Salad",
                                Description = "A refreshing dish made with a variety of fresh vegetables, tossed together with a flavorful dressing.",
                                Price = 8,
                                CookingTime = new TimeSpan(0, 10, 0)
                            }
                        };
                    dataContext.Dishes.AddRange(Dishes);
                }
                dataContext.SaveChanges();
            }
        }
    }
}
