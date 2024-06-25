using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Comments.DeleteOrder
{
    public class DeleteOrderCommendRequest:IRequest<Unit>
    {
        public int Id { get; set; }

    }
}
