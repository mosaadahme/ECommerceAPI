using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Payments.Commands.CreatePayment
{
    public record CreatePaymentCommandRequest
        (decimal Amount, string Currency, string Description, string PaymentMethod) : IRequest<CreatePaymentCommandResponse>
    {

    }
}
