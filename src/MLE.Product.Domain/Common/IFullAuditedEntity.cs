using MLE.Product.Domain.Common;

namespace MLE.Product.Domain.Common;

public interface IFullAuditedEntity<TKey> : IHasCreation, IHasUpdate, ISoftDeletion, IHasActive
{
}