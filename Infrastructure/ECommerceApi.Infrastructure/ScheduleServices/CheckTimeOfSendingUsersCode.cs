using ECommerceApi.Application.Features.Auth.Queries.GetAllUsers;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Domain.Entities;
using Hangfire;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Infrastructure.ScheduleServices
{
    public class CheckTimeOfSendingUsersCodeScheduleService
    {
        private readonly IServiceScopeFactory serviceScopeFactory;
        public CheckTimeOfSendingUsersCodeScheduleService(IServiceScopeFactory serviceScopeFactory)
        {
            this.serviceScopeFactory = serviceScopeFactory;
           
        }

        //[AutomaticRetry(Attempts = 3)]
        public async Task CheckTimeOfSendingUsersAsync() 
        {
            using (var resource = serviceScopeFactory.CreateScope())
            {
                IMediator mediatR = resource.ServiceProvider.GetRequiredService<IMediator>();

                var userManager = resource.ServiceProvider.GetRequiredService<UserManager<User>>();

                var mapper = resource.ServiceProvider.GetRequiredService<IMapper>();

                Task<IList<GetAllUsersQueryResponse>> getAllUsersQueryResponsesTask = mediatR.Send(new GetAllUsersQueryRequest());

                IList<GetAllUsersQueryResponse> GetAllUsersQueryResponse = await getAllUsersQueryResponsesTask;

                List<User> users = GetAllUsersQueryResponse.Select(x=>new User(){Id=x.UserId,Email=x.Email,TimeOfCodeExpiration=x.TimeOfCodeExpiration}).ToList();

                foreach (var user 
                    
                    
                    in users)
                {
                    if (user.TimeOfCodeExpiration < DateTime.UtcNow)
                    {
                       User _user= await userManager.FindByEmailAsync(user.Email);
                        _user.CodeForResetPassword = null;
                        _user.IsCodeOfResetPasswordTrue = null;
                        _user.TimeOfCodeExpiration = null;
                        await userManager.UpdateAsync(_user);
                    }
                }
            }
        }

    }
}


       
 
              
            
        #region quartz
        //protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        //{
        //    while (!stoppingToken.IsCancellationRequested) 
        //    {
        //        using (var resource=serviceScopeFactory.CreateScope())
        //        {
        //            IMediator mediatR  = resource.ServiceProvider.GetRequiredService<IMediator>();

        //            var userManager = resource.ServiceProvider.GetRequiredService<UserManager<User>>();

        //            var mapper = resource.ServiceProvider.GetRequiredService<IMapper>();


        //            Task<IList<GetAllUsersQueryResponse>> getAllUsersQueryResponsesTask = mediatR.Send(new GetAllUsersQueryRequest());

        //            IList<GetAllUsersQueryResponse> GetAllUsersQueryResponse = await getAllUsersQueryResponsesTask;

        //            List<User> users= mapper.Map<User,GetAllUsersQueryResponse>(GetAllUsersQueryResponse).ToList();

        //            foreach (var user in users)
        //            {
        //                if (user.TimeOfCodeExpiration < DateTime.UtcNow)
        //                {
        //                    user.CodeForResetPassword = null;
        //                    user.IsCodeOfResetPasswordTrue = null;
        //                    user.TimeOfCodeExpiration = null;
        //                    await userManager.UpdateAsync(user);
        //                }
                         
        //            }

        //            await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);

        //        }

        //    }
        //}
        #endregion
    