using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Helper
{
    public static class EncoderHelper
    {
        public static string UrlEncoder(this string value) 
        {
            byte[] data= Encoding.UTF8.GetBytes(value);
           return WebEncoders.Base64UrlEncode(data);
        }
        public static string UrlDecoder(this string value)
        {
             var data =  WebEncoders.Base64UrlDecode(value);
            return Encoding.UTF8.GetString(data);
           
        }
    }
}
