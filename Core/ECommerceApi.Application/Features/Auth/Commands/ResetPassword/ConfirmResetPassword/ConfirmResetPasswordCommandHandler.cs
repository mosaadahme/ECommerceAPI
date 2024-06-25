using ECommerceApi.Application.Features.Auth.Rules;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.ResetPassword.ConfirmResetPassword
{
    public class ConfirmResetPasswordCommandHandler : IRequestHandler<ConfirmResetPasswordCommandRequest, Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;

        public ConfirmResetPasswordCommandHandler(UserManager<User> userManager, AuthRules authRules)
        {
            this.userManager = userManager;
            this.authRules = authRules;
        }
        public async Task<Unit> Handle(ConfirmResetPasswordCommandRequest request, CancellationToken cancellationToken)
        {
            
            User ?user=await userManager.FindByEmailAsync(request.Email);

            await authRules.UserShouldBeFoundAsync(user);

            if (user.IsCodeOfResetPasswordTrue == false)
                await authRules.NotAllowedResetPasswordBeforeConfirmAsync();

            await userManager.RemovePasswordAsync(user);

            if (!await userManager.HasPasswordAsync(user))
            {
                await userManager.AddPasswordAsync(user, request.Password);
                await userManager.UpdateAsync(user);
            }
            return Unit.Value;
        }
    }
}
