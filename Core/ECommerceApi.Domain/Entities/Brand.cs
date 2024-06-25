using ECommerceApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Brand : EntityBase
    {

        public string Name { get; set; }
        public string? Picture { get; set; }
        public virtual ICollection<Product>  products { get; set; }
        
        public Brand() { }

        public Brand(string name, string? picture)
        {
            Name = name;
            Picture = picture;
        }
    }
}
