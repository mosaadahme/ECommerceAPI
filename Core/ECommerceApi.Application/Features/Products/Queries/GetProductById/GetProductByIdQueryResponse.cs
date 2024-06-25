using ECommerceApi.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public BrandDTO Brand { get; set; }

        public IList<ImageDTO> Images { get; set; }

        public List<CategoriesOfProductsDTO> CategoriesOfProducts { get; set; }
    }
}
