using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Course
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        [StringLength(200)]
        public string Slug { get; set; } = string.Empty;
        
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
        
        public Guid? InstructorId { get; set; }
        public Guid? CategoryId { get; set; }
        
        public string? ThumbnailUrl { get; set; }
        public string? PreviewVideoUrl { get; set; }
        
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; } = 0;
        
        [Range(0, double.MaxValue)]
        public decimal? OriginalPrice { get; set; }
        
        public string DifficultyLevel { get; set; } = "Beginner";
        public int DurationMinutes { get; set; } = 0;
        public string Language { get; set; } = "vi";
        public string? WhatYouLearn { get; set; }
        public string? Requirements { get; set; }
        
        public bool IsPublished { get; set; } = false;
        public bool Featured { get; set; } = false;
        
        [Range(0, 5)]
        public decimal Rating { get; set; } = 0;
        
        public int TotalStudents { get; set; } = 0;
        public int TotalReviews { get; set; } = 0;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual Instructor? Instructor { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<CourseModule> Modules { get; set; } = new List<CourseModule>();
        public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public virtual ICollection<CourseReview> Reviews { get; set; } = new List<CourseReview>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}