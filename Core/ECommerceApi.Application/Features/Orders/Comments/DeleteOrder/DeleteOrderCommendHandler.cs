using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Features.Orders.Rules;
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

namespace ECommerceApi.Application.Features.Orders.Comments.DeleteOrder
{
    public class DeleteOrderCommendHandler :BaseHandler , IRequestHandler<DeleteOrderCommendRequest, Unit>
    {
        private readonly OrderRules orderRules;

        public DeleteOrderCommendHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor,OrderRules orderRules) 
            : base(unitOfWork, mapper, httpContextAccessor)
        {
            this.orderRules = orderRules;
        }

        public async Task<Unit> Handle(DeleteOrderCommendRequest request, CancellationToken cancellationToken)
        {
            var order = await UnitOfWork.readRepository<Order>().GetAsync(predicate: x => x.Id == request.Id);
        
            await orderRules.TheOrderShouldBeExist(order);

            await orderRules.TheSameUserForTheSameOrder(order.UserId,Guid.Parse(UserId));

            order.IsDeleted= true;

            order.DeletedDate = DateTime.Now;

            await UnitOfWork.writeRepository<Order>().UpdateAsync(request.Id,order);

            await UnitOfWork.SaveChangeAsync();

            return Unit.Value;
                   
        }
    }
}
