using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class UserShouldBeFoundException : BaseException
    {
        public UserShouldBeFoundException(string message) : base(message) { }
    }
}
