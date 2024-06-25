using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.ResetPassword.ISCodeForResetPassword
{
    public class ISCodeForResetPasswordCommandValidator:AbstractValidator<ISCodeForResetPasswordCommandRequest>
    {
        public ISCodeForResetPasswordCommandValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();

            RuleFor(x => x.CodeOfConfirm)
                .NotEmpty();
        }
    }
}
