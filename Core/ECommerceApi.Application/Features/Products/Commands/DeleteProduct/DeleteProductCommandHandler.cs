using ECommerceApi.Application.Bases;
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
 

namespace ECommerceApi.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler :BaseHandler ,IRequestHandler<DeleteProductCommandRequest,Unit>
    {
        

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper,IHttpContextAccessor httpContextAccessor)
            :base(unitOfWork,mapper,httpContextAccessor)
        {
             
        }
        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = await UnitOfWork.readRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            product.IsDeleted = true;

            product.UpdatedDate = DateTime.Now;

            product.AddedOnDate = product.AddedOnDate;

            await UnitOfWork.writeRepository<Product>().UpdateAsync(request.Id,product);

            await UnitOfWork.SaveChangeAsync();

            return Unit.Value;
        }
    }
}
