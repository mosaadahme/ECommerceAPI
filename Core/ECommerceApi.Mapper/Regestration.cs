using ECommerceApi.Mapper.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ECommerceApi.Mapper
{
    public static class Regestration
    {
        public static void AddCustomeMapper(this IServiceCollection services)
        {
            services.AddSingleton<Application.Interfaces.AutoMapper.IMapper, AutoMapper.Mapper>();
        }
    }
}
