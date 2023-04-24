﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RaportProduction.Application.Common.Interfaces;
using RaportProduction.Infrastructure.Persistance;
using RaportProduction.Infrastructure.Services;

namespace RaportProduction.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            var connectionString = configuration.GetConnectionString("PackingRaportConection");

            services.AddDbContext<ApplicationDbContext>(options=>
                                 options.UseSqlServer(connectionString).EnableSensitiveDataLogging());

            services.AddSingleton<IAppSettingsService, AppSettingsService>();

            return services;
        }

        public static IApplicationBuilder UseInfrastructure(
            this IApplicationBuilder app,
            IApplicationDbContext context,
            IAppSettingsService appSettingsService
            )
        {
            appSettingsService.Update(context).GetAwaiter().GetResult();

            return app;
        }
    }
}
