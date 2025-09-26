using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var featuredCourses = await _context.Courses
            .Include(c => c.Category)
            .Include(c => c.Instructor)
            .ThenInclude(i => i.User)
            .Where(c => c.IsPublished && c.Featured)
            .Take(6)
            .ToListAsync();

        var categories = await _context.Categories
            .Take(6)
            .ToListAsync();

        ViewBag.FeaturedCourses = featuredCourses;
        ViewBag.Categories = categories;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
