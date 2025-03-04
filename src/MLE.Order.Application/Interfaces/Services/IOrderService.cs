using MLE.Order.Application.Dtos;

namespace MLE.Order.Application.Interfaces.Services;

public interface IOrderService
{
    Task CreateOrder(CreateOrderDto request);
    Task<List<OrderResponseDto>> GetAll();
}