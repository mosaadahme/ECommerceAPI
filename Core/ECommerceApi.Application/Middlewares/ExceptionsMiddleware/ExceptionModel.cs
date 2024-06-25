using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Middlewares.ExceptionsMiddleware
{
    public class ExceptionModel : ErrorStatusCode
    {
        public IEnumerable<string> errors { set; get; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class ErrorStatusCode
    {
        public int StatusCode { get; set; }
    }
}
