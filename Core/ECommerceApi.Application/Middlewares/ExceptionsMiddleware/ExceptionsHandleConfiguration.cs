using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Middlewares.ExceptionsMiddleware
{
    public static class ExceptionsHandleConfiguration
    {
        public static void ExceptionHandleConfiguration(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
