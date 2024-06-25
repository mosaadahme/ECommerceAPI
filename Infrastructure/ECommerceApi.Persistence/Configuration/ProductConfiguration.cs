using Bogus;
using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace YECommerceApi.Persistence.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new ("en");
           
            Product product01 = new Product()
            {
                Id = 1,
                Title = faker.Commerce.ProductName(),
                Description=faker.Commerce.ProductDescription(),
                Price = faker.Finance.Amount(50,2000),
                Discount=faker.Random.Decimal(10,50),
                AddedOnDate =DateTime.Now,
                IsDeleted=false, 
                BrandId=1
            };
            Product product02 = new Product()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Price = faker.Finance.Amount(50, 2000),
                Discount = faker.Random.Decimal(10, 50),
                AddedOnDate = DateTime.Now,
                IsDeleted = false,
                BrandId = 1
            };
            Product product03 = new Product()
            {
                Id = 3,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Price = faker.Finance.Amount(50, 2000),
                Discount = faker.Random.Decimal(10, 50),
                AddedOnDate = DateTime.Now,
                IsDeleted = true,
                BrandId = 3
            };
            
            builder.HasData(product01,product02,product03);
        }
    }
}
