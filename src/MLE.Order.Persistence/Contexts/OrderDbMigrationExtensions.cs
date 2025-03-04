using Microsoft.EntityFrameworkCore;

namespace MLE.Order.Persistence.Contexts;

public static class OrderDbMigrationExtensions
{
    public static async Task DatabaseMigrator(this OrderDbContext dbContext)
    {
        await dbContext.Database.MigrateAsync();
    }
}