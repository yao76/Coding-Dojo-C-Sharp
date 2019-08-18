using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> customers{get;set;}
        public DbSet<Product> products{get;set;}
        public DbSet<Order> orders{get;set;}
    }
}