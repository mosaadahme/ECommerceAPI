using ECommerceApi.Domain.Common;
using ECommerceApi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Order:EntityBase
    {

        public Order()
        {
            this.ProductsOrders = new HashSet<ProductsOrders>();

        }
        public Order(Guid userId, OrderType orderType, decimal totalAmount)
        {
            UserId = userId;
            OrderType = orderType;
            TotalAmount = totalAmount;
            this.ProductsOrders = new HashSet<ProductsOrders>();
        }


        public Decimal TotalAmount { get; set; }

        public OrderType OrderType { get; set; }

        [ForeignKey("user")]
        public Guid UserId { get; set; }
        public  virtual User user { get; set; }

        public virtual ICollection<ProductsOrders> ProductsOrders { get; set; }
    }
}
