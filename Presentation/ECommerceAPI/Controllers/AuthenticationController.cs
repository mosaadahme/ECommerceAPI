using ECommerceApi.Application.Features.Auth.Commands.Login;
using ECommerceApi.Application.Features.Auth.Commands.RefreshToken;
using ECommerceApi.Application.Features.Auth.Commands.ResetPassword.ISCodeForResetPassword;
using ECommerceApi.Application.Features.Auth.Commands.ResetPassword.SendForResetPassword;
using ECommerceApi.Application.Features.Auth.Commands.Revoke.RevokeForAllUsers;
using ECommerceApi.Application.Features.Auth.Commands.Revoke.RevokeForUser;
using ECommerceAPI.Controllers._BaseController;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : BaseController
    {
        public AuthenticationController(IMediator mediatR) : base(mediatR) { }

        [HttpGet("RefreshToken")]
        public async Task<IActionResult> RefreshToken(RefreshTokenCommandRequest request)
        {
            var demo = await mediator.Send(request);
            return Ok(demo);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm] LoginCommandRequest request)
        {
            LoginCommandResponse Demo = await mediator.Send(request);
            return Ok(Demo);
        }

        [HttpPost("SendForResetPassword")]
        public async Task<IActionResult> SendForResetPassword(SendForResetPasswordCommandsRequest request)
        {
            return Ok(await mediator.Send(request));
        }

        [HttpPut("ISCodeForResetPasswordCorrect")]
        public async Task<IActionResult> ISCodeForResetPasswordCorrect(ISCodeForResetPasswordCommandRequest request)
        {
            return Ok(await mediator.Send(request));
        }


        [HttpPut("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ISCodeForResetPasswordCommandRequest request)
        {
            return Ok(await mediator.Send(request));
        }

        [HttpDelete("RevokeSpacificUser")]
        public async Task<IActionResult> RevokeSpacificUser([FromForm] RevokeForUserCommandRequest request)
        {

            return Ok(await mediator.Send(request));
        }

        [HttpDelete("RevokeAllUser")]
        public async Task<IActionResult> RevokeAllUser(RevokeForAllUsersCommandRequest request)
        {

            return Ok(await mediator.Send(request));
        }
         
    }
}
