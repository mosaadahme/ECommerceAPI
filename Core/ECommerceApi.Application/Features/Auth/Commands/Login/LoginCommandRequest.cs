using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.Login
{
    public record LoginCommandRequest:IRequest<LoginCommandResponse>
    {

        [DefaultValue("Enter Your Email")]
        public string Email { get; set; }



        [DefaultValue("Enter Your Password")]
        public string Password { get; set; }
    }
}
