using System.ComponentModel.DataAnnotations;

namespace KolevMetal.Entities
{
    public class CompanyInfo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string CompanyName { get; set; } = null!;

        [MaxLength(200)]
        public string? Title { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string OwnerName { get; set; } = null!;

        public string? OwnerDescription { get; set; }

        [MaxLength(30)]
        public string? Phone { get; set; }

        [MaxLength(150)]
        public string? Email { get; set; }

        [MaxLength(300)]
        public string? Address { get; set; }

        [MaxLength(200)]
        public string? WorkingHours { get; set; }

        [MaxLength(500)]
        public string? LogoPath { get; set; }

        [MaxLength(500)]
        public string? OwnerImagePath { get; set; }
    }
}
