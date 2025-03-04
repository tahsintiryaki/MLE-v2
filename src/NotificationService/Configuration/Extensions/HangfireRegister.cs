using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NotificationService.Configuration.Extensions;

public static class HangfireRegister

{
    public static void UseHangfire(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHangfire(x => x.UsePostgreSqlStorage(configuration.GetConnectionString("MLEHangfireDb")));

        services.AddHangfireServer(x => x.ServerName = $"{Environment.MachineName}.{Guid.NewGuid().ToString()}");
    }

    public static void SetJobs(IConfiguration configuration)
    {
        
    }
    
}