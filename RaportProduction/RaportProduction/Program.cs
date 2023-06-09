
using AspNetCore.ReCaptcha;
using NLog.Web;
using RaportProduction.Application;
using RaportProduction.Application.Common.Interfaces;
using RaportProduction.Infrastructure;
using RaportProduction.UI.Extensions;
using RaportProduction.UI.Middlewares;
using System.Globalization;

namespace RaportProduction;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Logging
            .ClearProviders();
        builder.Logging
            .SetMinimumLevel(LogLevel.Information);
        builder.Logging
            .AddNLogWeb();
        builder.Services
            .AddCulture();
        builder.Services
            .AddReCaptcha(builder.Configuration.GetSection("ReCaptcha"));
        builder.Services
            .AddApplication();
        builder.Services
            .AddInfrastructure(builder.Configuration);
        builder.Services
            .DefineViewLocation(builder.Configuration);

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            app.UseInfrastructure(
                scope.ServiceProvider.GetRequiredService<IApplicationDbContext>(),
                app.Services.GetService<IAppSettingsService>(),
                app.Services.GetService<IEmail>());
        }

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");

            app.UseHsts();
        }

        app.UseMiddleware<ExceptionHandlerMiddleware>();

        var logger = app.Services.GetService<ILogger<Program>>();

        if (app.Environment.IsDevelopment())
        {
            logger.LogInformation("Development mode");
        }
        else
        {
            logger.LogInformation("Production mode!!!");
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");


        app.Run();
    }
}