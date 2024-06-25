using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Infrastructure.Payment.PayPalPayment
{
    public class PayPalPaymentSettings
    {
        public string ClientId { get; set; }

        public string ClientSecretKey { get; set; }
        public string Mode { get; set; }

        

    }
}
