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

        if (session == null)
            throw new Exception("No active session.");

        var order = new Order
        {
            OrderNumber = Guid.NewGuid().ToString("N")[..8],
            CustomerName = customerName,
            PaymentMethod = paymentMethod,
            OrderType = orderType,
            CreatedAt = DateTime.Now,
            BusinessSessionId = session.Id
        };

        _context.Orders.Add(order);
        await _context.SaveChangesAsync();

        decimal total = 0;

        foreach (var (itemId, qty) in items)
        {
            var item = await _context.Items.FindAsync(itemId);
            if (item == null) continue;

            var sub = item.Price * qty;

            total += sub;

            _context.OrderItems.Add(new OrderItem
            {
                OrderId = order.Id,
                ItemId = item.Id,
                Quantity = qty,
                UnitPrice = item.Price,
                SubTotal = sub
            });
        }

        order.TotalAmount = total;
        order.CashReceived = cashReceived;
        order.Change = cashReceived - total;

        session.TotalSales += total;

        await _context.SaveChangesAsync();

        return order;
    }
}
