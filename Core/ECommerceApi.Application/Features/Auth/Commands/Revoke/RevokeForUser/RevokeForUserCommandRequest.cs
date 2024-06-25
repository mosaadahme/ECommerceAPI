using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.Revoke.RevokeForUser
{
    public class RevokeForUserCommandRequest:IRequest<Unit>
    {
        [DefaultValue("Your Email")]
        public string Email { get; set; }

    }
}
