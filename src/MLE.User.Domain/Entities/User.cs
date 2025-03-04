using MLE.User.Domain.Common;

namespace MLE.User.Domain.Entities;

public class User : FullAuditedEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}