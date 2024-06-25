using ECommerceApi.Application.Features.Auth.Commands.Login;
using ECommerceApi.Application.Features.Auth.Commands.Registration;
using ECommerceApi.Application.Features.Orders.Comments.MakeOrder;
using ECommerceApi.Application.Features.Products.Commands.CreateProduct;
using ECommerceApi.Application.Features.Products.Queries.GetAllProducts;
using ECommerceApi.Application.Features.Products.Queries.GetProductById;
using ECommerceApi.Application.Features.Products.Queries.GetProductsFilteration;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ECommerceAPI.Controllers._BaseController
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public readonly IMediator mediator;


        public BaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }

    }
}
