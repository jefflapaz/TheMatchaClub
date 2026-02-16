using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMatchaClub.Domain.Entities
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string? ImagePath { get; set; }

        public bool IsUsual { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
    }
}
