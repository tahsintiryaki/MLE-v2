using MLE.Order.Domain.Common;

namespace MLE.Order.Domain.Entities;

public class OrderStatus : FullAuditedEntity
{
    public string Name { get; set; }
}