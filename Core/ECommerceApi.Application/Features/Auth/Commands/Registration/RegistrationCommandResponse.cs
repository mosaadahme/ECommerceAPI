using ECommerceApi.Application.DTOs.Auth.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.Registration
{
    public class RegistrationCommandResponse
    {
        public EmailConfirmationDTO EmailConfirmationDTO{ get; set; }
    }
}
