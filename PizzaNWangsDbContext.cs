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

            // Seed data for MenuItems
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { Id = 1, Name = "Classic Pizza", Price = 10.99m, Description = "A delicious classic pizza with cheese and tomato sauce.", Available = true },
                new MenuItem { Id = 2, Name = "BBQ Wings", Price = 7.99m, Description = "Smokey BBQ wings.", Available = true },
                new MenuItem { Id = 3, Name = "Veggie Pizza", Price = 11.99m, Description = "Loaded with fresh vegetables.", Available = true },
                new MenuItem { Id = 4, Name = "Spicy Wings", Price = 8.99m, Description = "Wings with a spicy kick.", Available = true }
            );

            // Seed data for Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "user1@pizzanwangs.com" },
                new User { Id = 2, Email = "user2@pizzanwangs.com" },
                new User { Id = 3, Email = "user3@pizzanwangs.com" },
                new User { Id = 4, Email = "user4@pizzanwangs.com" }
            );

            // Seed data for Orders - 3 Paid and 1 Closed
            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, CustomerPhone = "123-456-7890", CustomerEmail = "user1@pizzanwangs.com", OrderType = "Takeout", OrderStatus = OrderStatus.Paid, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc },
                new Order { Id = 2, CustomerPhone = "234-567-8901", CustomerEmail = "user2@pizzanwangs.com", OrderType = "Delivery", OrderStatus = OrderStatus.Paid, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc },
                new Order { Id = 3, CustomerPhone = "345-678-9012", CustomerEmail = "user3@pizzanwangs.com", OrderType = "Takeout", OrderStatus = OrderStatus.Paid, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc },
                new Order { Id = 4, CustomerPhone = "456-789-0123", CustomerEmail = "user4@pizzanwangs.com", OrderType = "Delivery", OrderStatus = OrderStatus.Closed, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc }
            );

            // Seed data for OrderItems - Tied to the orders above
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { Id = 1, OrderId = 1, MenuItemId = 1, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc },
                new OrderItem { Id = 2, OrderId = 2, MenuItemId = 2, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc },
                new OrderItem { Id = 3, OrderId = 3, MenuItemId = 3, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc },
                new OrderItem { Id = 4, OrderId = 4, MenuItemId = 4, CreatedAt = currentTimeUtc, UpdatedAt = currentTimeUtc }
            );
        }
    }
}

