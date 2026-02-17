using Microsoft.EntityFrameworkCore;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.Infrastructure.Data;

namespace TheMatchaClub.Application.Services;

public class SessionService
{
    private readonly MatchaDbContext _context;

    public SessionService(MatchaDbContext context)
    {
        _context = context;
    }

    public async Task<BusinessSession?> GetActiveSessionAsync()
    {
        return await _context.BusinessSessions
            .FirstOrDefaultAsync(x => !x.IsClosed);
    }

    public async Task<BusinessSession> StartSessionAsync(string sessionName)
    {
        var existing = await GetActiveSessionAsync();
        if (existing != null)
            throw new Exception("There is already an active session.");

        var session = new BusinessSession
        {
            SessionName = sessionName,
            StartDateTime = DateTime.Now,
            TotalSales = 0,
            IsClosed = false
        };

        _context.BusinessSessions.Add(session);
        await _context.SaveChangesAsync();

        return session;
    }

    public async Task EndSessionAsync()
    {
        var session = await GetActiveSessionAsync();
        if (session == null)
            throw new Exception("No active session.");

        session.IsClosed = true;
        session.EndDateTime = DateTime.Now;

        await _context.SaveChangesAsync();
    }
}
