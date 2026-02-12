using Microsoft.EntityFrameworkCore;
using TheMatchaClub.Domain.Entities;

namespace TheMatchaClub.Infrastructure.Data;

public class MatchaDbContext : DbContext
{
    public MatchaDbContext(DbContextOptions<MatchaDbContext> options)
        : base(options)
    {
    }

    public DbSet<AdminUser> AdminUsers => Set<AdminUser>();
    public DbSet<BusinessSession> BusinessSessions => Set<BusinessSession>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Item> Items => Set<Item>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AdminUser>()
            .HasIndex(x => x.Username)
            .IsUnique();

        modelBuilder.Entity<Category>()
            .HasIndex(x => x.Name)
            .IsUnique();

        modelBuilder.Entity<BusinessSession>()
            .HasIndex(x => x.SessionName)
            .IsUnique();

        modelBuilder.Entity<Item>()
            .Property(x => x.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Order>()
            .Property(x => x.TotalAmount)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Order>()
            .Property(x => x.CashReceived)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Order>()
            .Property(x => x.Change)
            .HasPrecision(18, 2);

        modelBuilder.Entity<BusinessSession>()
            .Property(x => x.TotalSales)
            .HasPrecision(18, 2);

        modelBuilder.Entity<OrderItem>()
            .Property(x => x.UnitPrice)
            .HasPrecision(18, 2);

        modelBuilder.Entity<OrderItem>()
            .Property(x => x.SubTotal)
            .HasPrecision(18, 2);
    }
}
