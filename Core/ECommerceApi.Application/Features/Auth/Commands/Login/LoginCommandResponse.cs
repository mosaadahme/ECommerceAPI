using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.Login
{
    public class LoginCommandResponse
    {
        public string Token { get; set; }

        public string RefreshToken { get; set; }

        public DateTime Expiration { get; set; }

    }
}
