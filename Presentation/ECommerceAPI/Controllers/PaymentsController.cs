using ECommerceApi.Application.Features.Payments.Commands.CreatePayment;
using ECommerceAPI.Controllers._BaseController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentsController : BaseController
    {
        public PaymentsController(IMediator mediator)
            : base(mediator)
        {
        }

        [Authorize]
        [HttpPost("CreatePayment")]
        public async Task<CreatePaymentCommandResponse> CreatePaymentAsync([FromForm] CreatePaymentCommandRequest request)
            =>await mediator.Send(request);
      
    }
}
