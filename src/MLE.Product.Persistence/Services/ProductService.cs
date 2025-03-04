using AutoMapper;
using MLE.Product.Application.Dtos;
using MLE.Product.Application.Interfaces.Repositories;
using MLE.Product.Application.Interfaces.Services;

namespace MLE.Product.Persistence.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ProductDto> CreateProduct(CreateProductDto request)
    {
        var mapping = _mapper.Map<Domain.Entities.Product>(request);
        var response = await _productRepository.InsertAsync(mapping);
        return _mapper.Map<ProductDto>(response);
    }

    public async Task<List<ProductDto>> GetProducts()
    {
        var response = await _productRepository.GetAsync();
        return _mapper.Map<List<ProductDto>>(response);
    }
}