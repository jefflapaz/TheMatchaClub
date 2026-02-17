using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.Infrastructure.Data;

namespace TheMatchaClub.Application.Services;

public class AuthService
{
    private readonly MatchaDbContext _context;

    public AuthService(MatchaDbContext context)
    {
        _context = context;
    }

    public async Task<bool> AdminExistsAsync()
    {
        return await _context.AdminUsers.AnyAsync();
    }

    public async Task CreateAdminAsync(string username, string password)
    {
        var hash = BCrypt.Net.BCrypt.HashPassword(password);

        var admin = new AdminUser
        {
            Username = username,
            PasswordHash = hash,
            CreatedAt = DateTime.Now
        };

        _context.AdminUsers.Add(admin);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> LoginAsync(string password)
    {
        var admin = await _context.AdminUsers.FirstOrDefaultAsync();

        if (admin == null) return false;

        return BCrypt.Net.BCrypt.Verify(password, admin.PasswordHash);
    }
}
