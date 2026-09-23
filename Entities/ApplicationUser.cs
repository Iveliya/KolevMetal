using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace KolevMetal.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public ICollection<Order> Orders { get; set; }
            = new HashSet<Order>();

        public ICollection<Inquiry> Inquiries { get; set; }
            = new HashSet<Inquiry>();

        public ICollection<Review> Reviews { get; set; }
            = new HashSet<Review>();
    }
}
