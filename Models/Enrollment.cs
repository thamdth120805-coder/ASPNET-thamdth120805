using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Enrollment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string StudentId { get; set; } = string.Empty;
        
        [Required]
        public Guid CourseId { get; set; }
        
        public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;
        
        [Range(0, 100)]
        public int ProgressPercentage { get; set; } = 0;
        
        public DateTime? CompletedAt { get; set; }
        public string? CertificateUrl { get; set; }

        // Navigation properties
        public virtual ApplicationUser Student { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}