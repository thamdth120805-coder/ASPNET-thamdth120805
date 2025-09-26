using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform.Controllers
{
    [Authorize]
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public MemberController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            var enrollments = await _context.Enrollments
                .Include(e => e.Course)
                .ThenInclude(c => c.Instructor)
                .ThenInclude(i => i.User)
                .Where(e => e.StudentId == user.Id)
                .OrderByDescending(e => e.EnrolledAt)
                .ToListAsync();

            return View(enrollments);
        }

        public async Task<IActionResult> MyCourses()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            var enrollments = await _context.Enrollments
                .Include(e => e.Course)
                .ThenInclude(c => c.Instructor)
                .ThenInclude(i => i.User)
                .Where(e => e.StudentId == user.Id)
                .OrderByDescending(e => e.EnrolledAt)
                .ToListAsync();

            return View(enrollments);
        }

        public async Task<IActionResult> Wishlist()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            var wishlists = await _context.Wishlists
                .Include(w => w.Course)
                .ThenInclude(c => c.Instructor)
                .ThenInclude(i => i.User)
                .Where(w => w.UserId == user.Id)
                .OrderByDescending(w => w.AddedAt)
                .ToListAsync();

            return View(wishlists);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnrollCourse(Guid courseId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Json(new { success = false, message = "Vui lòng đăng nhập" });

            var course = await _context.Courses.FindAsync(courseId);
            if (course == null) return Json(new { success = false, message = "Khóa học không tồn tại" });

            var existingEnrollment = await _context.Enrollments
                .FirstOrDefaultAsync(e => e.StudentId == user.Id && e.CourseId == courseId);

            if (existingEnrollment != null)
                return Json(new { success = false, message = "Bạn đã đăng ký khóa học này rồi" });

            var enrollment = new Enrollment
            {
                StudentId = user.Id,
                CourseId = courseId
            };

            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();

            return Json(new { success = true, message = "Đăng ký khóa học thành công!" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToWishlist(Guid courseId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Json(new { success = false, message = "Vui lòng đăng nhập" });

            var course = await _context.Courses.FindAsync(courseId);
            if (course == null) return Json(new { success = false, message = "Khóa học không tồn tại" });

            var existingWishlist = await _context.Wishlists
                .FirstOrDefaultAsync(w => w.UserId == user.Id && w.CourseId == courseId);

            if (existingWishlist != null)
                return Json(new { success = false, message = "Khóa học đã có trong danh sách yêu thích" });

            var wishlist = new Wishlist
            {
                UserId = user.Id,
                CourseId = courseId
            };

            _context.Wishlists.Add(wishlist);
            await _context.SaveChangesAsync();

            return Json(new { success = true, message = "Đã thêm vào danh sách yêu thích!" });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromWishlist(Guid courseId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Json(new { success = false, message = "Vui lòng đăng nhập" });

            var wishlist = await _context.Wishlists
                .FirstOrDefaultAsync(w => w.UserId == user.Id && w.CourseId == courseId);

            if (wishlist == null)
                return Json(new { success = false, message = "Khóa học không có trong danh sách yêu thích" });

            _context.Wishlists.Remove(wishlist);
            await _context.SaveChangesAsync();

            return Json(new { success = true, message = "Đã xóa khỏi danh sách yêu thích!" });
        }

        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(string fullName, string phone, string bio)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Json(new { success = false, message = "Không tìm thấy người dùng" });

            user.FullName = fullName;
            user.Phone = phone;
            user.Bio = bio;
            user.UpdatedAt = DateTime.UtcNow;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Json(new { success = true, message = "Cập nhật thông tin thành công!" });
            }

            return Json(new { success = false, message = "Có lỗi xảy ra khi cập nhật thông tin" });
        }
    }
}