using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.Infrastructure.Identity;

namespace TheMatchaClub.Infrastructure.Data;

public class MatchaDbContext : IdentityDbContext<AdminUser>
{
    public MatchaDbContext(DbContextOptions<MatchaDbContext> options)
        : base(options)
    {
    }


    public DbSet<BusinessSession> BusinessSessions => Set<BusinessSession>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Item> Items => Set<Item>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

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
