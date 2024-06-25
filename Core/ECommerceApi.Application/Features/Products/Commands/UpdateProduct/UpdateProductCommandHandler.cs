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
 

namespace ECommerceApi.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler :BaseHandler, IRequestHandler<UpdateProductCommandRequest,Unit>
    {
       

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork,IMapper mapper,IHttpContextAccessor httpContextAccessor)
            : base(unitOfWork, mapper, httpContextAccessor)
        {
            
        }
        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product= await UnitOfWork.readRepository<Product>().GetAsync(x=>x.Id==request.Id);

            IList<ProductsCategories> _productsCategory= await UnitOfWork.readRepository<ProductsCategories>()
                                              .GetAllAsync(p=>p.ProductId==request.Id);

            Product mapping=Mapper.Map<Product,UpdateProductCommandRequest>(request);

            mapping.UpdatedDate = DateTime.Now;

            mapping.AddedOnDate = product.AddedOnDate;

            await UnitOfWork.writeRepository<ProductsCategories>().DeleteRangeAsync(_productsCategory);

            foreach (var categoryid in request.CategortIds) 
            {
                await UnitOfWork.writeRepository<ProductsCategories>().AddAsync(new() 
                {
                   CategoryId= categoryid,
                   ProductId= request.Id
                });
            }

         

            await UnitOfWork.writeRepository<Product>().UpdateAsync(product.Id, mapping);

            await UnitOfWork.SaveChangeAsync();


            return Unit.Value;
        
        
        }
    }
}
