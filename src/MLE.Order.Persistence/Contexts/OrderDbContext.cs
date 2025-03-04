using Microsoft.EntityFrameworkCore;
using MLE.Order.Domain.Entities;

namespace MLE.Order.Persistence.Contexts;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
    }

    public DbSet<Orders> Order { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<OrderStatus> OrderStatus { get; set; }
}