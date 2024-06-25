using ECommerceApi.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Orders.Comments.MakeOrder
{
    public class MakeOrderCommentRequest:IRequest<Unit>

    {
        public IList<MakeOrderDTO> makeOrderDTOs { get; set; }

    }
}
