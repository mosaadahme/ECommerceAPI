using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.Registration
{
    public class RegistrationCommandValidator:AbstractValidator<RegistrationCommandRequest>
    {
        public RegistrationCommandValidator()
        {
            RuleFor(prop => prop.FullName)
                   .NotEmpty()
                   .WithName("Surname")
                   .MaximumLength(50)
                   .MinimumLength(5);

            RuleFor(prop => prop.Email)
                   .NotEmpty()
                   .WithName("Email Address")
                   .MaximumLength(50)
                   .MinimumLength(8)
                   .EmailAddress();

            RuleFor(prop => prop.Password)
                   .NotEmpty()
                   .WithName("Password")
                   .MinimumLength(8);



            RuleFor(prop => prop.ConfirmPassword)
                   .NotEmpty()
                   .WithName("Confirm Password")
                   .MinimumLength(8)
                   .Equal(prop=>prop.Password);

         
        }
    }
}
