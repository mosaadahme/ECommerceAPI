using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistence.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne<User>(x => x.user)
                .WithMany(x => x.transactions)
                .HasForeignKey(x => x.userId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
