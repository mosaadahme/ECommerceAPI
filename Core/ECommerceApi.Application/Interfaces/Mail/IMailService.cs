using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Interfaces.Mail
{
    public interface IMailService
    {
        Task SendMessageAsync(string to,string subject,string body,IFormFileCollection ?files=null);

        Task SendMessageAsync(IList<string> tos, string subject, string body, IFormFileCollection? files = null);

    }
}

