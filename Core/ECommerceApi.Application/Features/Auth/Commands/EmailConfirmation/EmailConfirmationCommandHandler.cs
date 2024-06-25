using ECommerceApi.Application.Features.Auth.Rules;
using ECommerceApi.Application.Helper;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ECommerceApi.Application.Features.Auth.Commands.EmailConfirmation
{
    public class EmailConfirmationCommandHandler : IRequestHandler<EmailConfirmationCommandRequest,Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;

        public EmailConfirmationCommandHandler(UserManager<User> userManager,AuthRules authRules)
        {
            this.userManager = userManager;
            this.authRules = authRules;
        }
        public async Task<Unit> Handle(EmailConfirmationCommandRequest request, CancellationToken cancellationToken)
        {
            User? user=await userManager.FindByEmailAsync(request.Email);
            var decodedToken = EncoderHelper.UrlDecoder(request.Token);
            var result=  await userManager.ConfirmEmailAsync(user,decodedToken);
            await authRules.EmailShouldBeConfirmedAsync(result);
            return Unit.Value;
        }
    }
}
