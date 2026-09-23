using System.ComponentModel.DataAnnotations;

namespace KolevMetal.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string ImagePath { get; set; } = null!;

        public bool IsMain { get; set; }

        public int SortOrder { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;
    }
}
