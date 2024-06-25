using ECommerceApi.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistence.Context
{
    public class ApplicationDbContext:IdentityDbContext<User,Role,Guid>
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optionsBuilder):base(optionsBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           
          
        }
        public virtual DbSet<Product> products { get; set; }
        public virtual DbSet<Category>  categories { get; set; }
        public virtual DbSet<Brand>  brands { get; set; }
        public virtual DbSet<Detail>  details  { get; set; }
        public virtual DbSet<Image> images { get; set; }
        public virtual DbSet<Rating> ratings { get; set; }
        public virtual DbSet<ProductsCategories>   ProductsCategories  { get; set; }
        public virtual DbSet<ProductsOrders> orderProducts { get; set; }
        public virtual DbSet<Order> orders { get; set; }
        public virtual DbSet<DeviceInfo> deviceInfo { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }




    }
}
