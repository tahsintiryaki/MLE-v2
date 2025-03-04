using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MLE.Product.Application.Interfaces.Repositories;
using MLE.Product.Application.Interfaces.Services;
using MLE.Product.Persistence.Contexts;
using MLE.Product.Persistence.Repositories;
using MLE.Product.Persistence.Services;
using MongoDB.Driver;

namespace MLE.Product.Persistence;

public static class ServiceRegistration
{
    public static IServiceCollection ConfigureMongoDb(this IServiceCollection services, IConfiguration configuration)
    {
        // appsettings.json içindeki MongoDbSettings bölümünü otomatik olarak bağlar.
        services.Configure<MongoDbSettings>(options =>
            configuration.GetSection("MongoDbSettings").Bind(options));


        // Singleton olarak MongoDbSettings enjekte edilir.
        services.AddSingleton<IMongoDbSettings>(sp =>
            sp.GetRequiredService<IOptions<MongoDbSettings>>().Value);

        // MongoDB Client'ı ve Database bağlamını oluşturur.
        services.AddSingleton<IMongoClient>(sp =>
        {
            var settings = sp.GetRequiredService<IMongoDbSettings>();
            return new MongoClient(settings.ConnectionString);
        });

        services.AddSingleton<IMongoDatabase>(sp =>
        {
            var settings = sp.GetRequiredService<IMongoDbSettings>();
            var client = sp.GetRequiredService<IMongoClient>();
            return client.GetDatabase(settings.DatabaseName);
        });

        return services;
    }

    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddTransient<IProductService, ProductService>();
    }
  
}