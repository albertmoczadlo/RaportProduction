using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace RaportProduction.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}

