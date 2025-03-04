using MLE.Product.Application.Interfaces.Repositories;
using MongoDB.Driver;

namespace MLE.Product.Persistence.Repositories;

public class ProductRepository : MongoRepository<Domain.Entities.Product, string>, IProductRepository
{
    public ProductRepository(IMongoDatabase database) : base(database)
    {
    }
}