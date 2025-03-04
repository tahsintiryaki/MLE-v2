using System.Net.Mime;
using AutoMapper;
using MLE.Order.Application.Dtos;
using MLE.Order.Application.Interfaces.Repository;
using MLE.Order.Application.Interfaces.Services;
using MLE.Order.Domain.Entities;

namespace MLE.Order.Persistence.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public async Task CreateOrder(CreateOrderDto request)
    {
        var mapping = _mapper.Map<Orders>(request);
        await _orderRepository.InsertAsync(mapping, true);
    }

    public async Task<List<OrderResponseDto>> GetAll()
    {
        var orderList = await _orderRepository.GetListAsync();
        return _mapper.Map<List<OrderResponseDto>>(orderList);
    }
}