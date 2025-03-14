using MLE.Order.Domain.Common;

namespace MLE.Order.Domain.Entities;

public class Orders : FullAuditedEntity
{
    public Guid UserId { get; set; }
    public string OrderNo { get; set; }
    public OrderStatusEnums OrderStatus { get; set; }
    
    
    public ICollection<OrderDetails> OrderDetails { get; set; }
}