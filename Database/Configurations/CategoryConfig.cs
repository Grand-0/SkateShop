using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skate.Database.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.CategoryName).HasMaxLength(50).IsRequired();

            builder.HasMany(c => c.Products)
                   .WithOne(p => p.Category)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
