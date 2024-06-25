using ECommerceAPI.Controllers._BaseController;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizationController : BaseController
    {
        public AuthorizationController(IMediator mediator) : base(mediator) { }
        
    }
}
