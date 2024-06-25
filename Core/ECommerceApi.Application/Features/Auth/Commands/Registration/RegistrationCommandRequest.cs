using ECommerceApi.Application.DTOs.Auth.Email;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Commands.Registration
{
    public class RegistrationCommandRequest:IRequest<Unit>
    {
        [DefaultValue("Enter Your Name")]
        public string FullName { get; set; }
        
        
        
        [DefaultValue("Enter Your Email")]
        public string Email { get; set; }
        
        
        [DefaultValue("Enter Your Password")]
        public string Password { get; set; }

        
        [DefaultValue("Enter the same password for confirm")]
        public string ConfirmPassword { get; set; }


        [DefaultValue("Enter Your photo")]
        public IFormFile Image { get; set; }

    }
}
