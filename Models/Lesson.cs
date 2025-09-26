using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Lesson
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public Guid ModuleId { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;
        
        public string? Description { get; set; }
        public string? VideoUrl { get; set; }
        public int DurationMinutes { get; set; } = 0;
        public int OrderIndex { get; set; }
        public bool IsPreview { get; set; } = false;
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual CourseModule Module { get; set; } = null!;
        public virtual ICollection<Progress> ProgressRecords { get; set; } = new List<Progress>();
    }
}