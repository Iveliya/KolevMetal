using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace KolevMetal.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Product> Products { get; set; }
            = new HashSet<Product>();
    }
}
