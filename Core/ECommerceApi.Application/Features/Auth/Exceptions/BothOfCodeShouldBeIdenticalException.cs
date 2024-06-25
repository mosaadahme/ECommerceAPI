using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class BothOfCodeShouldBeIdenticalException : BaseException
    {
        public BothOfCodeShouldBeIdenticalException(string message) : base(message) { }
    }
}
