using ECommerceApi.Application.Features.Auth.Commands.Registration;
using ECommerceAPI.Controllers._BaseController;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApplicationUserController : BaseController
    {
        public ApplicationUserController(IMediator mediator) : base(mediator) { }


        [HttpPost("Registration")]
        public async Task<IActionResult> Registration([FromForm] RegistrationCommandRequest request)
        {
            await mediator.Send(request);
            return Created();
        }
    }
}
