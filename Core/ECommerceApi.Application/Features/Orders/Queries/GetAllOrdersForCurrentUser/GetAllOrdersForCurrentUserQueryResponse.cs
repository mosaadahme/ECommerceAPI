using ECommerceApi.Application.DTOs;
using ECommerceApi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Queries.GetAllOrdersForCurrentUser
{
    public class GetAllOrdersForCurrentUserQueryResponse
    {

        public int Id { get; set; }
        public Decimal TotalAmount { get; set; }

        public OrderType OrderType { get; set; }
         
        public IList<ProductsDTO> ProductsDTOs { get; set; }


    }
}
