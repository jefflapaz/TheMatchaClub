using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMatchaClub.Domain.Enums;

namespace TheMatchaClub.Domain.Entities
{
    
    public class Order
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; } = string.Empty;

        public string CustomerName { get; set; } = string.Empty;

        public PaymentMethod PaymentMethod { get; set; }

        public OrderType OrderType { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal? CashReceived { get; set; }

        public decimal? Change { get; set; }

        public DateTime CreatedAt { get; set; }

        public int BusinessSessionId { get; set; }

        public BusinessSession BusinessSession { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
