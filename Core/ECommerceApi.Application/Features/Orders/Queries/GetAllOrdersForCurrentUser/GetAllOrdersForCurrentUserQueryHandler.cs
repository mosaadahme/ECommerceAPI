using ECommerceApi.Application.Bases;
using ECommerceApi.Application.DTOs;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Domain.Entities;
using EllipticCurve.Utils;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Queries.GetAllOrdersForCurrentUser
{
    public class GetAllOrdersForCurrentUserQueryHandler :BaseHandler, IRequestHandler<GetAllOrdersForCurrentUserQueryRequest,IList<GetAllOrdersForCurrentUserQueryResponse>>
    {
        public GetAllOrdersForCurrentUserQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            : base(unitOfWork, mapper, httpContextAccessor)
        {
        }

        public async Task<IList<GetAllOrdersForCurrentUserQueryResponse>> Handle(GetAllOrdersForCurrentUserQueryRequest request, CancellationToken cancellationToken)
        {

             Guid userId =Guid.Parse(UserId);
            
             var ordersOfCurrentUser= await UnitOfWork.readRepository<Order>().GetAllAsync(predicate: x => x.UserId == userId);

             var ordersOfCurrentUserDemo = Mapper.Map<GetAllOrdersForCurrentUserQueryResponse, Order>(ordersOfCurrentUser);

            foreach (var order in ordersOfCurrentUserDemo)
            {
                var productsTitle = from _ordersOfCurrentUser in ordersOfCurrentUser
                        join _orderProductsOfCurrentUser in ordersOfCurrentUser.SelectMany(x => x.ProductsOrders)
                        on _ordersOfCurrentUser.Id equals _orderProductsOfCurrentUser.OrderId 
                        into ProductsOrder
                        select new {
                            productsName= from _ProductsOrder in ProductsOrder
                                          join _Products in _ordersOfCurrentUser.ProductsOrders.Select(x=>x.product)
                                          on _ProductsOrder.ProductId equals _Products.Id where order.Id == _ProductsOrder.OrderId
                                          select new { _Products.Title}
                                            
                                     };
                order.ProductsDTOs = productsTitle.SelectMany(x=>x.productsName).Select(x=>new ProductsDTO() { Name=x.Title}).ToList();
                
            }
            /*
             *  var productsTitle = from order in orders join  Orderproducts in orders.SelectMany(x => x.ProductsOrders)
                                     on order.Id equals Orderproducts.OrderId into 
                                     demo select new
                                     {
                                         productsNames = from Orderproducts in demo
                                                         join products in order.ProductsOrders.Select(x=>x.product)
                                                         on Orderproducts.ProductId equals products.Id 
                                                         where Orderproducts.OrderId == orderobj.Id
                                                         select new { products.Title }
                                     };

                 var titles = productsTitle.SelectMany(x=>x.productsNames.Select(x=>x.Title)).ToList();

                 orderobj.ProductsDTOs = titles.Select(x => new ProductsDTO() { Name = x }).ToList();
             */

            return ordersOfCurrentUserDemo;

        }
    }
}
