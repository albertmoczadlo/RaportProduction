using FluentValidation;
using MediatR;

namespace RaportProduction.Application.Common.Behaviours;

public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validator;

    public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validator)
    {
        _validator = validator;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken,
        RequestHandlerDelegate<TResponse> next)
    {

        return await next();

    }
}

