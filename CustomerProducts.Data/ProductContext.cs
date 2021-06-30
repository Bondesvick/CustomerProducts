using CustomerProducts.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerProducts.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }
    }
}