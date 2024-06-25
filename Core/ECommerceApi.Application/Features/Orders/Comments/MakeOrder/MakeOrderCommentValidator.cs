using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Comments.MakeOrder
{
    public class MakeOrderCommentValidator:AbstractValidator<MakeOrderCommentRequest>
    {
        public MakeOrderCommentValidator()
        {
            //RuleFor(x => x.makeOrderDTOs.Select(x=>x.ProductId)).
            //    .NotNull()
            //    .NotEmpty()
            //    .GreaterThan(0);

            //RuleFor(x=>x.ProductCount)
            //    .NotEmpty() 
            //    .NotEmpty()
            //    .GreaterThan(0);
        }
    }
}
