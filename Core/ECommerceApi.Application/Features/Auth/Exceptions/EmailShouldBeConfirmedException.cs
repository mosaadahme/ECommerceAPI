using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class EmailShouldBeConfirmedException : BaseException
    {
        public EmailShouldBeConfirmedException(string message) : base(message) { }
    }
    
}
