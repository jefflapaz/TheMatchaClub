using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheMatchaClub.Infrastructure.Data;
using TheMatchaClub.Infrastructure.Identity;

namespace TheMatchaClub.Infrastructure;

public static class IdentityHelper
{
    private static ServiceProvider? _provider;

    public static UserManager<AdminUser> GetUserManager()
    {
        if (_provider == null)
        {
            var services = new ServiceCollection();

            services.AddDbContext<MatchaDbContext>(options =>
                options.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=TheMatchaClubDb;Trusted_Connection=True;"));

            services.AddIdentityCore<AdminUser>(options =>
            {
                // relax password rules for POS
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 4;
            })
            .AddEntityFrameworkStores<MatchaDbContext>();

            _provider = services.BuildServiceProvider();
        }

        return _provider.GetRequiredService<UserManager<AdminUser>>();
    }
}