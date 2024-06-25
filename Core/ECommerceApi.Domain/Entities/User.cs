using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; }
      
        public string? Picture { get; set; }
        
        public string? RefreshToken { get; set; }

        public DateTime? RefreshTokenExpiryTime { get; set; }

        public string? CodeForResetPassword { get; set; }

        public DateTime? TimeOfCodeExpiration { get; set; }


        public bool? IsCodeOfResetPasswordTrue { get; set; }


        public virtual ICollection<Transaction> transactions { get; set; }

    }
}
