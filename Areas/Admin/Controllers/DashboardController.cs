using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;

namespace OnlineLearningPlatform.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Instructor")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var totalCourses = await _context.Courses.CountAsync();
            var totalStudents = await _context.Users.Where(u => u.Role == "Student").CountAsync();
            var totalInstructors = await _context.Instructors.CountAsync();
            var totalEnrollments = await _context.Enrollments.CountAsync();

            ViewBag.TotalCourses = totalCourses;
            ViewBag.TotalStudents = totalStudents;
            ViewBag.TotalInstructors = totalInstructors;
            ViewBag.TotalEnrollments = totalEnrollments;

            // Recent courses
            var recentCourses = await _context.Courses
                .Include(c => c.Category)
                .Include(c => c.Instructor)
                .ThenInclude(i => i.User)
                .OrderByDescending(c => c.CreatedAt)
                .Take(5)
                .ToListAsync();

            ViewBag.RecentCourses = recentCourses;

            return View();
        }
    }
}