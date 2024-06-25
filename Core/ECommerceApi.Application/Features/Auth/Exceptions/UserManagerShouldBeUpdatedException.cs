using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class UserManagerShouldBeUpdatedException : BaseException
    {
        public UserManagerShouldBeUpdatedException(string message) : base(message) { }
    }
}
