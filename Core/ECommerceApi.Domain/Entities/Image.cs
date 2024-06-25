using ECommerceApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Image:EntityBase
    {
        public string FileName { get; set; }
        public string Path { get; set; }

        public int ProductId { get; set; }

        public virtual Product  Product { get; set; }

    }
}
