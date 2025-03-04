using MLE.Product.Application.Dtos;

namespace MLE.Product.Application.Interfaces.Services;

public interface IProductService
{
    public Task<ProductDto> CreateProduct(CreateProductDto request);
    public Task<List<ProductDto>> GetProducts();
}