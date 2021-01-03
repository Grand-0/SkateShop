using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skate.Database.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.ProductDesc).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.Category)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
