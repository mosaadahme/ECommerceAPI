using ECommerceApi.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Products.Queries.GetProductsFilteration
{
    public class GetProductsFilterationQueryValidator:AbstractValidator<GetProductsFilterationQueryRequest>
    {
        public GetProductsFilterationQueryValidator()
        { 
            RuleFor(x => x.SearchInput)
                .NotEmpty()
                .NotNull();
        }
    }
}
