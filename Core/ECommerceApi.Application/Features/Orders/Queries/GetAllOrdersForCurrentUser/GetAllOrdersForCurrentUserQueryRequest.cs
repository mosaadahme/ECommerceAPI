using ECommerceApi.Application.Interfaces.RedisCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Queries.GetAllOrdersForCurrentUser
{
    public class GetAllOrdersForCurrentUserQueryRequest : ICacheableQuery, IRequest<IList<GetAllOrdersForCurrentUserQueryResponse>>
    {
        //[DefaultValue("7164AB9D-DE00-41A5-3FF0-08DC86B45C88")]
        //public Guid UserId { get; set; }
        public string CacheKey => "GetAllOrdersForCurrentUser";

        public double CacheTime => 3;
    }
}
