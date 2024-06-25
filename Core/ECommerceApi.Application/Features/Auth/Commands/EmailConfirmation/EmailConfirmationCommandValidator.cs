using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.EmailConfirmation
{
    public class EmailConfirmationCommandValidator:AbstractValidator<EmailConfirmationCommandRequest>
    {
        public EmailConfirmationCommandValidator()
        {
            RuleFor(x => x.Email)
                .NotNull()
                .EmailAddress();

            RuleFor(x=>x.Token)
                .NotNull();
        }
    }
}
