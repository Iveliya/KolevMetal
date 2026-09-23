using System.ComponentModel.DataAnnotations;

namespace KolevMetal.Entities
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; } = null!;

        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Comment { get; set; } = null!;

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public bool IsApproved { get; set; } = false;
    }
}
