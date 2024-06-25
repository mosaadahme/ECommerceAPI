using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.RefreshToken
{
    public class RefreshTokenCommandRequest:IRequest<RefreshTokenCommandResponse>
    {
        [DefaultValue("Enter AccessToken")]
        public string AccessToken { get; set; }


        [DefaultValue("Enter RefreshToken")]
        public string RefreshToken { get; set; }
    }
}
