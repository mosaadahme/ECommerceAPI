using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.ResetPassword.SendForResetPassword
{
    public class SendForResetPasswordCommandsValidator:AbstractValidator<SendForResetPasswordCommandsRequest>
    {
        public SendForResetPasswordCommandsValidator()
        {
            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress();
        }
    }
}
