using ECommerceApi.Application.Bases;
using ECommerceApi.Application.DTOs;
using ECommerceApi.Application.DTOs.Auth.Email;
using ECommerceApi.Application.Features.Auth.Commands.EmailConfirmation;
using ECommerceApi.Application.Features.Auth.Rules;
using ECommerceApi.Application.Helper;
using ECommerceApi.Application.Interfaces.AutoMapper;
using ECommerceApi.Application.Interfaces.Mail;
using ECommerceApi.Application.Interfaces.Storage;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.IdentityModel.Tokens;

using EncoderHelper = ECommerceApi.Application.Helper.EncoderHelper;


namespace ECommerceApi.Application.Features.Auth.Commands.Registration
{
    public class RegistrationCommandHandler :BaseHandler, IRequestHandler<RegistrationCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IMailService mailService;
        private readonly UrlFactoryHelper urlFactoryHelper;
        private readonly EmailConfirmationCommandRequest emailConfirmationCommandRequest ;
        private readonly ILocalStorage localStorage;

        public UserManager<User> UserManager { get; }
        public RoleManager<Role> RoleManager { get; }
        public AuthRules AuthRules { get; }

        public RegistrationCommandHandler(IUnitOfWork unitOfWork,
                                          IMapper mapper,
                                          IHttpContextAccessor httpContextAccessor,
                                          UserManager<User> userManager,
                                          RoleManager<Role> roleManager,
                                          AuthRules authRules,
                                          IMailService mailService,
                                          UrlFactoryHelper urlFactoryHelper,
                                          EmailConfirmationCommandRequest emailConfirmationCommandRequest,
                                          ILocalStorage localStorage) 
                    : base(unitOfWork, mapper, httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            UserManager = userManager;
            RoleManager = roleManager;
            AuthRules = authRules;
            this.mailService = mailService;
            this.urlFactoryHelper = urlFactoryHelper;
            this.emailConfirmationCommandRequest = emailConfirmationCommandRequest;
            this.localStorage = localStorage;
        }



        public async Task<Unit> Handle(RegistrationCommandRequest request, CancellationToken cancellationToken)
        {
            await AuthRules.UserShouldnotBeExistsAsync(await UserManager.FindByEmailAsync(request.Email));
            User user = Mapper.Map<User,RegistrationCommandRequest>(request);
            user.UserName=request.Email;
            user.SecurityStamp=Guid.NewGuid().ToString();
            IdentityResult result = await UserManager.CreateAsync(user, request.Password);
            bool isSent = await EmailConfirmationDTOAsync(user);
            if (!isSent)
            {
                await UserManager.DeleteAsync(user);
                await UserManager.UpdateAsync(user);
                await AuthRules.NoMistakeShouldHappenWhileEmailConfirmationAsync(isSent);

            }
            if (result.Succeeded)
            {
                if (!await RoleManager.RoleExistsAsync("user"))
                {
                    await RoleManager.CreateAsync
                        (
                        new Role 
                        {
                            Id=Guid.NewGuid(),
                            Name="user",
                            NormalizedName="USER",
                            ConcurrencyStamp=Guid.NewGuid().ToString(),
                        }
                        );

                }
                if (request.Image is not null)
                {
                    var photo = await localStorage.UploadAsync(1, "Users", request.Image);
                    user.Picture = photo.Path;
                    await UserManager.UpdateAsync(user);
                }
            }
          
            return Unit.Value;
         }
      


        private async Task<bool> EmailConfirmationDTOAsync(User user) 
        {
          var token =  await UserManager.GenerateEmailConfirmationTokenAsync(user);
          var encodedToken= EncoderHelper.UrlEncoder(token);

            emailConfirmationCommandRequest.Email = user.Email;
            emailConfirmationCommandRequest.Token = encodedToken;

             var request = httpContextAccessor.HttpContext.Request;
            
            IUrlHelper?  urlHelper = urlFactoryHelper.CreateUrlHelper();

            
            var _UrlHelper = urlHelper.Action(action: "EmailConfirmation", controller:"Auth",values: emailConfirmationCommandRequest
                                             , protocol:request.Scheme,host:request.Host.ToString());
            if (_UrlHelper.IsNullOrEmpty())
            {
                return false;
            }
            #region Html body
            string emailBody = Message(user.FullName,_UrlHelper);
            #endregion


            await mailService.SendMessageAsync(user.Email, "Email Activation", emailBody);
            return true;
        }


        private string Message(string name,string confirmationLink) 
        {
            #region Html body
            string emailBody = $@"
        <html>
        <body style='font-family: Arial, sans-serif; color: #333;'>
            <div style='max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ddd; border-radius: 10px;'>
                <div style='text-align: center;'>
                    <img src='https://yourcompanylogo.com/logo.png' alt='Your Company' style='width: 150px; margin-bottom: 20px;'/>
                </div>
                <h2 style='color: #007BFF;'>Hello {name},</h2>
                <p>Thank you for registering with us! To complete your registration, please confirm your email address by clicking the button below:</p>
                <div style='text-align: center; margin: 30px 0;'>
                    <a href='{confirmationLink}' style='background-color: #007BFF; color: #fff; padding: 10px 20px; text-decoration: none; border-radius: 5px;'>Confirm Email</a>
                </div>
                <p>If the button above does not work, please copy and paste the following link into your web browser:</p>
                <p><a href='{confirmationLink}' style='color: #007BFF;'>{confirmationLink}</a></p>
                <p>If you did not create an account, no further action is required.</p>
                <p>Best regards,<br/>The Your Company Team</p>
                <div style='text-align: center; margin-top: 20px;'>
                    <a href='https://www.yourcompany.com' style='color: #007BFF;'>Visit our website</a> | <a href='https://www.yourcompany.com/contact' style='color: #007BFF;'>Contact Support</a>
                </div>
            </div>
        </body>
        </html>";
            #endregion
            return emailBody;
        }
    }
}


#region comment
// var confirmationUrl = @$"https://localhost:44329/api/Test/GetData";
//?email={user.Email}&token={EncodedToken}

// var confirmationUrl = HttpContextAccessor.HttpContext.Request.Scheme + "://" +
//   HttpContextAccessor.HttpContext.Request.Host;
//-----------------------------------------------------
//action: "GetData",
//             controller: "Test",
//             protocol: request.Scheme,
//             host: request.Host
//    //values: new EmailConfirmationDTO() { Email = user.Email, Token = EncodedToken }
#endregion