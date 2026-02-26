using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TheMatchaClub.Infrastructure.Identity;

namespace TheMatchaClub.Application.Services;

public class AuthService
{
    private readonly UserManager<AdminUser> _userManager;

    public AuthService(UserManager<AdminUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<bool> LoginAsync(string username, string password)
    {
        var user = await _userManager.FindByNameAsync(username);
        if (user == null) return false;

        return await _userManager.CheckPasswordAsync(user, password);
    }

    public async Task CreateAdminAsync(string username, string password)
    {
        var user = new AdminUser { UserName = username };

        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
        {
            var errors = string.Join(", ", result.Errors.Select(e => e.Description));
            throw new Exception(errors);
        }
    }

    public async Task<bool> AdminExistsAsync()
    {
        return await _userManager.Users.AnyAsync();
    }
}
