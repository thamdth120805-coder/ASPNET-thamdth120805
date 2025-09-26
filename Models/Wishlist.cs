using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Wishlist
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string UserId { get; set; } = string.Empty;
        
        [Required]
        public Guid CourseId { get; set; }
        
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ApplicationUser User { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}