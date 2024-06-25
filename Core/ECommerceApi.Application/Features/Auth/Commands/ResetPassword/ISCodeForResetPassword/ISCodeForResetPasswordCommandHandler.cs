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

namespace ECommerceApi.Application.Features.Auth.Commands.ResetPassword.ISCodeForResetPassword
{
    public class ISCodeForResetPasswordCommandHandler :IRequestHandler<ISCodeForResetPasswordCommandRequest, Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;

        public ISCodeForResetPasswordCommandHandler(UserManager<User> userManager,AuthRules authRules) 
            
        {
            this.userManager = userManager;
            this.authRules = authRules;
        }

        public async Task<Unit> Handle(ISCodeForResetPasswordCommandRequest request, CancellationToken cancellationToken)
        {
            User ? user= await userManager.FindByEmailAsync(request.Email);

            await authRules.UserShouldBeFoundAsync(user);

            if (request.CodeOfConfirm != user.CodeForResetPassword) 
            {
                user.IsCodeOfResetPasswordTrue = false;
               await  authRules.BothOfCodeShouldBeIdenticalAsync();
            }

            
            user.IsCodeOfResetPasswordTrue=true;
            
            await userManager.UpdateAsync(user);

            return Unit.Value;
        }
    }
}
