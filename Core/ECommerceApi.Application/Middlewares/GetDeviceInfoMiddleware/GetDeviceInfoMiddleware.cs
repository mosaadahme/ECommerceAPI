using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Middlewares.GetDeviceInfoMiddleware
{
    public class GetDeviceInfoMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            

            var deviceInfo = new GetDeviceInfoModel
            {
                IpAddress = context.Connection.RemoteIpAddress?.ToString(),
                Browser = context.Request.Headers["User-Device-Info"].ToString(),
                DeviceType = getDeviceType(context.Request.Headers["User-Device-Info"].ToString()),
                LoggedInAt = DateTime.UtcNow
            };

            context.Items["DeviceInfo"] = deviceInfo;

            await next(context);
        }


        private string getDeviceType(string text) => text  switch 
        {
           string Info when Info.Contains("Mobile", StringComparison.OrdinalIgnoreCase) => "Mobile",
           string Info when Info.Contains("Tablet", StringComparison.OrdinalIgnoreCase) => "Tablet",
            _=> "Desktop"
        };
       
        
    }
}
