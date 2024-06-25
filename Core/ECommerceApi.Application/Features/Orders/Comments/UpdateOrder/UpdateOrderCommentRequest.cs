using ECommerceApi.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Comments.UpdateOrder
{
    public class UpdateOrderCommentRequest:IRequest<Unit>
    {
        public int Id { get; set; }

        public IList<MakeOrderDTO> makeOrderDTOs { get; set; }

    }
}
