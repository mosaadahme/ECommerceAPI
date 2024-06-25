using Bogus;
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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new("en");

            Detail detail01 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 1,
                AddedOnDate = DateTime.Now,
                IsDeleted = false,
            };
            Detail detail02 = new()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(2),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 3,
                AddedOnDate = DateTime.Now,
                IsDeleted = true,
            };
            Detail detail03 = new()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 4,
                AddedOnDate = DateTime.Now,
                IsDeleted = false,
            };

            builder.HasData(detail01, detail02, detail03);
        }
    }
}
