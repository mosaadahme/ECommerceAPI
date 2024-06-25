using ECommerceApi.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ECommerceApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
 
        public decimal Price { get; set; }

        public decimal Discount { get; set; }
        
        public BrandDTO Brand { get; set; }

        public IList<ImageDTO> Images { get; set; }

        public List<CategoriesOfProductsDTO>  CategoriesOfProducts { get; set; }

    }
}
