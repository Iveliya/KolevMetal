using KolevMetal.Entities.Enums;
using System.ComponentModel.DataAnnotations;


namespace KolevMetal.Entities
{
    public class Inquiry
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        public ApplicationUser? User { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string Phone { get; set; } = null!;

        public int ServiceId { get; set; }

        public Service Service { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        public string Subject { get; set; } = null!;

        [Required]
        [MaxLength(5000)]
        public string Description { get; set; } = null!;

        public InquiryStatus Status { get; set; }
            = InquiryStatus.New;

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public ICollection<InquiryFile> Files { get; set; }
            = new HashSet<InquiryFile>();
    }
}
