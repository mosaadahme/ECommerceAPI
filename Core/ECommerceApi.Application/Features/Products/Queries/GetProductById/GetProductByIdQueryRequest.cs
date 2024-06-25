using ECommerceApi.Application.Interfaces.RedisCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQueryRequest:IRequest<GetProductByIdQueryResponse>, ICacheableQuery
    {
        public int ProductId { get; set;}

        public string CacheKey => "GetProductById";

        public double CacheTime => 6;
    }
}
