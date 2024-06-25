using ECommerceApi.Application.Middlewares;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Middlewares.ExceptionsMiddleware
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception ex)
            {

                await handleExceptionAsync(httpContext, ex);
            }
        
        }


        private static Task handleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            httpContext.Response.ContentType = "application/json";

            int statusCode = getStatusCode(exception);

            httpContext.Response.StatusCode = statusCode;

            if (typeof(Exception) == typeof(ValidationException))
            {
                httpContext.Response.WriteAsync(new ExceptionModel
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    errors = ((ValidationException)exception).Errors.Select(msg => msg.ErrorMessage)
                }
            .ToString()
             );
            }
            List<string> errors = new()
            {
                    $"Message is : {exception?.Message}",
                    $"Source is  : {exception?.InnerException}",
                    $"Source is  : {exception?.Source}"
             };



            return httpContext.Response.WriteAsync(new ExceptionModel
            {
                StatusCode = statusCode,
                errors = errors
            }
               .ToString()
               );
        }



        private static int getStatusCode(Exception exception) =>
            exception switch
            {
                BadRequestException => StatusCodes.Status400BadRequest,
                NotFoundException => StatusCodes.Status400BadRequest,
                ValidationException => StatusCodes.Status422UnprocessableEntity,
                _ => StatusCodes.Status500InternalServerError
            };

    }
}
