using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Payments.Commands.CreatePayment
{
    public class CreatePaymentCommandValidator : AbstractValidator<CreatePaymentCommandRequest>
    {
        public CreatePaymentCommandValidator()
        {

        }
    }
}
