using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MLE.User.Persistence.Contexts;

public static class MigrationExtensions
{
    public static async Task DatabaseMigrator(this UserDbContext dbContext)
    {
        await dbContext.Database.MigrateAsync();
    }
}