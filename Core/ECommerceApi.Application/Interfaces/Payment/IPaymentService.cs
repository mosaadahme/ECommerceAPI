using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Interfaces.Payment
{
    public interface IPaymentService
    {

        Task<string> CreatePaymentAsync(decimal amount,string currency,string description);

        Task<bool> CapturePaymentAsync(string paymentId);


       

    }
}
