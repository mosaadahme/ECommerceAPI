using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandRequest : IRequest<Unit>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int BrandId { get; set; }

        public IList<int> CategortIds { get; set; }

        public IFormFileCollection? Images { get; set; }

    }
}
