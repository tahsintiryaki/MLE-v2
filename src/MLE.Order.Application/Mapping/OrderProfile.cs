using System.Data;
using AutoMapper;
using MLE.Order.Application.Dtos;
using MLE.Order.Domain.Entities;

namespace MLE.Order.Application.Mapping;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<CreateOrderDto, Orders>().ReverseMap();
        CreateMap<OrderResponseDto, Orders>().ReverseMap();
    }
}