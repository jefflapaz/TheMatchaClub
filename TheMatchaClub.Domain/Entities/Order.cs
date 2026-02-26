using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheMatchaClub.Domain.Enums;

namespace TheMatchaClub.Domain.Entities
{
    
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OrderNumber { get; set; } = string.Empty;
        [Required]
        public string CustomerName { get; set; } = string.Empty;

        public PaymentMethod PaymentMethod { get; set; }

        public OrderType OrderType { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? CashReceived { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Change { get; set; }

        public DateTime CreatedAt { get; set; }

        public int BusinessSessionId { get; set; }
        [ForeignKey(nameof(BusinessSessionId))]
        public BusinessSession BusinessSession { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
