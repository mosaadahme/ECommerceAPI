using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Features.Orders.Rules;
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

namespace ECommerceApi.Application.Features.Orders.Comments.UpdateOrder
{
    public class UpdateOrderCommentHandler :BaseHandler, IRequestHandler<UpdateOrderCommentRequest, Unit>
    {
        private readonly OrderRules orderRules;

        public UpdateOrderCommentHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor,OrderRules orderRules) 
            : base(unitOfWork, mapper, httpContextAccessor)
        {
            this.orderRules = orderRules;
        }

        public async Task<Unit> Handle(UpdateOrderCommentRequest request, CancellationToken cancellationToken)
        {

            Order? oldOrder =await UnitOfWork.readRepository<Order>().GetAsync(predicate: x => x.Id == request.Id);

            await orderRules.TheOrderShouldBeExist(oldOrder);

            await orderRules.TheSameUserForTheSameOrder(Guid.Parse(UserId), oldOrder.UserId);

            IList<ProductsOrders> productsOrders = await UnitOfWork.readRepository<ProductsOrders>().GetAllAsync(predicate: x => x.OrderId == oldOrder.Id);

            Order orderObject = Mapper.Map<Order,UpdateOrderCommentRequest>(request); //new Order(Guid.Parse(UserId), orderType: Domain.Enums.OrderType.Received, TotalPrice.Sum());

          

            List<decimal> TotalPrice = new();

            foreach (var tempOrder in request.makeOrderDTOs)
            {
                Product product = await UnitOfWork.readRepository<Product>().GetAsync(predicate: x => x.Id == tempOrder.ProductId);

                TotalPrice.Add(product.Price * tempOrder.ProductCount);

            } 

            await UnitOfWork.writeRepository<ProductsOrders>().DeleteRangeAsync(productsOrders);

            foreach (var TempOrder in request.makeOrderDTOs)
            {
                await UnitOfWork.writeRepository<ProductsOrders>().AddAsync(new ProductsOrders()
                {
                    OrderId = orderObject.Id,

                    ProductId = TempOrder.ProductId
                });
            }

            orderObject.UserId = oldOrder.UserId;

            orderObject.UpdatedDate = DateTime.Now;

            orderObject.AddedOnDate = oldOrder.AddedOnDate;

            orderObject.TotalAmount = TotalPrice.Sum();
            
            await UnitOfWork.writeRepository<Order>().UpdateAsync(request.Id, orderObject);
 
            
            await UnitOfWork.SaveChangeAsync();


            return Unit.Value;

        }
    }
}
