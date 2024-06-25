using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Behaviors
{
    public class FluentValidationBehaviors<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;

        public FluentValidationBehaviors(IEnumerable<IValidator<TRequest>> validators)
        {
            this.validators = validators;
        }



        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);
            var failures = validators.Select(ctx => ctx.Validate(context))
                      .SelectMany(result => result.Errors)
                      .GroupBy(g => g.ErrorMessage)
                      .Select(item => item.First())
                      .Where(f => f is not null)
                      .ToList();

            if (failures.Any())
                throw new ValidationException(failures);

            return next();
        }

    }
}
