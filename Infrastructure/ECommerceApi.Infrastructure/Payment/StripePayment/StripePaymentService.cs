 using ECommerceApi.Application.Interfaces.Payment;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Infrastructure.Payment.StripePayment
{
    public class StripePaymentService : IPaymentService
    {
       // private readonly StripePaymentSettings stripePaymentSettings;
        public StripePaymentService(IConfiguration configuration)
        {
            StripeConfiguration.ApiKey = configuration["stripePaymentSettings:SecretKey"];
              
        }

        public IConfiguration Configuration { get; }

        public async Task<bool> CapturePaymentAsync(string paymentId)
        {
            var returnedPayment= await new PaymentIntentService().CaptureAsync(paymentId);
           
            return returnedPayment.Status == "succeeded";
        }

        public async Task<string> CreatePaymentAsync(decimal amount, string currency, string description)
        {
            if (!CurrencyValidator.IsValidCurrency(currency))
            {
                throw new ArgumentException($"Invalid currency: {currency}. Please provide a valid currency.");
            }

            var paymentDetails = new PaymentIntentCreateOptions()
            {
                Amount = (long)(amount * 100),
                Currency = currency,
                Description = description,
                PaymentMethodTypes = new List<string> { "card" }
           };
             

           var returnedPayment =await new PaymentIntentService().CreateAsync(paymentDetails);

            return returnedPayment.Id;

        }
    }
}
