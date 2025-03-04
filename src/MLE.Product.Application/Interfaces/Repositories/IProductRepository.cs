namespace MLE.Product.Application.Interfaces.Repositories;

public interface IProductRepository : IMongoDbRepository<Domain.Entities.Product, string>
{
}