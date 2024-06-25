using ECommerceApi.Application.Bases;
using ECommerceApi.Application.DTOs;
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

namespace ECommerceApi.Application.Features.Orders.Comments.MakeOrder
{
    public class MakeOrderCommentHandler : BaseHandler, IRequestHandler<MakeOrderCommentRequest,Unit>
    {
        public MakeOrderCommentHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor) 
            : base(unitOfWork, mapper, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(MakeOrderCommentRequest request, CancellationToken cancellationToken)
        { 
 
            List<decimal> TotalPrice = new();


            foreach (var order in request.makeOrderDTOs)
            {
                Product product= await UnitOfWork.readRepository<Product>().GetAsync(predicate:x=>x.Id==order.ProductId);
                
                TotalPrice.Add(product.Price*order.ProductCount);

            }
            Guid UserIdFromToken = Guid.Parse(UserId);
           
            Order orderObject= new Order(UserIdFromToken, orderType: Domain.Enums.OrderType.Received, TotalPrice.Sum());
            
            await UnitOfWork.writeRepository<Order>().AddAsync(orderObject);

              if (await UnitOfWork.SaveChangeAsync() > 0) 
            {
                foreach (var order in request.makeOrderDTOs)
                {
                    await UnitOfWork.writeRepository<ProductsOrders>().AddAsync(new ProductsOrders() 
                    {
                        OrderId=orderObject.Id,

                        ProductId=order.ProductId
                    });
                }
            }
            
            await UnitOfWork.SaveChangeAsync();


            return Unit.Value;

        }
    }
}
