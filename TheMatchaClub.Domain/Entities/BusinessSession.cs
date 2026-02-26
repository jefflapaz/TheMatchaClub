using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TheMatchaClub.Domain.Entities
{
    public class BusinessSession
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string SessionName { get; set; } = string.Empty;

        public DateTime StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalSales { get; set; }

        public bool IsClosed { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
