using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Comments.UpdateOrder
{
    public class UpdateOrderCommentValidator:AbstractValidator<UpdateOrderCommentRequest>
    {
        public UpdateOrderCommentValidator()
        {
            //RuleFor(x => x.makeOrderDTOs.Select(x => x.ProductId))
            //    .NotNull()
            //    .NotEmpty();
                 

            //RuleFor(x => x.makeOrderDTOs.Select(x=>x.ProductCount))
            //    .NotEmpty()
            //    .NotEmpty()
            //    .Custom(x=>x.);
        }
    }
}
