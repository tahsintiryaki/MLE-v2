using MLE.Order.Domain.Entities;

namespace MLE.Order.Application.Dtos;

public class CreateOrderDto
{
    public Guid UserId { get; set; }
    public string OrderNo { get; set; }
    public OrderStatusEnums Orderstatus { get; set; }
}