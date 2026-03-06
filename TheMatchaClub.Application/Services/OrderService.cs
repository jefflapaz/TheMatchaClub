using Microsoft.EntityFrameworkCore;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.Domain.Enums;
using TheMatchaClub.Infrastructure.Data;

namespace TheMatchaClub.Application.Services;

public class OrderService
{
    private readonly MatchaDbContext _context;

    public OrderService(MatchaDbContext context)
    {
        _context = context;
    }

    public async Task<Order> CreateOrderAsync(
        string customerName,
        PaymentMethod paymentMethod,
        OrderType orderType,
        List<(int itemId, int qty)> items,
        decimal cashReceived)
    {
        var session = await _context.BusinessSessions
        .FirstOrDefaultAsync(x => !x.IsClosed);

        if (session == null) throw new Exception("No active session.");

        // 1. Initialize the Order with an empty list of items
        var order = new Order
        {
            OrderNumber = Guid.NewGuid().ToString("N")[..8],
            CustomerName = customerName,
            PaymentMethod = paymentMethod,
            OrderType = orderType,
            CreatedAt = DateTime.Now,
            BusinessSessionId = session.Id,
            OrderItems = new List<OrderItem>() // Ensure this is initialized
        };

        decimal total = 0;

        // 2. Add items to the Order's collection DIRECTLY
        foreach (var (itemId, qty) in items)
        {
            var item = await _context.Items.FindAsync(itemId);
            if (item == null) continue;

            var sub = item.Price * qty;
            total += sub;

            // Add to the navigation property, NOT the db context directly
            order.OrderItems.Add(new OrderItem
            {
                ItemId = item.Id, // Link the Item
                Quantity = qty,
                UnitPrice = item.Price,
                SubTotal = sub
                // Note: We don't need to set OrderId here! EF does it for us.
            });
        }

        order.TotalAmount = total;
        order.CashReceived = cashReceived;
        order.Change = cashReceived - total;
        session.TotalSales += total;

        // 3. Save EVERYTHING at once
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();

        return order;
    }
}
