using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Features.Products.Rules;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.Storage;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ECommerceApi.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler :BaseHandler ,IRequestHandler<CreateProductCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ProductRules productRules;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ILocalStorage localStorage;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork,
                                           ProductRules productRules,
                                           IMapper mapper,
                                           IHttpContextAccessor httpContextAccessor,
                                           ILocalStorage localStorage
                                           )
            : base(unitOfWork,mapper,httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.productRules = productRules;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.localStorage = localStorage;
        }



        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {


            IList<Product> products=await UnitOfWork.readRepository<Product>().GetAllAsync();


           await this.productRules.ProductsTitleMustNotBeTheSame(products, request.Title);

           Product product = new(request.Title,request.Description,request.Price,request.Discount,request.BrandId);
  
            await UnitOfWork.writeRepository<Product>().AddAsync(product);

            if (await UnitOfWork.SaveChangeAsync()>0)
            {
                foreach (var categoryid in request.CategortIds)
                {
                    await UnitOfWork.writeRepository<ProductsCategories>()
                                                        .AddAsync(new ProductsCategories
                                                        {
                                                            CategoryId=categoryid,
                                                            ProductId=product.Id
                                                        });
                  
                }
            }
            if (request.Images != null)
            {
                IList<(string fileName, string Path)> list = await localStorage.UploadManyAsync(product.Id, "images", request.Images);
                if (list != null)
                    foreach (var photo in list)
                        product.images.Add(new Domain.Entities.Image()
                        {
                            Path = photo.Path,
                            FileName = photo.fileName,
                            ProductId = product.Id,
                        });
               
            }

            await UnitOfWork.SaveChangeAsync();
            return Unit.Value;
        
        }
    }
}
