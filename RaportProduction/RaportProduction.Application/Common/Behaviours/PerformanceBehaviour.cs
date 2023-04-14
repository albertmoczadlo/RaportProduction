using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace RaportProduction.Application.Common.Behaviours;

public class PerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly ILogger _logger;
    private readonly Stopwatch _timer;

    public PerformanceBehaviour(ILogger<TRequest> logger)
    {
        _timer = new Stopwatch();
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken,
        RequestHandlerDelegate<TResponse> next)
    {
        _timer.Start();

        var response = await next();

        _timer.Stop();

        var elapsedMilliseconds = _timer.ElapsedMilliseconds;

        if(elapsedMilliseconds > 500)
        {
            _logger.LogInformation("RaportProduction Long running request: {@Name} {@ElapsedMiliseconds} milliseconds) {@Request}",
                typeof(TRequest).Name, elapsedMilliseconds, request);

        }

        return response;

    }
}
