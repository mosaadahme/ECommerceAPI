using ECommerceApi.Application.Interfaces.RedisCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrdersQueryRequest:IRequest<IList<GetAllOrdersQueryResponse>>, ICacheableQuery
    {
        public string CacheKey => "GetAllOrders";

        public double CacheTime => 6;
    }
}
