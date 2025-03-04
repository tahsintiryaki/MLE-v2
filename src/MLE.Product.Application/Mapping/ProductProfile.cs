using AutoMapper;
using MLE.Product.Application.Dtos;

namespace MLE.User.Application.Mapping;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<CreateProductDto, Product.Domain.Entities.Product>().ReverseMap();
        CreateMap<ProductDto, Product.Domain.Entities.Product>().ReverseMap();
    }
}