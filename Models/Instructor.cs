using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Instructor
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string UserId { get; set; } = string.Empty;
        
        public string? Title { get; set; }
        public string? Expertise { get; set; }
        public int ExperienceYears { get; set; } = 0;
        public decimal Rating { get; set; } = 0;
        public int TotalStudents { get; set; } = 0;
        public int TotalCourses { get; set; } = 0;
        public bool IsVerified { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ApplicationUser User { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}