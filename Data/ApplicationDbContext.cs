using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Providers.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using myPantry.Models;

namespace myPantry.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<myPantry.Models.Images> Images { get; set; }
        public DbSet<RecipeProducts> RecipeProducts { get; set; }
        public DbSet<myPantry.Models.Products> Products { get; set; }
        public DbSet<myPantry.Models.Recipe> Recipe { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            Users user = new Users
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<Users>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<Users>().HasData(user);

            //// Create 25 Products
            modelBuilder.Entity<Products>().HasData(
                new Products()
                {
                    Id = 1,
                    Name = "Honey",
                    Quantity = 2,
                    LocationId = 1,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 8
                },
                new Products()
                {
                    Id = 2,
                    Name = "Peanut Butter",
                    Quantity = 2,
                    LocationId = 1,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 8
                },
                new Products()
                {
                    Id = 3,
                    Name = "Frozen Strawberries",
                    Quantity = 2,
                    LocationId = 3,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 2
                },
                new Products()
                {
                    Id = 4,
                    Name = "Banana",
                    Quantity = 2,
                    LocationId = 3,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 2
                },
                new Products()
                {
                    Id = 5,
                    Name = "Almond Milk",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 7
                },
                new Products()
                {
                    Id = 6,
                    Name = "Sourdough Bread",
                    Quantity = 2,
                    LocationId = 1,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 1
                },
                new Products()
                {
                    Id = 7,
                    Name = "Eggs",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 8
                },
                new Products()
                {
                    Id = 8,
                    Name = "Butter",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 7
                },
                new Products()
                {
                    Id = 9,
                    Name = "Ground Beef",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 4
                },
                new Products()
                {
                    Id = 10,
                    Name = "Cheddar Cheese",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 7
                },
                new Products()
                {
                    Id = 11,
                    Name = "Red Peppers",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 3
                },
                new Products()
                {
                    Id = 12,
                    Name = "Green Peppers",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 3
                },
                new Products()
                {
                    Id = 13,
                    Name = "Onions",
                    Quantity = 2,
                    LocationId = 1,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 3
                },
                new Products()
                {
                    Id = 14,
                    Name = "Carrots",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 3
                },
                new Products()
                {
                    Id = 15,
                    Name = "Hamburger Buns",
                    Quantity = 2,
                    LocationId = 1,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 1
                },
                new Products()
                {
                    Id = 16,
                    Name = "Lettuce",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 3
                },
                new Products()
                {
                    Id = 17,
                    Name = "Tomato",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 3
                },
                new Products()
                {
                    Id = 18,
                    Name = "Apples",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 2
                },
                new Products()
                {
                    Id = 19,
                    Name = "Tortillas",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 1
                },
                new Products()
                {
                    Id = 20,
                    Name = "Grape Jelly",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 8
                },
                new Products()
                {
                    Id = 21,
                    Name = "Fish Sticks",
                    Quantity = 2,
                    LocationId = 3,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 5
                },
                new Products()
                {
                    Id = 22,
                    Name = "Blueberries",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 2
                },
                new Products()
                {
                    Id = 23,
                    Name = "Blackberries",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 2
                },
                new Products()
                {
                    Id = 24,
                    Name = "V8",
                    Quantity = 2,
                    LocationId = 2,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 3
                },
                new Products()
                {
                    Id = 25,
                    Name = "Salmon",
                    Quantity = 2,
                    LocationId = 3,
                    ProductImage = "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg",
                    UserId = user.Id,
                    ProductTypeId = 5
                }
            );
            // Create 8 Recipes
            modelBuilder.Entity<Recipe>().HasData(
            new Recipe()
            {
                Id = 1,
                Name = "Strawberry Banana Smoothie",
                UserId = user.Id,
                Description = "A delcious smoothie with stawberries, bananas, honey, peanut butter, and almond milk.",
                RecipeUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU"
            },
            new Recipe()
            {
                Id = 2,
                Name = "Eggs and Toast",
                UserId = user.Id,
                Description = "Classic breakfast of two eggs and a piece of sourdough bread, toasted.",
                RecipeUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU"
            },
            new Recipe()
            {
                Id = 3,
                Name = "PB&J",
                UserId = user.Id,
                Description = "Peanut butter and grape jelly on sourdough bread.",
                RecipeUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU"
            },
            new Recipe()
            {
                Id = 4,
                Name = "Breakfast Burrito",
                UserId = user.Id,
                Description = "A combination of ground beef, cheddar cheese, eggs, onions and peppers rolled up in a tortilla.",
                RecipeUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU"
            },
            new Recipe()
            {
                Id = 5,
                Name = "Chili",
                UserId = user.Id,
                Description = "Ground beef, V8, onions, peppers, carrots, tomatoes, and a little cheddar cheese on top make this Fall staple",
                RecipeUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU"
            },
            new Recipe()
            {
                Id = 6,
                Name = "Fish Tacos",
                UserId = user.Id,
                Description = "6 month old frozen fish sticks with cheddar cheese on a tortilla. I guess it is edible?",
                RecipeUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU"
            },
            new Recipe()
            {
                Id = 7,
                Name = "Beef Tacos",
                UserId = user.Id,
                Description = "Beef and cheese in a steamed tortilla shell. Better than Taco Bell.",
                RecipeUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU"
            },
            new Recipe()
            {
                Id = 8,
                Name = "Cheeseburger",
                UserId = user.Id,
                Description = "Patty out some ground beef and light up the grill. Ground beef, cheddar cheese, lettuce, tomato and onion on Kroger brand hamburger buns make this burger to die for.",
                RecipeUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU"
            }
            );
            //Create the 8 Product Types
            modelBuilder.Entity<ProductType>().HasData(
            new ProductType()
            {
                Id = 1,
                Name = "Carbohydrates"
            },
            new ProductType()
            {
                Id = 2,
                Name = "Fruits" 
            },
            new ProductType()
            {
                Id = 3,
                Name = "Vegtables"
            },
            new ProductType()
            {
                Id = 4,
                Name = "Beef"
            },
            new ProductType()
            {
                Id = 5,
                Name = "Fish"
            },
            new ProductType()
            {
                Id = 6,
                Name = "Poultry"
            },
            new ProductType()
            {
                Id = 7,
                Name = "Dairy/Alternatives"
            },
            new ProductType()
            {
                Id = 8,
                Name = "Other"
            }
            );
            // Create 4 Locations
            modelBuilder.Entity<Location>().HasData(
            new Location()
            {
                Id = 1,
                LocationName = "Pantry"
            },
            new Location()
            {
                Id = 2,
                LocationName = "Fridge"
            },
            new Location()
            {
                Id = 3,
                LocationName = "Freezer"
            },
            new Location()
            {
                Id = 4,
                LocationName = "Shopping List"
            }
            );
            modelBuilder.Entity<RecipeProducts>().HasData(
            new RecipeProducts()
            {
                Id = 1,
                ProductId = 1,
                RecipeId = 1
            },
            new RecipeProducts()
            {
                Id = 2,
                ProductId = 2,
                RecipeId = 1
            },
            new RecipeProducts()
            {
                Id = 3,
                ProductId = 3,
                RecipeId = 1
            },
            new RecipeProducts()
            {
                Id = 4,
                ProductId = 4,
                RecipeId = 1
            },
            new RecipeProducts()
            {
                Id = 5,
                ProductId = 5,
                RecipeId = 1
            },
            new RecipeProducts()
            {
                Id = 6,
                ProductId = 1,
                RecipeId = 1
            },
            new RecipeProducts()
            {
                Id = 7,
                ProductId = 6,
                RecipeId = 2
            },
            new RecipeProducts()
            {
                Id = 8,
                ProductId = 7,
                RecipeId = 2
            },
            new RecipeProducts()
            {
                Id = 9,
                ProductId = 8,
                RecipeId = 2
            },
            new RecipeProducts()
            {
                Id = 10,
                ProductId = 6,
                RecipeId = 3
            },
            new RecipeProducts()
            {
                Id = 11,
                ProductId = 2,
                RecipeId = 3
            },
            new RecipeProducts()
            {
                Id = 12,
                ProductId = 20,
                RecipeId = 3
            },
            new RecipeProducts()
            {
                Id = 13,
                ProductId = 9,
                RecipeId = 4
            },
            new RecipeProducts()
            {
                Id = 14,
                ProductId = 10,
                RecipeId = 4
            },
            new RecipeProducts()
            {
                Id = 15,
                ProductId = 7,
                RecipeId = 4
            },
            new RecipeProducts()
            {
                Id = 16,
                ProductId = 13,
                RecipeId = 4
            },
            new RecipeProducts()
            {
                Id = 17,
                ProductId = 11,
                RecipeId = 4
            },
            new RecipeProducts()
            {
                Id = 18,
                ProductId = 12,
                RecipeId = 4
            },
            new RecipeProducts()
            {
                Id = 19,
                ProductId = 19,
                RecipeId = 4
            },
            new RecipeProducts()
            {
                Id = 20,
                ProductId = 9,
                RecipeId = 5
            },
            new RecipeProducts()
            {
                Id = 21,
                ProductId = 24,
                RecipeId = 5
            },
            new RecipeProducts()
            {
                Id = 22,
                ProductId = 13,
                RecipeId = 5
            },
            new RecipeProducts()
            {
                Id = 23,
                ProductId = 11,
                RecipeId = 5
            },
            new RecipeProducts()
            {
                Id = 24,
                ProductId = 12,
                RecipeId = 5
            },
            new RecipeProducts()
            {
                Id = 25,
                ProductId = 14,
                RecipeId = 5
            },
            new RecipeProducts()
            {
                Id = 26,
                ProductId = 17,
                RecipeId = 5
            },
            new RecipeProducts()
            {
                Id = 27,
                ProductId = 10,
                RecipeId = 5
            },
            new RecipeProducts()
            {
                Id = 28,
                ProductId = 21,
                RecipeId = 6
            },
            new RecipeProducts()
            {
                Id = 29,
                ProductId = 19,
                RecipeId = 6
            },
            new RecipeProducts()
            {
                Id = 30,
                ProductId = 10,
                RecipeId = 6
            },
            new RecipeProducts()
            {
                Id = 31,
                ProductId = 9,
                RecipeId = 7
            },
            new RecipeProducts()
            {
                Id = 32,
                ProductId = 10,
                RecipeId = 7
            },
            new RecipeProducts()
            {
                Id = 33,
                ProductId = 19,
                RecipeId = 7
            },
            new RecipeProducts()
            {
                Id = 34,
                ProductId = 9,
                RecipeId = 8
            },
            new RecipeProducts()
            {
                Id = 35,
                ProductId = 10,
                RecipeId = 8
            },
            new RecipeProducts()
            {
                Id = 36,
                ProductId = 16,
                RecipeId = 8
            },
            new RecipeProducts()
            {
                Id = 37,
                ProductId = 17,
                RecipeId = 8
            },
            new RecipeProducts()
            {
                Id = 38,
                ProductId = 13,
                RecipeId = 8
            },
            new RecipeProducts()
            {
                Id = 39,
                ProductId = 15,
                RecipeId = 8
            }
            );
        }
    }
}

