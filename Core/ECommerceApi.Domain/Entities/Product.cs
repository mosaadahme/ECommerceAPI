using ECommerceApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Product : EntityBase
    {
        public Product() { }

        public Product(string title, string description, decimal price, decimal discount, int brandid)
        {
            Title = title;
            Description = description;
            Price = price;
            Discount = discount;
            BrandId = brandid;
            ProductsOrders = new HashSet<ProductsOrders>();
            images = new HashSet<Image>();
        }
        public string Title { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<ProductsCategories> ProductsCategory { get; set; }

        public virtual ICollection<ProductsOrders> ProductsOrders { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<Image>  images { get; set; }


    }
}
