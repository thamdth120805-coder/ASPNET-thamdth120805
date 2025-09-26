using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Progress
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string StudentId { get; set; } = string.Empty;
        
        [Required]
        public Guid LessonId { get; set; }
        
        public DateTime CompletedAt { get; set; } = DateTime.UtcNow;
        public int WatchTimeSeconds { get; set; } = 0;

        // Navigation properties
        public virtual ApplicationUser Student { get; set; } = null!;
        public virtual Lesson Lesson { get; set; } = null!;
    }
}