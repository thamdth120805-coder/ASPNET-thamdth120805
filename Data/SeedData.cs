using Microsoft.AspNetCore.Identity;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // Ensure database is created
            await context.Database.EnsureCreatedAsync();

            // Seed roles
            await SeedRoles(roleManager);

            // Seed categories
            await SeedCategories(context);

            // Seed users and instructors
            await SeedUsers(userManager, context);

            // Seed courses
            await SeedCourses(context);
        }

        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Instructor", "Student" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        private static async Task SeedCategories(ApplicationDbContext context)
        {
            if (context.Categories.Any()) return;

            var categories = new[]
            {
                new Category { Name = "Lập trình Web", Slug = "lap-trinh-web", Description = "Học các công nghệ web hiện đại", Icon = "Code", Color = "#3B82F6" },
                new Category { Name = "Khoa học Dữ liệu", Slug = "khoa-hoc-du-lieu", Description = "Phân tích dữ liệu và machine learning", Icon = "BarChart3", Color = "#8B5CF6" },
                new Category { Name = "Lập trình Mobile", Slug = "lap-trinh-mobile", Description = "Phát triển ứng dụng di động", Icon = "Smartphone", Color = "#10B981" },
                new Category { Name = "Thiết kế", Slug = "thiet-ke", Description = "UI/UX và thiết kế đồ họa", Icon = "Palette", Color = "#F59E0B" },
                new Category { Name = "Kinh doanh", Slug = "kinh-doanh", Description = "Kỹ năng kinh doanh và khởi nghiệp", Icon = "Briefcase", Color = "#EF4444" },
                new Category { Name = "Marketing", Slug = "marketing", Description = "Marketing số và chiến lược tăng trưởng", Icon = "TrendingUp", Color = "#EC4899" }
            };

            context.Categories.AddRange(categories);
            await context.SaveChangesAsync();
        }

        private static async Task SeedUsers(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            // Create admin user
            var adminEmail = "admin@learnhub.com";
            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                var admin = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    FullName = "Quản trị viên",
                    Role = "Admin",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(admin, "Admin123!");
                await userManager.AddToRoleAsync(admin, "Admin");
            }

            // Create instructor users
            var instructors = new[]
            {
                new { Email = "instructor1@learnhub.com", Name = "Nguyễn Văn An", Title = "Senior Full-stack Developer" },
                new { Email = "instructor2@learnhub.com", Name = "Trần Thị Bình", Title = "Data Scientist" },
                new { Email = "instructor3@learnhub.com", Name = "Lê Minh Cường", Title = "Mobile App Developer" }
            };

            foreach (var inst in instructors)
            {
                if (await userManager.FindByEmailAsync(inst.Email) == null)
                {
                    var user = new ApplicationUser
                    {
                        UserName = inst.Email,
                        Email = inst.Email,
                        FullName = inst.Name,
                        Role = "Instructor",
                        EmailConfirmed = true
                    };

                    await userManager.CreateAsync(user, "Instructor123!");
                    await userManager.AddToRoleAsync(user, "Instructor");

                    // Create instructor profile
                    var instructor = new Instructor
                    {
                        UserId = user.Id,
                        Title = inst.Title,
                        ExperienceYears = 5,
                        Rating = 4.8m,
                        IsVerified = true
                    };

                    context.Instructors.Add(instructor);
                }
            }

            await context.SaveChangesAsync();
        }

        private static async Task SeedCourses(ApplicationDbContext context)
        {
            if (context.Courses.Any()) return;

            var webCategory = context.Categories.First(c => c.Slug == "lap-trinh-web");
            var dataCategory = context.Categories.First(c => c.Slug == "khoa-hoc-du-lieu");
            var mobileCategory = context.Categories.First(c => c.Slug == "lap-trinh-mobile");

            var instructor1 = context.Instructors.First();
            var instructor2 = context.Instructors.Skip(1).First();
            var instructor3 = context.Instructors.Skip(2).First();

            var courses = new[]
            {
                new Course
                {
                    Title = "Khóa học React.js từ cơ bản đến nâng cao",
                    Slug = "react-js-co-ban-den-nang-cao",
                    ShortDescription = "Học React.js từ những kiến thức cơ bản đến các kỹ thuật nâng cao",
                    Description = "Khóa học toàn diện về React.js, bao gồm JSX, Components, State, Props, Hooks, Context API, và nhiều hơn nữa.",
                    InstructorId = instructor1.Id,
                    CategoryId = webCategory.Id,
                    ThumbnailUrl = "https://images.pexels.com/photos/276452/pexels-photo-276452.jpeg?auto=compress&cs=tinysrgb&w=400",
                    Price = 1299000,
                    OriginalPrice = 1999000,
                    DifficultyLevel = "Intermediate",
                    DurationMinutes = 2400,
                    Rating = 4.8m,
                    TotalStudents = 12543,
                    IsPublished = true,
                    Featured = true,
                    WhatYouLearn = "React Components,State Management,Hooks,Context API,Routing",
                    Requirements = "HTML,CSS,JavaScript cơ bản"
                },
                new Course
                {
                    Title = "Python cho Khoa học Dữ liệu",
                    Slug = "python-cho-khoa-hoc-du-lieu",
                    ShortDescription = "Học Python và các thư viện phân tích dữ liệu",
                    Description = "Khóa học Python chuyên sâu cho khoa học dữ liệu với Pandas, NumPy, Matplotlib và Scikit-learn.",
                    InstructorId = instructor2.Id,
                    CategoryId = dataCategory.Id,
                    ThumbnailUrl = "https://images.pexels.com/photos/1181671/pexels-photo-1181671.jpeg?auto=compress&cs=tinysrgb&w=400",
                    Price = 1599000,
                    OriginalPrice = 2299000,
                    DifficultyLevel = "Beginner",
                    DurationMinutes = 3000,
                    Rating = 4.9m,
                    TotalStudents = 8765,
                    IsPublished = true,
                    Featured = true,
                    WhatYouLearn = "Python Programming,Data Analysis,Machine Learning,Data Visualization",
                    Requirements = "Kiến thức toán học cơ bản"
                },
                new Course
                {
                    Title = "Phát triển ứng dụng Flutter",
                    Slug = "phat-trien-ung-dung-flutter",
                    ShortDescription = "Xây dựng ứng dụng mobile đa nền tảng với Flutter",
                    Description = "Học cách phát triển ứng dụng mobile cho iOS và Android bằng Flutter framework.",
                    InstructorId = instructor3.Id,
                    CategoryId = mobileCategory.Id,
                    ThumbnailUrl = "https://images.pexels.com/photos/607812/pexels-photo-607812.jpeg?auto=compress&cs=tinysrgb&w=400",
                    Price = 1799000,
                    DifficultyLevel = "Intermediate",
                    DurationMinutes = 2800,
                    Rating = 4.7m,
                    TotalStudents = 5432,
                    IsPublished = true,
                    WhatYouLearn = "Flutter Framework,Dart Programming,Mobile UI Design,State Management",
                    Requirements = "Lập trình cơ bản,OOP"
                },
                new Course
                {
                    Title = "JavaScript ES6+ và Modern Web Development",
                    Slug = "javascript-es6-modern-web",
                    ShortDescription = "Nắm vững JavaScript hiện đại và các công cụ phát triển web",
                    Description = "Khóa học JavaScript từ ES6 trở lên với các tính năng mới nhất và best practices.",
                    InstructorId = instructor1.Id,
                    CategoryId = webCategory.Id,
                    ThumbnailUrl = "https://images.pexels.com/photos/1181298/pexels-photo-1181298.jpeg?auto=compress&cs=tinysrgb&w=400",
                    Price = 999000,
                    OriginalPrice = 1499000,
                    DifficultyLevel = "Beginner",
                    DurationMinutes = 2000,
                    Rating = 4.6m,
                    TotalStudents = 15678,
                    IsPublished = true,
                    WhatYouLearn = "ES6+ Features,Async Programming,DOM Manipulation,Modern Tooling",
                    Requirements = "HTML,CSS cơ bản"
                },
                new Course
                {
                    Title = "Machine Learning với Python",
                    Slug = "machine-learning-python",
                    ShortDescription = "Học machine learning từ cơ bản đến nâng cao",
                    Description = "Khóa học machine learning toàn diện với Python, từ lý thuyết đến thực hành.",
                    InstructorId = instructor2.Id,
                    CategoryId = dataCategory.Id,
                    ThumbnailUrl = "https://images.pexels.com/photos/8386440/pexels-photo-8386440.jpeg?auto=compress&cs=tinysrgb&w=400",
                    Price = 2199000,
                    DifficultyLevel = "Advanced",
                    DurationMinutes = 3600,
                    Rating = 4.9m,
                    TotalStudents = 3456,
                    IsPublished = true,
                    WhatYouLearn = "ML Algorithms,Deep Learning,Neural Networks,Model Deployment",
                    Requirements = "Python,Toán học,Thống kê"
                },
                new Course
                {
                    Title = "Khóa học miễn phí: HTML & CSS cơ bản",
                    Slug = "html-css-co-ban-mien-phi",
                    ShortDescription = "Học HTML và CSS từ đầu - hoàn toàn miễn phí",
                    Description = "Khóa học miễn phí dành cho người mới bắt đầu học lập trình web.",
                    InstructorId = instructor1.Id,
                    CategoryId = webCategory.Id,
                    ThumbnailUrl = "https://images.pexels.com/photos/1181244/pexels-photo-1181244.jpeg?auto=compress&cs=tinysrgb&w=400",
                    Price = 0,
                    DifficultyLevel = "Beginner",
                    DurationMinutes = 1200,
                    Rating = 4.5m,
                    TotalStudents = 25678,
                    IsPublished = true,
                    Featured = true,
                    WhatYouLearn = "HTML Structure,CSS Styling,Responsive Design,Web Fundamentals",
                    Requirements = "Không yêu cầu kiến thức trước"
                }
            };

            context.Courses.AddRange(courses);
            await context.SaveChangesAsync();
        }
    }
}