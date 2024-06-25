using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ECommerceApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ECommerceApi.Persistence.Configuration
{
    public class Products_CategoriesConfiguration : IEntityTypeConfiguration<ProductsCategories>
    {
        public void Configure(EntityTypeBuilder<ProductsCategories> builder)
        {
            builder.HasKey(x =>new{x.ProductId,x.CategoryId });

            builder.HasOne(p=>p.Product)
                .WithMany(pc=>pc.ProductsCategory)
                .HasForeignKey(pc=>pc.ProductId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(p => p.Category)
                .WithMany(pc => pc.ProductsCategory)
                .HasForeignKey(pc => pc.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
