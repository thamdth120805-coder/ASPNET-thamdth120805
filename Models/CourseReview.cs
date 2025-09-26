using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class CourseReview
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string StudentId { get; set; } = string.Empty;
        
        [Required]
        public Guid CourseId { get; set; }
        
        [Range(1, 5)]
        public int Rating { get; set; }
        
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ApplicationUser Student { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}