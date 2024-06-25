using ECommerceApi.Application.Interfaces.Mail;
using ECommerceApi.Application.Interfaces.Payment;
using ECommerceApi.Application.Interfaces.RedisCache;
using ECommerceApi.Application.Interfaces.Storage;
using ECommerceApi.Application.Interfaces.Tokens;
using ECommerceApi.Infrastructure.Mail;
using ECommerceApi.Infrastructure.Payment.PayPalPayment;
using ECommerceApi.Infrastructure.Payment.StripePayment;
using ECommerceApi.Infrastructure.RedisCache;
using ECommerceApi.Infrastructure.Storage;
using ECommerceApi.Infrastructure.Tokens;
using ECommerceApi.Persistence.Context;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ECommerceApi.Infrastructure
{
    public static class Regestration
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<TokenSettings>(configuration.GetSection("JWT"));
            services.AddTransient<ITokenService, TokenService>();
            services.Configure<MailSettings>(configuration.GetSection("Smtp"));
            services.AddTransient<IRedisCacheService, RedisCacheService>();
            services.AddScoped<ILocalStorage, LocalStorage>();
            services.AddScoped<IMailService, MailService>();
            services.Configure<RedisCacheSettings>(configuration.GetSection("RedisCacheSettings"));
            services.AddScoped<IPaymentService, StripePaymentService>();
           // services.AddScoped<IPaymentService, PayPalPaymentService>();
            



            #region Hangfire
            // Configure Hangfire
            services.AddHangfire(config =>
            {
                config.UseSqlServerStorage(configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
                {
                    PrepareSchemaIfNecessary = true,
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    DisableGlobalLocks = true
                })
                .WithJobExpirationTimeout(TimeSpan.FromDays(7));
            });

            services.AddHangfireServer(options =>
            {
                options.WorkerCount = 5; 
            });
            #endregion

            #region Authentication
            services.AddAuthentication
                (
                opt =>
                {
                    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }
                ).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,
                opt =>
                {
                    opt.SaveToken = true;
                    opt.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = false,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecretKey"])),
                        ValidIssuer = configuration["JWT:Issuer"],
                        ValidAudience = configuration["JWT:Audience"],
                        ClockSkew = TimeSpan.Zero
                    };
                }
                );
            #endregion

            #region Redis
            services.AddStackExchangeRedisCache
                (
                opt =>
                {
                    opt.Configuration = configuration["RedisCacheSettings:ConnectionString"];
                    opt.InstanceName = configuration["RedisCacheSettings:InstanceName"];

                }
                );
            #endregion
        }
    }
}
