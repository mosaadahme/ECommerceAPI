using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.DTOs
{
    public class MakeOrderDTO
    {
        public int ProductId { get; set; }

        public int ProductCount { get; set; }
    }
}
