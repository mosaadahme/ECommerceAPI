using ECommerceApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Transaction:EntityBase
    {
        public string PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }

        public virtual User user { get; set; }

        [ForeignKey("user")]
        public Guid userId { get; set; }

    }
}
