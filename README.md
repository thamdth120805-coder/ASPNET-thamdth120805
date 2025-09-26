# Website Nền Tảng Học Tập Trực Tuyến - ASP.NET Core MVC

## Mô tả dự án
Đây là website nền tảng học tập trực tuyến được chuyển đổi từ React/TypeScript sang ASP.NET Core MVC, giữ nguyên giao diện và chức năng hiện đại.

## Công nghệ sử dụng
- **Framework**: ASP.NET Core 9.0 MVC
- **Database**: SQLite (Entity Framework Core)
- **Authentication**: ASP.NET Core Identity
- **Frontend**: Bootstrap 5, Font Awesome, jQuery
- **ORM**: Entity Framework Core 9.0

## Chức năng chính

### 🏠 Trang chủ
- Hero section với thông tin giới thiệu
- Hiển thị khóa học nổi bật
- Danh mục khóa học
- Các tính năng ưu việt (chất lượng cao, học mọi lúc, chứng chỉ, hỗ trợ 24/7)

### 📚 Quản lý khóa học
- Danh sách khóa học với phân trang
- Bộ lọc theo danh mục, giá, độ khó, tìm kiếm
- Sắp xếp theo tên, giá, đánh giá, độ phổ biến
- Chi tiết khóa học với thông tin đầy đủ
- Nội dung khóa học (modules, lessons)
- Đánh giá từ học viên

### 🔐 Xác thực người dùng
- Đăng ký tài khoản mới với giao diện đẹp
- Đăng nhập/Đăng xuất
- Quản lý thông tin cá nhân
- Phân quyền (Student, Instructor, Admin)

### 👨‍🏫 Hệ thống giảng viên
- Thông tin giảng viên
- Quản lý khóa học của giảng viên
- Đánh giá và xếp hạng

### 🎓 Hệ thống học tập
- Đăng ký khóa học
- Theo dõi tiến độ học tập
- Chứng chỉ hoàn thành
- Đánh giá khóa học

## Cấu trúc dự án

```
OnlineLearningPlatform/
├── Controllers/
│   ├── HomeController.cs          # Trang chủ
│   └── CoursesController.cs       # Quản lý khóa học
├── Areas/
│   ├── Admin/
│   │   └── Controllers/
│   │       └── DashboardController.cs  # Trang quản trị
│   └── Identity/
│       └── Pages/
│           └── Account/           # Đăng nhập/Đăng ký
├── Models/
│   ├── ApplicationUser.cs         # Model người dùng
│   ├── Category.cs               # Model danh mục
│   ├── Course.cs                 # Model khóa học
│   ├── Instructor.cs             # Model giảng viên
│   ├── Enrollment.cs             # Model đăng ký học
│   ├── CourseReview.cs           # Model đánh giá
│   └── ...                       # Các model khác
├── Views/
│   ├── Home/
│   │   └── Index.cshtml          # Trang chủ
│   ├── Courses/
│   │   ├── Index.cshtml          # Danh sách khóa học
│   │   └── Details.cshtml        # Chi tiết khóa học
│   └── Shared/
│       ├── _Layout.cshtml        # Layout chính
│       ├── _AuthLayout.cshtml    # Layout đăng nhập
│       └── _LoginPartial.cshtml  # Partial đăng nhập
├── Data/
│   ├── ApplicationDbContext.cs   # Database context
│   └── SeedData.cs              # Dữ liệu mẫu
└── wwwroot/                      # Static files
```

## Hướng dẫn cài đặt và chạy

### 1. Yêu cầu hệ thống
- .NET 9.0 SDK
- Visual Studio 2022 hoặc VS Code
- Git

### 2. Clone và cài đặt
```bash
# Clone repository (nếu có)
git clone [repository-url]
cd OnlineLearningPlatform

# Restore packages
dotnet restore

# Tạo database
dotnet ef database update

# Chạy ứng dụng
dotnet run
```

### 3. Truy cập ứng dụng
- Mở trình duyệt và truy cập: `https://localhost:5001` hoặc `http://localhost:5000`

## Dữ liệu mẫu
Hệ thống đã được cấu hình với dữ liệu mẫu bao gồm:

### Tài khoản mẫu:
- **Admin**: admin@learnhub.com / Admin123!
- **Giảng viên**: instructor1@learnhub.com / Instructor123!
- **Học viên**: Đăng ký mới hoặc tạo tài khoản

### Danh mục khóa học:
- Lập trình Web
- Khoa học Dữ liệu
- Lập trình Mobile
- Thiết kế
- Kinh doanh
- Marketing

### Khóa học mẫu:
- Khóa học React.js từ cơ bản đến nâng cao - 1,299,000đ
- Python cho Khoa học Dữ liệu - 1,599,000đ
- Phát triển ứng dụng Flutter - 1,799,000đ
- JavaScript ES6+ và Modern Web Development - 999,000đ
- Machine Learning với Python - 2,199,000đ
- HTML & CSS cơ bản (Miễn phí) - 0đ

## Tính năng đã hoàn thành

### ✅ Frontend
- [x] Trang chủ responsive với Bootstrap 5
- [x] Danh sách khóa học với bộ lọc và tìm kiếm
- [x] Chi tiết khóa học với thông tin đầy đủ
- [x] Giao diện đăng nhập/đăng ký đẹp mắt
- [x] Header với search và navigation
- [x] Footer với thông tin liên hệ
- [x] Layout riêng cho authentication

### ✅ Backend
- [x] ASP.NET Core Identity cho authentication
- [x] Entity Framework với SQLite database
- [x] Model relationships và validation
- [x] Seed data cho categories, courses, users
- [x] Controllers cho Home và Courses
- [x] Admin area với dashboard

### ✅ Database
- [x] User management với ASP.NET Identity
- [x] Course catalog với categories
- [x] Instructor profiles
- [x] Enrollment system
- [x] Review và rating system
- [x] Progress tracking
- [x] Payment records

## Tính năng sẽ phát triển

### 🔄 Đang phát triển
- [ ] Trang quản lý khóa học cho giảng viên
- [ ] Hệ thống thanh toán trực tuyến
- [ ] Video player cho bài học
- [ ] Quiz và bài tập
- [ ] Chứng chỉ tự động

### 🚀 Tương lai
- [ ] Tích hợp payment gateway (VNPay, MoMo)
- [ ] Email notifications
- [ ] Real-time chat support
- [ ] Mobile app với MAUI
- [ ] AI recommendation system

## Giao diện chính

### Trang chủ
- Hero section với gradient background
- Khóa học nổi bật với card design hiện đại
- Danh mục với màu sắc đẹp mắt
- Tính năng ưu việt với icons

### Đăng nhập/Đăng ký
- Layout riêng với gradient background
- Form floating labels
- Social login buttons
- Responsive design
- Animation effects

### Danh sách khóa học
- Grid layout với cards
- Bộ lọc đa tiêu chí
- Pagination
- Search functionality
- Sort options

### Chi tiết khóa học
- Hero image với play button
- Sidebar với thông tin giá
- Course content accordion
- Reviews section
- Related courses

## Liên hệ và hỗ trợ
- **Người phát triển**: Đoàn Phước Miền
- **Email**: [email@example.com]
- **Dự án**: Nền Tảng Học Tập Trực Tuyến ASP.NET Core MVC

## License
Dự án này được phát triển cho mục đích học tập và thương mại.

---
*Cập nhật lần cuối: 24/09/2024*