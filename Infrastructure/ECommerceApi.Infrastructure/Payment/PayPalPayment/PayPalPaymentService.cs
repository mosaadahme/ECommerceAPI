using ECommerceApi.Application.Interfaces.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Infrastructure.Payment.PayPalPayment
{
    public class PayPalPaymentService //: IPaymentService
    {


        public Task<bool> CapturePaymentAsync(string paymentId)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreatePaymentAsync(decimal amount, string currency, string description)
        {

            throw new NotImplementedException();
        }
    }
}
