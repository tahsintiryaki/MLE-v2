using MLE.Order.Domain.Common;

namespace MLE.Order.Domain.Entities;

public class OrderDetails : FullAuditedEntity
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Amount { get; set; }

    public Orders Orders { get; set; }
}