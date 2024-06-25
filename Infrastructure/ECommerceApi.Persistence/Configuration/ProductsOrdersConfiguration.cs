using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistence.Configuration
{
    public class ProductsOrdersConfiguration : IEntityTypeConfiguration<ECommerceApi.Domain.Entities.ProductsOrders>
    {

        public void Configure(EntityTypeBuilder<Domain.Entities.ProductsOrders> builder)
        {

            builder.HasKey(pk => new { pk.OrderId,pk.ProductId}) ;

            builder.HasOne(ord => ord.Order)
                .WithMany(po => po.ProductsOrders)
                .HasForeignKey(fk => fk.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ord => ord.product)
                .WithMany(po => po.ProductsOrders)
                .HasForeignKey(fk => fk.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
           
    }
}
