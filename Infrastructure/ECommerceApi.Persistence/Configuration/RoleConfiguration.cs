using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistence.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            Role Admin=new Role()
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            Role USER = new Role()
            {
                Id = Guid.NewGuid(),
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };


            builder.HasData(Admin,USER);
        }
    }
}
