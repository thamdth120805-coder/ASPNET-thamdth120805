using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseModule> CourseModules { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<CourseReview> CourseReviews { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Progress> Progress { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure relationships
            builder.Entity<Instructor>()
                .HasOne(i => i.User)
                .WithOne(u => u.Instructor)
                .HasForeignKey<Instructor>(i => i.UserId);

            builder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId);

            builder.Entity<Course>()
                .HasOne(c => c.Category)
                .WithMany(cat => cat.Courses)
                .HasForeignKey(c => c.CategoryId);

            builder.Entity<CourseModule>()
                .HasOne(m => m.Course)
                .WithMany(c => c.Modules)
                .HasForeignKey(m => m.CourseId);

            builder.Entity<Lesson>()
                .HasOne(l => l.Module)
                .WithMany(m => m.Lessons)
                .HasForeignKey(l => l.ModuleId);

            builder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(u => u.Enrollments)
                .HasForeignKey(e => e.StudentId);

            builder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            builder.Entity<CourseReview>()
                .HasOne(r => r.Student)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.StudentId);

            builder.Entity<CourseReview>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CourseId);

            builder.Entity<Payment>()
                .HasOne(p => p.Student)
                .WithMany(u => u.Payments)
                .HasForeignKey(p => p.StudentId);

            builder.Entity<Payment>()
                .HasOne(p => p.Course)
                .WithMany(c => c.Payments)
                .HasForeignKey(p => p.CourseId);

            builder.Entity<Progress>()
                .HasOne(p => p.Student)
                .WithMany()
                .HasForeignKey(p => p.StudentId);

            builder.Entity<Progress>()
                .HasOne(p => p.Lesson)
                .WithMany(l => l.ProgressRecords)
                .HasForeignKey(p => p.LessonId);

            // Configure unique constraints
            builder.Entity<Category>()
                .HasIndex(c => c.Slug)
                .IsUnique();

            builder.Entity<Course>()
                .HasIndex(c => c.Slug)
                .IsUnique();

            builder.Entity<Enrollment>()
                .HasIndex(e => new { e.StudentId, e.CourseId })
                .IsUnique();

            builder.Entity<CourseReview>()
                .HasIndex(r => new { r.StudentId, r.CourseId })
                .IsUnique();

            builder.Entity<Progress>()
                .HasIndex(p => new { p.StudentId, p.LessonId })
                .IsUnique();

            builder.Entity<Wishlist>()
                .HasOne(w => w.User)
                .WithMany(u => u.Wishlists)
                .HasForeignKey(w => w.UserId);

            builder.Entity<Wishlist>()
                .HasOne(w => w.Course)
                .WithMany()
                .HasForeignKey(w => w.CourseId);

            builder.Entity<Wishlist>()
                .HasIndex(w => new { w.UserId, w.CourseId })
                .IsUnique();

            // Configure decimal precision
            builder.Entity<Course>()
                .Property(c => c.Price)
                .HasPrecision(10, 2);

            builder.Entity<Course>()
                .Property(c => c.OriginalPrice)
                .HasPrecision(10, 2);

            builder.Entity<Course>()
                .Property(c => c.Rating)
                .HasPrecision(3, 2);

            builder.Entity<Instructor>()
                .Property(i => i.Rating)
                .HasPrecision(3, 2);

            builder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(10, 2);
        }
    }
}