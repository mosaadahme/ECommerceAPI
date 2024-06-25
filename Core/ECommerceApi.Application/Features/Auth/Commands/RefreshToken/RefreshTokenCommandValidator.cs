using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.RefreshToken
{
    public class RefreshTokenCommandValidator:AbstractValidator<RefreshTokenCommandRequest>
    {
        public RefreshTokenCommandValidator()
        {
            RuleFor(x => x.RefreshToken)
                .NotEmpty();

            RuleFor(x => x.AccessToken)
                .NotEmpty();
        }
    }
}
