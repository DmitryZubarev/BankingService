using Gab_BankingService.DbConnector.Models;
using Microsoft.EntityFrameworkCore;

namespace Gab_BankingService.DbConnector;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Gab_BankingService.ConfigurationManager.ConnectionStringProtectedDb);
    }
}