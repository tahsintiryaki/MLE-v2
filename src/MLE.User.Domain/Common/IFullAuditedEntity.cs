using MLE.User.Domain.Common;

namespace MLE.User.Domain.Common;

public interface IFullAuditedEntity : IHasCreation, IHasUpdate, ISoftDeletion, IHasActive
{
}