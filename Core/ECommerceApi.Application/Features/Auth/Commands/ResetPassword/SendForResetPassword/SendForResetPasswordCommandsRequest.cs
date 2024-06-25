using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.ResetPassword.SendForResetPassword
{
    public class SendForResetPasswordCommandsRequest:IRequest<Unit>
    {
        public string Email { get; set;}
    }
}
