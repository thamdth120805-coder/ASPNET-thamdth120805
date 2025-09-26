using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? search, string? category, string? price, string? difficulty, string? sort, int page = 1)
        {
            var query = _context.Courses
                .Include(c => c.Category)
                .Include(c => c.Instructor)
                .ThenInclude(i => i.User)
                .Where(c => c.IsPublished);

            // Apply filters
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => c.Title.Contains(search) || c.ShortDescription.Contains(search));
            }

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(c => c.Category.Slug == category);
            }

            if (!string.IsNullOrEmpty(price))
            {
                if (price == "free")
                    query = query.Where(c => c.Price == 0);
                else if (price == "paid")
                    query = query.Where(c => c.Price > 0);
            }

            if (!string.IsNullOrEmpty(difficulty))
            {
                query = query.Where(c => c.DifficultyLevel.ToLower() == difficulty.ToLower());
            }

            // Apply sorting
            query = sort switch
            {
                "price-low" => query.OrderBy(c => c.Price),
                "price-high" => query.OrderByDescending(c => c.Price),
                "rating" => query.OrderByDescending(c => c.Rating),
                "popular" => query.OrderByDescending(c => c.TotalStudents),
                _ => query.OrderByDescending(c => c.CreatedAt)
            };

            const int pageSize = 12;
            var totalCourses = await query.CountAsync();
            var courses = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var categories = await _context.Categories.ToListAsync();

            ViewBag.Categories = categories;
            ViewBag.CurrentSearch = search;
            ViewBag.CurrentCategory = category;
            ViewBag.CurrentPrice = price;
            ViewBag.CurrentDifficulty = difficulty;
            ViewBag.CurrentSort = sort;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalCourses / (double)pageSize);
            ViewBag.TotalCourses = totalCourses;

            return View(courses);
        }

        public async Task<IActionResult> Details(Guid? id, string? slug)
        {
            Course? course = null;
            
            if (id.HasValue)
            {
                course = await _context.Courses
                    .Include(c => c.Category)
                    .Include(c => c.Instructor)
                    .ThenInclude(i => i.User)
                    .Include(c => c.Modules)
                    .ThenInclude(m => m.Lessons)
                    .Include(c => c.Reviews)
                    .ThenInclude(r => r.Student)
                    .FirstOrDefaultAsync(c => c.Id == id && c.IsPublished);
            }
            else if (!string.IsNullOrEmpty(slug))
            {
                course = await _context.Courses
                    .Include(c => c.Category)
                    .Include(c => c.Instructor)
                    .ThenInclude(i => i.User)
                    .Include(c => c.Modules)
                    .ThenInclude(m => m.Lessons)
                    .Include(c => c.Reviews)
                    .ThenInclude(r => r.Student)
                    .FirstOrDefaultAsync(c => c.Slug == slug && c.IsPublished);
            }

            if (course == null)
                return NotFound();

            // Get related courses
            var relatedCourses = await _context.Courses
                .Include(c => c.Category)
                .Include(c => c.Instructor)
                .ThenInclude(i => i.User)
                .Where(c => c.CategoryId == course.CategoryId && c.Id != course.Id && c.IsPublished)
                .Take(4)
                .ToListAsync();

            ViewBag.RelatedCourses = relatedCourses;

            return View(course);
        }
    }
}