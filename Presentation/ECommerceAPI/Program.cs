using ECommerceApi.Application;
using ECommerceApi.Mapper;
using ECommerceApi.Persistence;
using ECommerceApi.Infrastructure;
using Microsoft.OpenApi.Models;
using Hangfire;
using ECommerceApi.Infrastructure.ScheduleServices;
using System.Text.Json.Serialization;
 using ECommerceApi.Application.Middlewares.ExceptionsMiddleware;
using ECommerceApi.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;


namespace ECommerceApi.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            #region Custome Configuration

            builder.Services.AddCors();
            builder.Services.AddInfrastructure(builder.Configuration);
            builder.Services.AddPersistence(builder.Configuration);
            builder.Services.AddApplication();
            builder.Services.AddCustomeMapper();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.AddControllers()
                .AddJsonOptions(config =>
                    config.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

            #endregion

            #region Swagger Configuration

            builder.Services.AddSwaggerGen(c =>
            {
                c.UseInlineDefinitionsForEnums();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ECommerce API", Version = "v1", Description = "ECommerce API swagger client." });

                // Adding Bearer token authentication
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "'You can type 'Bearer' and enter the token after leaving a space \r\n\r\n For example: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\""
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
                 
            });

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.MapControllers();

             

            using (var scope = app.Services.CreateScope())
            {
                var recurringJobManager = scope.ServiceProvider.GetRequiredService<IRecurringJobManager>();
                recurringJobManager.AddOrUpdate<CheckTimeOfSendingUsersCodeScheduleService>(
                    "CheckUserCodesJob",  
                    service => service.CheckTimeOfSendingUsersAsync(),
                    "*/5 * * * *",  
                    new RecurringJobOptions { TimeZone = TimeZoneInfo.Local }
                );
            }

            app.ExceptionHandleConfiguration();
            app.Run();
        }
    }

  }
