using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Helper
{
    public class UrlFactoryHelper
        //:UrlFactoryHelper
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IActionContextAccessor actionContextAccessor;
        private readonly IUrlHelperFactory urlHelperFactory;

        public UrlFactoryHelper(IHttpContextAccessor httpContextAccessor,IActionContextAccessor actionContextAccessor,IUrlHelperFactory urlHelperFactory)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.actionContextAccessor = actionContextAccessor;
            this.urlHelperFactory = urlHelperFactory;
        }

        public IUrlHelper CreateUrlHelper()
        {
            var actionContext= actionContextAccessor.ActionContext;
            return urlHelperFactory.GetUrlHelper(actionContext);
        }

        //public IUrlHelper GetUrlHelper(ActionContext context)
        //{
        //    var actionContext = context.HttpContext;
        //    return urlHelperFactory.GetUrlHelper(actionContextAccessor.ActionContext);
        //}
    }
}
