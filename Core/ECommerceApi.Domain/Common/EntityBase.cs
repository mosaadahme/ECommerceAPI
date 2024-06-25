using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Common
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }

        public DateTime AddedOnDate { get; set; } = DateTime.Now;

        public DateTime UpdatedDate { set; get; } = new DateTime();
       
        public virtual DateTime? DeletedDate { get; set; } = new DateTime();

        public bool IsDeleted { get; set; } = false;
    }
}
