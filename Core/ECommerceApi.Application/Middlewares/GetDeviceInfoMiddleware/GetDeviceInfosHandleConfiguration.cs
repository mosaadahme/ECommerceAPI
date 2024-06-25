using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Middlewares.GetDeviceInfoMiddleware
{
    public static class GetDeviceInfosHandleConfiguration
    {
        public static void GetDeviceInfoHandleConfiguration(this IApplicationBuilder applicationBuilder) 
        {

            applicationBuilder.UseMiddleware<GetDeviceInfoMiddleware>();
        }
    }
}
