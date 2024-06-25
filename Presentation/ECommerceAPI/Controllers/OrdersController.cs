using ECommerceApi.Application.Features.Orders.Comments.DeleteOrder;
using ECommerceApi.Application.Features.Orders.Comments.MakeOrder;
using ECommerceApi.Application.Features.Orders.Comments.UpdateOrder;
using ECommerceApi.Application.Features.Orders.Queries.GetAllOrders;
using ECommerceApi.Application.Features.Orders.Queries.GetAllOrdersForCurrentUser;
using ECommerceApi.Application.Features.Orders.Queries.GetOrderById;
using ECommerceApi.Application.Features.Products.Commands.DeleteProduct;
using ECommerceAPI.Controllers._BaseController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : BaseController
    {
        public OrdersController(IMediator mediator) : base(mediator) { }


        [HttpGet("GetAllOrders")]
        public async Task<IActionResult> GetAllOrders() => Ok(await mediator.Send(new GetAllOrdersQueryRequest()));

        //[HttpGet("GetOrderById")]
        //public async Task<IActionResult> GetOrderById(GetOrderByIdQueryRequest request) => Ok(await mediator.Send(request));



        [HttpGet("GetOrderById")]
        public async Task<IActionResult> GetOrderById([FromForm]GetOrderByIdQueryRequest request) 
        {
          var x=  await mediator.Send(request);
            return Ok(x); 
        }

        [Authorize]
        [HttpGet("GetOrdersForCurrentUser")]
        public async Task<IList<GetAllOrdersForCurrentUserQueryResponse>> GetOrdersForCurrentUser() => await mediator.Send(new GetAllOrdersForCurrentUserQueryRequest());
       


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateOrder(MakeOrderCommentRequest request)
        {
            await mediator.Send(request);
            return Created();
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateOrder(UpdateOrderCommentRequest request)
        {
            await mediator.Send(request);
            return Created();
        }

       

        [Authorize]
        [HttpDelete("DeleteOrder")]
        public async Task<IActionResult> DeleteOrder([FromForm] DeleteOrderCommendRequest request) => Ok(await mediator.Send(request));
        
    }
}
