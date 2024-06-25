using ECommerceApi.Application.Features.Products.Queries.GetAllProducts;
using ECommerceApi.Application.Interfaces.RedisCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Products.Queries.GetProductsFilteration
{
    public enum OrderedField
    {
        [EnumMember(Value = "None")]
        None=0,

        [EnumMember(Value = "Title")]
        Title=1,

        [EnumMember(Value = "Price")]

        Price=3,

        [EnumMember(Value = "Rank")]

        Rank=5

    }
    public class GetProductsFilterationQueryRequest:IRequest<List<GetProductsFilterationQueryResponse>>, ICacheableQuery
    {
      
        public string CacheKey => "GetProductsFilteration";

        public double CacheTime => 6;

        public string SearchInput { get; set; }


        [DefaultValue(OrderedField.None)]
        public OrderedField  OrderedField { get; set; }

    }
}
