using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheMatchaClub.Domain.Entities
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ItemId { get; set; }

        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;
        [ForeignKey(nameof(OrderId))]
        public Item Item { get; set; } = null!;
    }
}