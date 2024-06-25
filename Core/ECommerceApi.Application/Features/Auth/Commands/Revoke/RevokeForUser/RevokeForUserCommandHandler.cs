using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Features.Auth.Rules;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ECommerceApi.Application.Features.Auth.Commands.Revoke.RevokeForUser
{
    public class RevokeForUserCommandHandler : BaseHandler, IRequestHandler<RevokeForUserCommandRequest,Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;
        public RevokeForUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, AuthRules authRules)
            : base(unitOfWork, mapper, httpContextAccessor)
        {
            this.userManager = userManager;
            this.authRules = authRules;
        }

        public async Task<Unit> Handle(RevokeForUserCommandRequest request, CancellationToken cancellationToken)
        {
          User? user= await userManager.FindByEmailAsync(request.Email);
          await authRules.EmailShouldnotbeInvalidAsync(user);

            user.RefreshToken = null;
            await userManager.UpdateAsync(user);

            return Unit.Value;
        
        
        
        
        
        }
    }
}
