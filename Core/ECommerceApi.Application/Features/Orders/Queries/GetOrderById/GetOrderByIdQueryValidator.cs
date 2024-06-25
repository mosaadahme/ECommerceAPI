using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Queries.GetOrderById
{
    public class GetOrderByIdQueryValidator :AbstractValidator<GetOrderByIdQueryRequest>
    {
        public GetOrderByIdQueryValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}
