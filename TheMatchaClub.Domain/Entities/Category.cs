
using System.ComponentModel.DataAnnotations;


namespace TheMatchaClub.Domain.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
