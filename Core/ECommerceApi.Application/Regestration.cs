using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Behaviors;
using ECommerceApi.Application.DTOs.Auth.Email;
using ECommerceApi.Application.Features.Auth.Commands.EmailConfirmation;
using ECommerceApi.Application.Features.Auth.Commands.Registration;
using ECommerceApi.Application.Features.Orders.Rules;
using ECommerceApi.Application.Features.Products.Rules;
using ECommerceApi.Application.Helper;
using ECommerceApi.Application.Interfaces.RedisCache;
using ECommerceApi.Application.Interfaces.Storage;
using ECommerceApi.Application.Middlewares.ExceptionsMiddleware;
using ECommerceApi.Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;
using System.Text.Json.Serialization;

namespace ECommerceApi.Application
{
    public static class Regestration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assemlty = Assembly.GetExecutingAssembly();
            services.AddMediatR
                (
                config => config.RegisterServicesFromAssembly(assemlty)
                );

            services.AddTransient<ExceptionMiddleware>();

            services.AddValidatorsFromAssembly(assemlty);

            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("en-US");

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehaviors<,>));

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RedisCacheBehaviors<,>));

            #region Url
            //services.AddHttpContextAccessor();

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();


            services.AddScoped<UrlFactoryHelper>();

            services.AddSingleton<EmailConfirmationCommandRequest>();
          
            #endregion

            services.AddTransient<ProductRules>();

            services.AddTransient<OrderRules>();


            services.AddTransient<SignInManager<User>>();

            services.AddRulesFromAssemblyContaining(assemlty, typeof(BaseRule));

             //services.AddControllers()
             //            .AddJsonOptions(config =>
             //                config.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
        }
        public static IServiceCollection AddRulesFromAssemblyContaining(this IServiceCollection services, Assembly assembly, Type type)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && t != type).ToList();
            foreach (var item in types)
                services.AddTransient(item);

            return services;
        }

    }
}
