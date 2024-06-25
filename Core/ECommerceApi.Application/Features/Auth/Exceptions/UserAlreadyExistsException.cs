using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistsException:BaseException
    {
        public UserAlreadyExistsException(string message) : base(message) { }
    }
     
}
