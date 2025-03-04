using Hangfire;
using Serilog;
using Hangfire.Dashboard.BasicAuthorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MLE.IntegrationHandler.Configuration;
using NotificationService.Configuration.Extensions;

try
{
    var builder = WebApplication.CreateBuilder(args);
 

    builder.Configuration
        .AddJsonFile("Configuration/Settings/appsettings.json", optional: true, reloadOnChange: true)
        .AddJsonFile($"Configuration/Settings/appsettings.{builder.Environment.EnvironmentName}.json",
            optional: true,
            reloadOnChange: true)
        .AddEnvironmentVariables();
    var mess = builder.Configuration["MessagingQueue:Uri"];
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services
        .UseIntegrationHandler(builder.Configuration)
        .UseHangfire(builder.Configuration);

    var app = builder.Build();

    var options = new DashboardOptions
    {
        Authorization =
        [
            new BasicAuthAuthorizationFilter(
                new BasicAuthAuthorizationFilterOptions
                {
                    RequireSsl = false,
                    SslRedirect = false,
                    LoginCaseSensitive = true,
                    Users =
                    [
                        new BasicAuthAuthorizationUser
                        {
                            Login = "Loodos",
                            PasswordClear = "Loodos123!"
                        }
                    ]
                })
        ]
    };

    app.UseHangfireDashboard("/hangfire", options);
    HangfireRegister.SetJobs(builder.Configuration);

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Error while Hosting Services {0}", ex);
    Log.Fatal("Error while Hosting Services {0}", ex);
}