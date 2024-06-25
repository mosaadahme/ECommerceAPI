using ECommerceApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class ProductsOrders:IEntityBase
    {

        public ProductsOrders(int productId, int orderId)
        {
            ProductId = productId;
            OrderId = orderId;
        }

        public ProductsOrders()
        {

        }


        [ForeignKey("product")]
        public int ProductId { get; set; }

        public virtual Product product { get; set; }


        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
