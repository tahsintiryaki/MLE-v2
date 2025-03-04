using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MLE.User.Application.Interfaces.Repository;
using MLE.User.Application.Interfaces.Services;
using MLE.User.Persistence.Contexts;
using MLE.User.Persistence.Repositories;
using MLE.User.Persistence.Services;

namespace MLE.User.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection serviceCollection,
        IConfiguration configuration = null)
    {
        serviceCollection.AddDbContext<UserDbContext>(options =>
            options.UseNpgsql(configuration?.GetConnectionString("Default")));

        serviceCollection.AddTransient<IUserRepository, UserRepository>();
        serviceCollection.AddTransient<IUserService, UserService>();
    }
}