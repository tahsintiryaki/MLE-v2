using MLE.Product.Domain.Common;

namespace MLE.Product.Domain.Entities;

public class Product : FullAuditedEntity<string>
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
}