using MLE.Order.Domain.Entities;

namespace MLE.Order.Application.Dtos;

public class OrderResponseDto
{
    public Guid UserId { get; set; }
    public string OrderNo { get; set; }
    public OrderStatusEnums OrderStatus { get; set; }
}