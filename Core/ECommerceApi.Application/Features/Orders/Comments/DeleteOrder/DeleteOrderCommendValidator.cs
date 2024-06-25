using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Comments.DeleteOrder
{
    public class DeleteOrderCommendValidator:AbstractValidator<DeleteOrderCommendRequest>
    {
        public DeleteOrderCommendValidator()
        {
            RuleFor(x=>x.Id)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
