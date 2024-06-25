using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Auth.Exceptions
{
    public class NotAllowedResetPasswordBeforeConfirmException : BaseException
    {
        public NotAllowedResetPasswordBeforeConfirmException(string message) : base(message) { }
    }
}
