using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Features.Auth.Rules;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.Tokens;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
 

namespace ECommerceApi.Application.Features.Auth.Commands.RefreshToken
{
    public class RefreshTokenCommandHandler : BaseHandler, IRequestHandler<RefreshTokenCommandRequest, RefreshTokenCommandResponse>
    {
        private readonly UserManager<User> userManager;
        private readonly ITokenService tokenService;
        private readonly AuthRules authRules;


        public RefreshTokenCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, ITokenService tokenService, AuthRules authRules)
            : base(unitOfWork, mapper, httpContextAccessor)
        {
            this.userManager = userManager;
            this.tokenService = tokenService;
            this.authRules = authRules;
        }

        public async Task<RefreshTokenCommandResponse> Handle(RefreshTokenCommandRequest request, CancellationToken cancellationToken)
        { 
            ClaimsPrincipal? principal =  tokenService.GetClaimsPrincipalFromExpiredToken(request.AccessToken);
             
            string? email = principal?.FindFirstValue(ClaimTypes.Email);

            User? user= await userManager.FindByEmailAsync(email);

            IList<string> roles=await userManager.GetRolesAsync(user);

            await authRules.RefreshTokenExpiryTimeShouldnotbeExpiredAsync(user?.RefreshTokenExpiryTime);

            JwtSecurityToken newSecurityToken = await tokenService.CreateToken(user,roles);

            string newRefreshToken = tokenService.GenerateRefreshToken();

            user.RefreshToken=newRefreshToken;

            await userManager.UpdateAsync(user);

            return new()
            {
                RefreshToken = newRefreshToken,
                AccessToken = new JwtSecurityTokenHandler().WriteToken(newSecurityToken)
            };



        }
    }
}
