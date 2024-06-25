using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Bases
{
    public class BaseHandler
    {
        public IUnitOfWork UnitOfWork { get; }
        public IMapper Mapper { get; }
        public IHttpContextAccessor HttpContextAccessor { get; }
        public string UserId { get; set; }

        public BaseHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
            HttpContextAccessor = httpContextAccessor;
            UserId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }


    }
}
