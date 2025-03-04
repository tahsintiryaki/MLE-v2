using MLE.Order.Application.Interfaces.Repository;
using MLE.Order.Domain.Entities;
using MLE.Order.Persistence.Contexts;

namespace MLE.Order.Persistence.Repositories;

public class OrderRepository : GeneralRepository<Orders>, IOrderRepository
{
    public OrderRepository(OrderDbContext dbContext) : base(dbContext)
    {
    }
}