using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Auth.Queries.GetAllUsers
{
    public class GetAllUsersQueryResponse
    {
        public Guid UserId { get; set; }

        public string Email{ get; set; }

        public DateTime? TimeOfCodeExpiration { get; set; }


    }
}
