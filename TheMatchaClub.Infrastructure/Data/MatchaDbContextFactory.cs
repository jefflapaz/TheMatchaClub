using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TheMatchaClub.Infrastructure.Data;

public class MatchaDbContextFactory : IDesignTimeDbContextFactory<MatchaDbContext>
{
    public MatchaDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MatchaDbContext>();

        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=TheMatchaClubDb;Trusted_Connection=True;");

        return new MatchaDbContext(optionsBuilder.Options);
    }
}
