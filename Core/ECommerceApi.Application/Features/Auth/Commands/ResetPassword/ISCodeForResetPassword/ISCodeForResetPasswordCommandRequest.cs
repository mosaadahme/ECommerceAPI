using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.ResetPassword.ISCodeForResetPassword
{
    public class ISCodeForResetPasswordCommandRequest:IRequest<Unit>
    {
        public string Email { get; set; }

        public string CodeOfConfirm { get; set; }
    }
}
