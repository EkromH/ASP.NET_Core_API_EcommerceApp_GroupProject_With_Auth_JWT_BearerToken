using IsDB_R57_Solely.Entities.Orders;
using IsDB_R57_Solely.Entities.Products;
using IsDB_R57_Solely.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection.Emit;


namespace IsDB_R57_Solely.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
            new Brand { BrandId = 1, Name = "Nike", Description = "Leading manufacturer of athletic shoes, apparel, and accessories.", isActive = true },
            new Brand { BrandId = 2, Name = "Adidas", Description = "German multinational corporation that designs and manufactures shoes, clothing and accessories.", isActive = true },
            new Brand { BrandId = 3, Name = "Puma", Description = "Global athletic brand that fuses influences from sport, lifestyle, and fashion.", isActive = true },
            new Brand { BrandId = 4, Name = "Reebok", Description = "American-inspired global brand with a deep heritage in fitness.", isActive = true },
            new Brand { BrandId = 5, Name = "New Balance", Description = "Produces a range of sneakers and apparel for athletes and lifestyle.", isActive = true },
            new Brand { BrandId = 6, Name = "Asics", Description = "Japanese multinational corporation that produces footwear and sports equipment designed for a wide range of sports.", isActive = true },
            new Brand { BrandId = 7, Name = "Skechers", Description = "American footwear company offering lifestyle and performance footwear.", isActive = true },
            new Brand { BrandId = 8, Name = "Under Armour", Description = "American company that manufactures footwear, sports, and casual apparel.", isActive = true },
            new Brand { BrandId = 9, Name = "Vans", Description = "American manufacturer of skateboarding shoes and related apparel.", isActive = true },
            new Brand { BrandId = 10, Name = "Converse", Description = "American shoe company that designs, distributes, and licenses sneakers, skating shoes, lifestyle brand footwear, apparel, and accessories.", isActive = true }
            );

            modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Men", Description = "Footwear for men.", isActive = true },
            new Category { CategoryId = 2, Name = "Women", Description = "Footwear for women.", isActive = true },
            new Category { CategoryId = 3, Name = "Kids", Description = "Footwear for kids.", isActive = true },
            new Category { CategoryId = 4, Name = "Sports", Description = "Sports footwear.", isActive = true },
            new Category { CategoryId = 5, Name = "Casual", Description = "Casual footwear.", isActive = true }
            );

            modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, Name = "Nike Air Max", Description = "Comfortable and stylish running shoes.", Price = 120.00m, NormalizedName = "NIKE AIR MAX", ThumbnailImage = "nike_air_max.jpg", BrandId = 1, isActive = true, CreatedOn = DateTime.Now },
            new Product { ProductId = 2, Name = "Adidas Ultraboost", Description = "High-performance running shoes.", Price = 180.00m, NormalizedName = "ADIDAS ULTRABOOST", ThumbnailImage = "adidas_ultraboost.jpg", BrandId = 2, isActive = true, CreatedOn = DateTime.Now },
            new Product { ProductId = 3, Name = "Puma RS-X", Description = "Retro-style casual shoes.", Price = 110.00m, NormalizedName = "PUMA RS-X", ThumbnailImage = "puma_rsx.jpg", BrandId = 3, isActive = true, CreatedOn = DateTime.Now },
            new Product { ProductId = 4, Name = "Reebok Nano X", Description = "Versatile training shoes.", Price = 130.00m, NormalizedName = "REEBOK NANO X", ThumbnailImage = "reebok_nano_x.jpg", BrandId = 4, isActive = true, CreatedOn = DateTime.Now },
            new Product { ProductId = 5, Name = "New Balance 574", Description = "Classic lifestyle sneakers.", Price = 90.00m, NormalizedName = "NEW BALANCE 574", ThumbnailImage = "new_balance_574.jpg", BrandId = 5, isActive = true, CreatedOn = DateTime.Now }
            );

            //modelBuilder.Entity<ProductCategory>().HasData(
            //new ProductCategory { ProductCategoryId = 1, CategoryId = 1, ProductId = 1 },
            //new ProductCategory { ProductCategoryId = 2, CategoryId = 1, ProductId = 2 },
            //new ProductCategory { ProductCategoryId = 3, CategoryId = 2, ProductId = 3 },
            //new ProductCategory { ProductCategoryId = 4, CategoryId = 3, ProductId = 4 },
            //new ProductCategory { ProductCategoryId = 5, CategoryId = 4, ProductId = 5 }
            //);

            modelBuilder.Entity<User>().HasData(
            new User { Id = 1, UserName = "user1@example.com", FirstName = "John", LastName = "Doe", isActive = true, CreatedOn = DateTime.UtcNow },
            new User { Id = 2, UserName = "user2@example.com", FirstName = "Jane", LastName = "Smith", isActive = false, CreatedOn = DateTime.UtcNow }
            );

            modelBuilder.Entity<IdentityRole<int>>().HasData(
            new IdentityRole<int> { Id = 1, Name = "Super Admin", NormalizedName = "SUPER ADMIN" },
            new IdentityRole<int> { Id = 2, Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole<int> { Id = 3, Name = "Officer", NormalizedName = "OFFICER" },
            new IdentityRole<int> { Id = 4, Name = "Customer", NormalizedName = "CUSTOMER" }
            );

            modelBuilder.Entity<DeliveryMethod>().HasData(
            new DeliveryMethod
            {
                DeliveryMethodId = 1,
                ShortName = "RedX",
                Description = "Fastest delivery time",
                DeliveryTime = "1-2 Days",
                Price = 120.00M,
                isActive = true
            },
            new DeliveryMethod
            {
                DeliveryMethodId = 2,
                ShortName = "SA",
                Description = "Get it within 5 days",
                DeliveryTime = "2-5 Days",
                Price = 80.00M,
                isActive = true
            },
            new DeliveryMethod
            {
                DeliveryMethodId = 3,
                ShortName = "Shundarban",
                Description = "Slower but cheap",
                DeliveryTime = "5-7 Days",
                Price = 50.00M,
                isActive = true
            },
            new DeliveryMethod
            {
                DeliveryMethodId = 4,
                ShortName = "FREE",
                Description = "Free! You get what you pay for",
                DeliveryTime = "1-2 Month",
                Price = 0.00M,
                isActive = true
            }
            );
        }
    }
}
