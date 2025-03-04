using MLE.Order.Application.Interfaces.Repositories;
using MLE.Order.Domain.Entities;

namespace MLE.Order.Application.Interfaces.Repository;

public interface IOrderRepository : IGeneralRepository<Orders>
{
}