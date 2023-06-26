using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using RaportProduction.Application.Common.Behaviours;
using FluentValidation;

namespace RaportProduction.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof
            (LoggingBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof
            (PerformanceBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof
            (ValidationBehaviour<,>));

        return services;
    }
}

