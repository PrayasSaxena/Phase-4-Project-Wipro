using Microsoft.EntityFrameworkCore;
using PizzaHub.Models;

namespace PizzaHub.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category veg = new Category { Name = "Veg", Slug = "veg" };
                Category non_veg = new Category { Name = "Non_Veg", Slug = "non_veg" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Margherita",
                            Slug = "margherita",
                            Description = "Tasty Cheese Loaded",
                            Price = 199,
                            Category = veg,
                            Image = "Margherita.jpg"
                        },
                        new Product
                        {
                            Name = "Farmhouse",
                            Slug = "farmhouse",
                            Description = "Loaded with Vegetables",
                            Price = 300,
                            Category = veg,
                            Image = "Farmhouse.jpg"
                        },
                        new Product
                        {
                            Name = "Peppy Paneer",
                            Slug = "peppy-paneer",
                            Description = "Paneer Loaded",
                            Price = 250,
                            Category = veg,
                            Image = "Peppy_Paneer.jpg"
                        },
                        new Product
                        {
                            Name = "Veg Extravaganza",
                            Slug = "veg-extravaganza",
                            Description = "Extra Vegetables",
                            Price = 250,
                            Category = veg,
                            Image = "Veg_Extravaganza.jpg"
                        },
                        new Product
                        {
                            Name = "Chicken Dominator",
                            Slug = "chicken-dominator",
                            Description = "Chicken Dominator",
                            Price = 300,
                            Category = non_veg,
                            Image = "Chicken Dominator.jpg"
                        },
                        new Product
                        {
                            Name = "Chicken Sausage",
                            Slug = "chicken-sausage",
                            Description = "Chicken Sausage",
                            Price = 350,
                            Category = non_veg,
                            Image = "Chicken Sausage.jpg"
                        },
                        new Product
                        {
                            Name = "Chicken Fiesta",
                            Slug = "chicken-fiesta",
                            Description = "Chicken Fiesta",
                            Price = 350,
                            Category = non_veg,
                            Image = "Chicken Fiesta.jpg"
                        },
                        new Product
                        {
                            Name = "Chicken Delight",
                            Slug = "chicken-delight",
                            Description = "Chicken Delight",
                            Price = 300,
                            Category = non_veg,
                            Image = "Chicken Delight.jpg"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}