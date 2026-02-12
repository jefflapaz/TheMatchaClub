using Microsoft.EntityFrameworkCore;
using TheMatchaClub.Infrastructure.Data;

namespace TheMatchaClub.WinForms.Helpers;

public static class DbContextHelper
{
    public static MatchaDbContext Create()
    {
        var options = new DbContextOptionsBuilder<MatchaDbContext>()
            .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TheMatchaClubDb;Trusted_Connection=True;")
            .Options;

        return new MatchaDbContext(options);
    }
}
