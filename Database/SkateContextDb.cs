using Microsoft.EntityFrameworkCore;
using Skate.Database.Configurations;
using Skate.Models;

namespace Skate.Database
{
    public class SkateContextDb : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public SkateContextDb(DbContextOptions<SkateContextDb> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //modelBuilder.ApplyConfiguration<Product>(new ProductConfig());
            //modelBuilder.ApplyConfiguration<Category>(new CategoryConfig());
        }
    }
}
