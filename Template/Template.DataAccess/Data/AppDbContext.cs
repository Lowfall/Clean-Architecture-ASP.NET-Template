using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Template.DataAccess.Configuration.Options;

namespace Template.DataAccess.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options, IOptions<ConnectionStringsOptions> connectionStringsOptions) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionStringsOptions.Value.PostgreSQLConnection);
        base.OnConfiguring(optionsBuilder);
    }
}