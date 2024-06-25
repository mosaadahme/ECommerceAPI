using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Queries.GetOrderById
{
    public class GetOrderByIdQueryRequest :IRequest<GetOrderByIdQueryResponse>  //, ICacheableQuery
    {
        public int OrderId { get; set; }
    }
}
