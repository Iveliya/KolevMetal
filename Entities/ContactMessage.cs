using System.ComponentModel.DataAnnotations;

namespace KolevMetal.Entities
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Email { get; set; } = null!;

        [MaxLength(30)]
        public string? Phone { get; set; }

        [Required]
        [MaxLength(200)]
        public string Subject { get; set; } = null!;

        [Required]
        [MaxLength(3000)]
        public string Message { get; set; } = null!;

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public bool IsRead { get; set; } = false;
    }
}
