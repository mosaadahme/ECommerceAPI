using ECommerceApi.Application.Bases;

namespace ECommerceApi.Application.Features.Orders.Exceptions
{
    public class TheOrderShouldBeExistException : BaseException
    {
        public TheOrderShouldBeExistException(string message) : base(message)
        {

        }
    }
}
