using ECommerceApi.Application.Bases;
using ECommerceApi.Application.DTOs;
using ECommerceApi.Application.Features.Orders.Queries.GetAllOrders;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Queries.GetOrderById
{
    public class GetOrderByIdQueryHandler : BaseHandler, IRequestHandler<GetOrderByIdQueryRequest, GetOrderByIdQueryResponse>
    {
        public GetOrderByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor) 
            : base(unitOfWork, mapper, httpContextAccessor)
        {
        }

        public async Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var order = await UnitOfWork.readRepository<Order>().GetAsync(predicate:x=>x.Id==request.OrderId);
 
            var queryResponse = Mapper.Map<GetOrderByIdQueryResponse, Order>(order);

            var productsData = (from ProductsOrders in order.ProductsOrders
                     join products in order.ProductsOrders.Select(x => x.product)
                     on ProductsOrders.OrderId equals products.Id
                     where ProductsOrders.OrderId == order.Id
                     select products);

          queryResponse.ProductsDTOs= productsData.Select(x => new ProductsDTO() { Name = x.Title }).ToList();


             

            return queryResponse;
        }
    }
}
