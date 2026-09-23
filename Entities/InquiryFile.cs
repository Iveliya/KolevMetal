using System.ComponentModel.DataAnnotations;


namespace KolevMetal.Entities
{
    public class InquiryFile
    {
        public int Id { get; set; }

        public int InquiryId { get; set; }

        public Inquiry Inquiry { get; set; } = null!;

        [Required]
        [MaxLength(255)]
        public string OriginalFileName { get; set; } = null!;

        [Required]
        [MaxLength(255)]
        public string StoredFileName { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string FilePath { get; set; } = null!;

        [MaxLength(100)]
        public string? FileType { get; set; }

        public long FileSize { get; set; }

        public DateTime UploadedOn { get; set; } = DateTime.UtcNow;
    }
}
