# BÁO CÁO ĐỒ ÁN TỐT NGHIỆP

## WEBSITE CHIA SẺ KHÓA HỌC TRỰC TUYẾN SỬ DỤNG CÔNG NGHỆ ASP.NET CORE MVC

---

## MỤC LỤC

- [LỜI CẢM ƠN](#lời-cảm-ơn)
- [CHƯƠNG 1: MỞ ĐẦU](#chương-1-mở-đầu)
- [CHƯƠNG 2: CƠ SỞ LÝ THUYẾT VÀ CÔNG NGHỆ](#chương-2-cơ-sở-lý-thuyết-và-công-nghệ)
- [CHƯƠNG 3: PHÂN TÍCH VÀ THIẾT KẾ HỆ THỐNG](#chương-3-phân-tích-và-thiết-kế-hệ-thống)
- [CHƯƠNG 4: KẾT QUẢ THỰC NGHIỆM](#chương-4-kết-quả-thực-nghiệm)
- [CHƯƠNG 5: KẾT LUẬN VÀ HƯỚNG PHÁT TRIỂN](#chương-5-kết-luận-và-hướng-phát-triển)
- [TÀI LIỆU THAM KHẢO](#tài-liệu-tham-khảo)

---

## LỜI CẢM ƠN

Tôi xin gửi lời cảm ơn chân thành đến thầy/cô giáo hướng dẫn, Ban Giám hiệu, Khoa Công nghệ Thông tin và toàn thể các thầy cô giáo đã tạo điều kiện thuận lợi để tôi hoàn thành đồ án này. Đặc biệt cảm ơn gia đình, bạn bè đã luôn động viên và hỗ trợ trong suốt quá trình thực hiện.

---

## CHƯƠNG 1: MỞ ĐẦU

### 1.1. Lý do chọn đề tài

Trong bối cảnh cuộc cách mạng công nghiệp 4.0 và sau đại dịch COVID-19, học tập trực tuyến đã trở thành xu hướng tất yếu. Thị trường học tập trực tuyến toàn cầu tăng từ 101 tỷ USD (2019) lên 370 tỷ USD (2026). Tại Việt Nam, hơn 85% học sinh, sinh viên đã tham gia các khóa học trực tuyến.

Các nền tảng hiện tại vẫn còn hạn chế về tính năng và giao diện. Việc phát triển website chia sẻ khóa học với ASP.NET Core MVC sẽ ứng dụng kiến thức đã học vào dự án thực tế có ý nghĩa.

### 1.2. Mục tiêu của đề tài

**Mục tiêu chung:** Xây dựng hệ thống website chia sẻ khóa học trực tuyến hoàn chỉnh với công nghệ ASP.NET Core MVC.

**Mục tiêu cụ thể:**
- Nghiên cứu và ứng dụng ASP.NET Core MVC
- Thiết kế cơ sở dữ liệu với Entity Framework Core
- Xây dựng giao diện responsive, thân thiện
- Đảm bảo bảo mật và hiệu suất hệ thống
- Cung cấp nền tảng cho giảng viên và học viên

### 1.3. Đối tượng và phạm vi nghiên cứu

**Đối tượng:** Hệ thống website chia sẻ khóa học trực tuyến với ASP.NET Core MVC

**Phạm vi chức năng:**
- Hệ thống đăng ký, đăng nhập và quản lý tài khoản
- Quản lý khóa học: tạo, chỉnh sửa, xóa, phân loại
- Hệ thống tìm kiếm và lọc khóa học
- Quản lý học viên và tiến độ học tập
- Dashboard và báo cáo thống kê

**Giới hạn:** Chưa tích hợp thanh toán online, video streaming real-time, chat trực tiếp.

### 1.4. Bố cục của báo cáo

Báo cáo gồm 5 chương: Mở đầu, Cơ sở lý thuyết, Phân tích thiết kế, Kết quả thực nghiệm, Kết luận và hướng phát triển.

---

## CHƯƠNG 2: CƠ SỞ LÝ THUYẾT VÀ CÔNG NGHỆ

### 2.1. Tổng quan về Website chia sẻ khóa học trực tuyến

#### 2.1.1. Khái niệm và vai trò

Website chia sẻ khóa học trực tuyến là hệ thống web-based cho phép giảng viên tạo, quản lý và chia sẻ nội dung giáo dục, đồng thời cung cấp môi trường học tập tương tác cho học viên.

**Vai trò:**
- Dân chủ hóa giáo dục, không giới hạn thời gian địa điểm
- Học tập theo tốc độ cá nhân (self-paced learning)
- Giảm chi phí, tăng khả năng tiếp cận
- Hỗ trợ học tập suốt đời (lifelong learning)

#### 2.1.2. Các chức năng cơ bản

**Quản lý người dùng:** Đăng ký, đăng nhập, phân quyền, bảo mật
**Quản lý khóa học:** Tạo, chỉnh sửa, tổ chức nội dung, thiết lập giá
**Hệ thống học tập:** Giao diện tương tác, theo dõi tiến độ, ghi chú
**Tương tác cộng đồng:** Đánh giá, thảo luận, chia sẻ, wishlist
**Phân tích báo cáo:** Dashboard, thống kê, báo cáo chi tiết

#### 2.1.3. Các mô hình phổ biến

**Marketplace:** Nền tảng trung gian, giảng viên tự bán khóa học (Udemy)
**Subscription:** Phí định kỳ, truy cập không giới hạn (LinkedIn Learning)
**Freemium:** Kết hợp miễn phí và trả phí (Coursera)
**Corporate:** Đào tạo nội bộ doanh nghiệp

### 2.2. Công nghệ ASP.NET Core MVC

#### 2.2.1. Giới thiệu ASP.NET Core

ASP.NET Core là framework phát triển web mã nguồn mở, đa nền tảng của Microsoft. Ra mắt 2016, được thiết kế lại hoàn toàn với triết lý "cloud-first" và "mobile-first".

**Đặc điểm chính:**
- **Đa nền tảng:** Windows, Linux, macOS
- **Hiệu suất cao:** Kiến trúc modular, async/await
- **Mã nguồn mở:** Phát triển công khai trên GitHub
- **Dependency Injection:** Built-in DI container

#### 2.2.2. Kiến trúc MVC

**Model:** Dữ liệu và business logic
**View:** Giao diện hiển thị
**Controller:** Xử lý input, điều phối Model-View

**Ưu điểm:**
- Separation of Concerns
- Testability và Maintainability
- Reusability và Flexibility
- Parallel Development

#### 2.2.3. Các thành phần chính

**Model:** Entity Models, View Models, DTOs
**View:** Razor syntax, Layout, Partial Views, ViewComponents
**Controller:** Action Methods, Filters, Model Binding
**Routing:** Convention-based và Attribute Routing
**Middleware:** Pipeline xử lý request/response

### 2.3. Các công nghệ hỗ trợ

#### 2.3.1. Entity Framework Core

ORM framework cho .NET, hỗ trợ Code First, LINQ queries, Change Tracking, Migrations.

```csharp
public class ApplicationDbContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
}
```

#### 2.3.2. Frontend Technologies

**HTML5:** Semantic elements, form validation
**CSS3:** Flexbox, Grid, responsive design
**JavaScript ES6+:** Async/await, DOM manipulation, modules

#### 2.3.3. Bootstrap Framework

CSS framework với grid system, components, utilities cho responsive design.

#### 2.3.4. jQuery

JavaScript library cho DOM manipulation, AJAX, animations.

#### 2.3.5. SQL Server

Microsoft RDBMS với ACID compliance, high performance, security features.

---

## CHƯƠNG 3: PHÂN TÍCH VÀ THIẾT KẾ HỆ THỐNG

### 3.1. Phân tích yêu cầu hệ thống

#### 3.1.1. Yêu cầu chức năng

**Học viên:**
- Đăng ký/đăng nhập, quản lý profile
- Tìm kiếm, lọc, duyệt khóa học
- Đăng ký học, theo dõi tiến độ
- Đánh giá, wishlist, chia sẻ

**Giảng viên:**
- Tạo, quản lý khóa học
- Upload nội dung, tổ chức curriculum
- Theo dõi học viên, thống kê doanh thu
- Hỗ trợ học viên

**Quản trị viên:**
- Quản lý người dùng, phân quyền
- Duyệt khóa học, quản lý nội dung
- Dashboard, báo cáo hệ thống

#### 3.1.2. Yêu cầu phi chức năng

**Hiệu suất:** Tải trang <3s, hỗ trợ 1000+ user đồng thời
**Bảo mật:** HTTPS, mã hóa password, chống XSS/CSRF
**Khả dụng:** Responsive design, accessibility
**Độ tin cậy:** Uptime 99.9%, backup tự động
**Mở rộng:** Modular architecture, cloud-ready

### 3.2. Use Case Diagram

```
Học viên: [Đăng ký TK] [Tìm kiếm KH] [Đăng ký KH] [Học tập] [Đánh giá]
Giảng viên: [Tạo KH] [Quản lý nội dung] [Xem thống kê] [Hỗ trợ HV]
Admin: [Quản lý user] [Duyệt KH] [Quản lý hệ thống] [Báo cáo]
```

### 3.3. Thiết kế cơ sở dữ liệu

#### 3.3.1. ER Diagram

```
Users ----< Instructors ----< Courses >---- Categories
  |                             |
  +----< Enrollments >----------+
  +----< Wishlists >------------+
  +----< Reviews >--------------+

Courses ----< Modules ----< Lessons
```

#### 3.3.2. Các bảng chính

**Users:** Id, Email, PasswordHash, FullName, Role, CreatedAt
**Courses:** Id, Title, Slug, Description, Price, InstructorId, CategoryId
**Enrollments:** StudentId, CourseId, EnrolledAt, Progress
**Categories:** Id, Name, Slug, Description, Icon
**Wishlists:** UserId, CourseId, AddedAt

---

## CHƯƠNG 4: KẾT QUẢ THỰC NGHIỆM

### 4.1. Môi trường phát triển

**Phần cứng:** Intel i5-8400, 16GB RAM, SSD 512GB
**Phần mềm:** Windows 11, Visual Studio 2022, SQL Server 2022
**Công nghệ:** .NET 9.0, ASP.NET Core MVC, EF Core, Bootstrap 5.3

### 4.2. Kiến trúc ứng dụng

**3-Layer Architecture:**
- Presentation Layer (Views, Controllers)
- Business Logic Layer (Services, Models)
- Data Access Layer (DbContext, Repositories)

**Cấu trúc dự án:**
```
OnlineLearningPlatform/
├── Controllers/
├── Areas/Admin/
├── Models/
├── Views/
├── Data/
└── wwwroot/
```

### 4.3. Các giao diện chính

**Trang chủ:** Hero section, danh mục nổi bật, khóa học đề xuất
**Danh sách khóa học:** Grid responsive, filters, search, pagination
**Chi tiết khóa học:** Thông tin đầy đủ, curriculum, reviews, enrollment
**Dashboard:** Thống kê cá nhân cho từng loại user
**Admin Panel:** Quản lý user, courses, system với sidebar navigation

### 4.4. Tính năng đã triển khai

✅ **Hoàn thành:**
- Hệ thống authentication với ASP.NET Identity
- CRUD operations cho courses, users
- Responsive UI với Bootstrap
- Search và filtering
- Enrollment và wishlist system
- Admin dashboard với statistics
- Member area với personal dashboard

✅ **Chức năng chính:**
- Đăng ký/đăng nhập người dùng
- Tạo và quản lý khóa học
- Tìm kiếm, lọc khóa học theo nhiều tiêu chí
- Đăng ký học và quản lý wishlist
- Dashboard cho admin, instructor, student
- Responsive design trên mọi thiết bị

---

## CHƯƠNG 5: KẾT LUẬN VÀ HƯỚNG PHÁT TRIỂN

### 5.1. Kết luận

**Kết quả đạt được:**
- Xây dựng thành công website chia sẻ khóa học với ASP.NET Core MVC
- Triển khai đầy đủ các chức năng cơ bản cho 3 loại người dùng
- Giao diện responsive, thân thiện và hiện đại
- Đảm bảo bảo mật với Identity framework
- Cơ sở dữ liệu được thiết kế tối ưu với EF Core

**Ý nghĩa:**
- Ứng dụng thành công kiến thức lý thuyết vào thực tế
- Tạo ra sản phẩm có tính ứng dụng cao
- Rèn luyện kỹ năng phát triển full-stack web application

### 5.2. Hướng phát triển

**Tính năng bổ sung:**
- Tích hợp thanh toán VNPay, MoMo
- Video streaming với adaptive bitrate
- Live streaming cho webinars
- Mobile app với React Native/Flutter
- AI recommendations và chatbot

**Cải tiến kỹ thuật:**
- Implement Redis caching
- Microservices architecture
- Docker containerization
- CI/CD pipeline
- Performance monitoring

**Mở rộng thị trường:**
- Multi-language support
- Enterprise LMS features
- Advanced analytics
- Integration APIs
- White-label solutions

---

## TÀI LIỆU THAM KHẢO

1. Microsoft Corporation. (2024). *ASP.NET Core Documentation*. https://docs.microsoft.com/aspnet/core
2. Freeman, A. (2022). *Pro ASP.NET Core 6*. Apress.
3. Lock, A. (2021). *ASP.NET Core in Action, Second Edition*. Manning Publications.
4. Bootstrap Team. (2024). *Bootstrap Documentation*. https://getbootstrap.com/docs
5. Statista. (2023). *Online Education Market Size Worldwide*. https://www.statista.com

---

**Thông tin đồ án:**
- **Tên đề tài:** Website Chia sẻ Khóa học Trực tuyến
- **Công nghệ:** ASP.NET Core MVC 9.0
- **Cơ sở dữ liệu:** SQL Server với Entity Framework Core
- **Frontend:** Bootstrap 5, jQuery, HTML5/CSS3
- **Tính năng chính:** User management, Course management, Learning system, Admin panel
- **Trạng thái:** Hoàn thành các chức năng cơ bản

---

*Báo cáo hoàn thành: [Ngày tháng năm]*
*Sinh viên: Đoàn Phước Miền*
*Lớp: [Tên lớp]*
*Khoa Công nghệ Thông tin*