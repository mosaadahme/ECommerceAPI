using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class NoMistakeShouldHappenWhileEmailConfirmationException : BaseException
    {
        public NoMistakeShouldHappenWhileEmailConfirmationException(string message) : base(message) { }
    }
}
