using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandRequest:IRequest<Unit>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int BrandId { get; set; }

        public IList<int> CategortIds { get; set; }
    }
}
