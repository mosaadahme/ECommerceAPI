using Bogus;
using Bogus.DataSets;
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
    public class BrandConfiguration:IEntityTypeConfiguration<Brand>
    {

        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            Faker faker = new ("en");

            Brand brand01 = new Brand()
            {
                Id = 1,
                Name = faker.Commerce.Department(),
                AddedOnDate = DateTime.Now,
                IsDeleted = false
            };

            Brand brand02 = new Brand()
            {
                Id = 2,
                Name = faker.Commerce.Department(),
                AddedOnDate = DateTime.Now,
                IsDeleted = true
            };

            Brand brand03 = new Brand()
            {
                Id = 3,
                Name = faker.Commerce.Department(),
                AddedOnDate = DateTime.Now,
                IsDeleted = false
            };
             
            builder.HasData(brand01,brand02,brand03);
        }
    }
}
