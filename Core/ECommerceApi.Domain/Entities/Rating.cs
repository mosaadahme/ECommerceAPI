using ECommerceApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Rating : EntityBase
    {
        public int Rate { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public string Comment { get; set; }

       
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
