using Microsoft.EntityFrameworkCore;
namespace ProductsAndCategories.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products{get;set;}
        public DbSet<Category> Categories{get;set;}
        public DbSet<ProductCategory> ProdutCategories{get;set;}
    }
}