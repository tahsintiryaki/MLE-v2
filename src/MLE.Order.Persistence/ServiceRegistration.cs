using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MLE.Order.Application.Dtos;
using MLE.Order.Application.Interfaces.Repository;
using MLE.Order.Application.Interfaces.Services;
using MLE.Order.Persistence.Contexts;
using MLE.Order.Persistence.Repositories;
using MLE.Order.Persistence.Services;

namespace MLE.Order.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceService(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDbContext<OrderDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("Default")));

        serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
        serviceCollection.AddScoped<IOrderService, OrderService>();
    }
}