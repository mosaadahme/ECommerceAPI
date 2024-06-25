using ECommerceApi.Application.Interfaces.RedisCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductQueryRequest : IRequest<IList<GetAllProductQueryResponse>>, ICacheableQuery
    {
        public string CacheKey => "GetAllProducts";

        public double CacheTime => 6;
    }
}
