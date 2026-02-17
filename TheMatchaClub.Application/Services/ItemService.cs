using Microsoft.EntityFrameworkCore;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.Infrastructure.Data;

namespace TheMatchaClub.Application.Services;

public class ItemService
{
    private readonly MatchaDbContext _context;

    public ItemService(MatchaDbContext context)
    {
        _context = context;
    }

    public async Task<List<Item>> GetAllAsync()
    {
        return await _context.Items
            .Include(x => x.Category)
            .Where(x => x.IsActive)
            .ToListAsync();
    }

    public async Task AddAsync(string name, decimal price, int categoryId, bool isUsual)
    {
        var item = new Item
        {
            Name = name,
            Price = price,
            CategoryId = categoryId,
            IsUsual = isUsual,
            CreatedAt = DateTime.Now
        };

        _context.Items.Add(item);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int itemId)
    {
        var item = await _context.Items.FindAsync(itemId);
        if (item == null) return;

        item.IsActive = false;
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(int itemId, string name, decimal price, int newCategoryId, bool isUsual)
    {
        var item = await _context.Items.FindAsync(itemId);
        if (item == null) return;

        int oldCategoryId = item.CategoryId;

        item.Name = name;
        item.Price = price;
        item.CategoryId = newCategoryId;
        item.IsUsual = isUsual;

        await _context.SaveChangesAsync();

        
        if (oldCategoryId != newCategoryId)
        {
            var hasItems = await _context.Items.AnyAsync(x => x.CategoryId == oldCategoryId);
            if (!hasItems)
            {
                var oldCategory = await _context.Categories.FindAsync(oldCategoryId);
                if (oldCategory != null)
                {
                    _context.Categories.Remove(oldCategory);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }


}
