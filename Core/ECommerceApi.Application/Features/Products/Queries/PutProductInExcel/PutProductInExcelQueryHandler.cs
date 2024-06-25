using ECommerceApi.Application.Bases;
using ECommerceApi.Application.DTOs;
using ECommerceApi.Application.Features.Products.Queries.GetAllProducts;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace ECommerceApi.Application.Features.Products.Queries.PutProductInExcel
{
    public class PutProductInExcelQueryHandler :BaseHandler, IRequestHandler<PutProductInExcelQueryRequest, ActionResult>
    {
        public PutProductInExcelQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor) 
            : base(unitOfWork, mapper, httpContextAccessor)
        {
        }

        public async Task<ActionResult> Handle(PutProductInExcelQueryRequest request, CancellationToken cancellationToken)
        {
            var Products = await UnitOfWork.readRepository<Product>().GetAllAsync(include: x => x.Include(x => x.Brand).Include(x => x.images).Include(x => x.ProductsCategory).ThenInclude(x => x.Category));//


            Mapper.Map<BrandDTO, Brand>(Products.Select(x => x.Brand).ToList());


            Mapper.Map<ImageDTO, Image>(Products.SelectMany(x => x.images).ToList());


            var productsDemo = Mapper.Map<GetAllProductQueryResponse, Product>(Products);

            foreach (var item in productsDemo)
            {
                var x = Products.SelectMany(x => x.ProductsCategory.Where(y => y.ProductId == item.Id)).Select(q => q.Category.Name).ToList();
                item.CategoriesOfProducts = x.Select(x => new CategoriesOfProductsDTO() { Name = x }).ToList();
            }


            //foreach (var item in productsDemo)
            //    item.Price -= (item.Price * (item.Discount / 100));



           var Table =await ProductTable(productsDemo.ToList());


            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet(Table, "Products");

              using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return new FileContentResult(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = "Products.xlsx"
                    };
                }
            }
        }
 
        private async Task<DataTable> ProductTable(List<GetAllProductQueryResponse> queryResponses)
        {
            DataTable dt = new DataTable("ProductData");
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Discount", typeof(decimal));
            dt.Columns.Add("Categories", typeof(string));

            foreach (var item in queryResponses)
            {
                var categories = string.Join(", ", item.CategoriesOfProducts.Select(c => c.Name));
                dt.Rows.Add(item.Id, item.Title, item.Price, item.Discount, categories);
            }

            return  dt;
        }




    }
}
