namespace MLE.Order.Domain.Common;

public interface IFullAuditedEntity : IHasCreation, IHasUpdate, ISoftDeletion, IHasActive
{
}