using ECommerceApi.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Exceptions
{
    public class TheSameUserForTheSameOrderException : BaseException
    {
        public TheSameUserForTheSameOrderException(string message):base(message)
        {
            
        }
    }
}
