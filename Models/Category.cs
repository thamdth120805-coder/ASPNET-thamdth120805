using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string Slug { get; set; } = string.Empty;
        
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public string Color { get; set; } = "#3B82F6";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}