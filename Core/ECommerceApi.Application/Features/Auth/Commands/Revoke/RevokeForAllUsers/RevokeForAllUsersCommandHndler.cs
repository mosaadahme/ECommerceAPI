using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Features.Auth.Rules;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ECommerceApi.Application.Features.Auth.Commands.Revoke.RevokeForAllUsers
{
    public class RevokeForAllUsersCommandHndler : BaseHandler, IRequestHandler<RevokeForAllUsersCommandRequest, Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;
        public RevokeForAllUsersCommandHndler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, AuthRules authRules)
            : base(unitOfWork, mapper, httpContextAccessor)
        {
            this.userManager = userManager;
            this.authRules = authRules;
        }

        public async Task<Unit> Handle(RevokeForAllUsersCommandRequest request, CancellationToken cancellationToken)
        {
           IList<User> users=  await userManager.Users.ToListAsync(cancellationToken);

            foreach (User user in users)
            {
                user.RefreshToken = null;
                await userManager.UpdateAsync(user);
            }
            return Unit.Value;
        }
    }
}
