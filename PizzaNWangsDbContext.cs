using Microsoft.EntityFrameworkCore;
using PizzaNWangs.Models;
using System;

namespace PizzaNWangs.Data
{
    public class PizzaNWangsDbContext : DbContext
    {
        public PizzaNWangsDbContext(DbContextOptions<PizzaNWangsDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var currentTimeUtc = DateTime.UtcNow;


            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { Id = 1, Name = "Classic Pizza", Price = 10.99m, Description = "A delicious classic pizza with cheese and tomato sauce.", Available = true },
                new MenuItem { Id = 2, Name = "BBQ Wings", Price = 7.99m, Description = "Smokey BBQ wings.", Available = true },
                new MenuItem { Id = 3, Name = "Veggie Pizza", Price = 11.99m, Description = "Loaded with fresh vegetables.", Available = true },
                new MenuItem { Id = 4, Name = "Spicy Wings", Price = 8.99m, Description = "Wings with a spicy kick.", Available = true }
            );


            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Uid = "amuro-ray-uid", Email = "amuro@whitebase.com", FirstName = "Amuro", LastName = "Ray", ProfilePic = "url-to-amuro-pic" },
                new User { Id = 2, Uid = "char-aznable-uid", Email = "char@zeon.com", FirstName = "Char", LastName = "Aznable", ProfilePic = "url-to-char-pic" },
                new User { Id = 3, Uid = "kamille-bidan-uid", Email = "kamille@aeug.com", FirstName = "Kamille", LastName = "Bidan", ProfilePic = "url-to-kamille-pic" },
                new User { Id = 4, Uid = "judau-ashta-uid", Email = "judau@junkyard.com", FirstName = "Judau", LastName = "Ashta", ProfilePic = "url-to-judau-pic" }
            );


            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, CustomerPhone = "123-456-7890", CustomerEmail = "user1@pizzanwangs.com", OrderType = "Takeout", OrderStatus = OrderStatus.Paid, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Order { Id = 2, CustomerPhone = "234-567-8901", CustomerEmail = "user2@pizzanwangs.com", OrderType = "Delivery", OrderStatus = OrderStatus.Paid, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Order { Id = 3, CustomerPhone = "345-678-9012", CustomerEmail = "user3@pizzanwangs.com", OrderType = "Takeout", OrderStatus = OrderStatus.Paid, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Order { Id = 4, CustomerPhone = "456-789-0123", CustomerEmail = "user4@pizzanwangs.com", OrderType = "Delivery", OrderStatus = OrderStatus.Closed, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Order { Id = 5, CustomerPhone = "567-890-1234", CustomerEmail = "user5@pizzanwangs.com", OrderType = "Takeout", OrderStatus = OrderStatus.Closed, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Order { Id = 6, CustomerPhone = "678-901-2345", CustomerEmail = "user6@pizzanwangs.com", OrderType = "Delivery", OrderStatus = OrderStatus.Paid, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Order { Id = 7, CustomerPhone = "789-012-3456", CustomerEmail = "user7@pizzanwangs.com", OrderType = "Takeout", OrderStatus = OrderStatus.Closed, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Order { Id = 8, CustomerPhone = "890-123-4567", CustomerEmail = "user8@pizzanwangs.com", OrderType = "Delivery", OrderStatus = OrderStatus.Open, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );



            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { Id = 1, OrderId = 1, MenuItemId = 1, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc },
                new OrderItem { Id = 2, OrderId = 2, MenuItemId = 2, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc },
                new OrderItem { Id = 3, OrderId = 3, MenuItemId = 3, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc },
                new OrderItem { Id = 4, OrderId = 4, MenuItemId = 4, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc }
            );
        }
    }
}

