using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class EmailShouldnotbeInvalidException : BaseException
    {
        public EmailShouldnotbeInvalidException(string message) : base(message) { }

    }
}

