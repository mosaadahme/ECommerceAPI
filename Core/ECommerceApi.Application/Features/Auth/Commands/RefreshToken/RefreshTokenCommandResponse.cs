using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.RefreshToken
{
    public class RefreshTokenCommandResponse
    {
         public string AccessToken { get; set; }


         public string RefreshToken { get; set; }
    }
}
