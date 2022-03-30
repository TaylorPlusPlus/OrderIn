using System;
using Microsoft.EntityFrameworkCore;
using OrderIn.Domain.Abstracts;
using OrderIn.Domain.Models;

namespace OrderIn.Storage
{
    public class OrderInContext : DbContext
    {
        //Data to Save, DBSet
        public DbSet<Order> Orders {get;set;}
        //public DbSet<ADrink> Drinks {get;set;}
        public OrderInContext(DbContextOptions<OrderInContext> options) : base(options) { }
        //public OrderInContext(){}
        protected override void OnConfiguring(DbContextOptionsBuilder build)
        {
            build.UseSqlServer("Server=tcp:pizzabox.database.windows.net,1433;Initial Catalog=OrderIn;Persist Security Info=False;User ID=sqladmin;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder build)
        {
            build.Entity<Order>().HasKey(e => e.EntityId);
            build.Entity<ADrink>().HasKey(e => e.EntityId);
            build.Entity<AAppetizer>().HasKey(e => e.EntityId);

        }
        
    }
}
