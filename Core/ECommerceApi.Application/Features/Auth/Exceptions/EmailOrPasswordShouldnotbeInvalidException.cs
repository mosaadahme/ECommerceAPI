using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldnotbeInvalidException : BaseException
    {
        public EmailOrPasswordShouldnotbeInvalidException(string message) : base(message) { }
    }
}
