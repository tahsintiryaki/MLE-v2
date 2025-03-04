using MLE.User.Application.Interfaces.Repository;
using MLE.User.Domain.Entities;
using MLE.User.Persistence.Contexts;

namespace MLE.User.Persistence.Repositories;

public class UserRepository : GeneralRepository<Domain.Entities.User>,IUserRepository
{
    public UserRepository(UserDbContext dbContext) : base(dbContext)
    {
    }
}