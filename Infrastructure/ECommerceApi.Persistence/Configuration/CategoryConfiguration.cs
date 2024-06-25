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
 
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Faker faker = new("en");

            Category category01 = new()
            {
                Id = 1,
                Name = "Electric",
                Priorty = 1,
                ParentId = 0,
                IsDeleted = false,
                AddedOnDate = DateTime.Now,
            };

            Category category02 = new()
            {
                Id = 2,
                Name = "ElModa",
                Priorty = 2,
                ParentId = 0,
                IsDeleted = false,
                AddedOnDate = DateTime.Now,
            };

            Category parent01 = new()
            {
                Id = 3,
                Name = "Computer",
                Priorty = 1,
                ParentId = 1,
                IsDeleted = false,
                AddedOnDate = DateTime.Now,
            };

            Category parent02 = new()
            {
                Id = 4,
                Name = "Women",
                Priorty = 1,
                ParentId = 2,
                IsDeleted = false,
                AddedOnDate = DateTime.Now,
            };

            builder.HasData(category01, category02,parent01,parent02);

        }
    }
}
