using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class CourseModule
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public Guid CourseId { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;
        
        public string? Description { get; set; }
        public int OrderIndex { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual Course Course { get; set; } = null!;
        public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}