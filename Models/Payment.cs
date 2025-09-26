using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Payment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string StudentId { get; set; } = string.Empty;
        
        [Required]
        public Guid CourseId { get; set; }
        
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }
        
        public string Currency { get; set; } = "VND";
        public string? PaymentMethod { get; set; }
        public string PaymentStatus { get; set; } = "Pending";
        public string? TransactionId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ApplicationUser Student { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}