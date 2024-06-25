using MediatR;

namespace ECommerceApi.Application.Features.Auth.Commands.EmailConfirmation
{
    public class EmailConfirmationCommandRequest:IRequest<Unit>
    {
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
