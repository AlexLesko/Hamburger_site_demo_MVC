using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Hamburger_site_MVC.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 1,
                Name = "Black Burger",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Price = 17.55M,
                ImageUrl = "/Images/black_burger.jpg",
                ImageAlt = "Black Burger",
                IsBurgetOfTheWeek = false
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 2,
                Name = "Cheese Burger",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Price = 15M,
                ImageUrl = "/Images/cheese_burger.jpg",
                ImageAlt = "Cheese Burger",
                IsBurgetOfTheWeek = true
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 3,
                Name = "Colosal Burger",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Price = 22.5M,
                ImageUrl = "/Images/colosal_burger.jpg",
                ImageAlt = "Colosal Burger",
                IsBurgetOfTheWeek = false
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 4,
                Name = "Double Burger",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Price = 20.3M,
                ImageUrl = "/Images/double_burger.jpg",
                ImageAlt = "Double Burger",
                IsBurgetOfTheWeek = false
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 5,
                Name = "Minimalist Burger",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Price = 10.01M,
                ImageUrl = "/Images/minimal_burger.jpg",
                ImageAlt = "Minimalist Burger",
                IsBurgetOfTheWeek = true
            });

            modelBuilder.Entity<Burger>().HasData(new Burger
            {
                BurgerId = 6,
                Name = "Vega Burger",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Price = 30M,
                ImageUrl = "/Images/vega_burger.jpg",
                ImageAlt = "Vega Burger",
                IsBurgetOfTheWeek = false
            });
        }
    }
}
