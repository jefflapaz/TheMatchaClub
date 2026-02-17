using Microsoft.EntityFrameworkCore;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.Infrastructure.Data;

namespace TheMatchaClub.Application.Services;

public class CategoryService
{
    private readonly MatchaDbContext _context;

    public CategoryService(MatchaDbContext context)
    {
        _context = context;
    }

    public async Task<Category> GetOrCreateAsync(string name)
    {
        var existing = await _context.Categories.FirstOrDefaultAsync(x => x.Name == name);

        if (existing != null)
            return existing;

        var category = new Category { Name = name };
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();

        return category;
    }

    public async Task DeleteIfEmptyAsync(int categoryId)
    {
        var hasItems = await _context.Items.AnyAsync(x => x.CategoryId == categoryId && x.IsActive);

        if (!hasItems)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
