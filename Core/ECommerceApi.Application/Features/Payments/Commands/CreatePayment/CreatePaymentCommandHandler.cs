using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.Payment;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ECommerceApi.Application.Features.Payments.Commands.CreatePayment
{
    public class CreatePaymentCommandHandler :BaseHandler, IRequestHandler<CreatePaymentCommandRequest, CreatePaymentCommandResponse>
    {
        private readonly IPaymentService paymentService;
 
        public CreatePaymentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor,IPaymentService paymentService) 
            : base(unitOfWork, mapper, httpContextAccessor)
        {
            this.paymentService = paymentService;
            
        }

        public async Task<CreatePaymentCommandResponse> Handle(CreatePaymentCommandRequest request, CancellationToken cancellationToken)
        {
            var _paymenyId=await paymentService.CreatePaymentAsync(request.Amount, request.Currency, request.Description);


            var TransactionObject = new Transaction()
            {
                userId=Guid.Parse(UserId),
                Amount = request.Amount,
                Currency = request.Currency,
                PaymentId = _paymenyId,
                PaymentMethod=request.PaymentMethod,
                Status="Created",
                AddedOnDate=DateTime.Now

            };


            await UnitOfWork.writeRepository<Transaction>().AddAsync(TransactionObject);

            await UnitOfWork.SaveChangeAsync();

            return new CreatePaymentCommandResponse() { paymentId = _paymenyId };
        }
    }
}
