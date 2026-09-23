using System.ComponentModel.DataAnnotations;
namespace KolevMetal.Entities
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [MaxLength(500)]
        public string? ImagePath { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Inquiry> Inquiries { get; set; }
            = new HashSet<Inquiry>();
    }
}
