# BÁO CÁO ĐỒ ÁN TỐT NGHIỆP

## WEBSITE CHIA SẺ KHÓA HỌC TRỰC TUYẾN SỬ DỤNG CÔNG NGHỆ ASP.NET CORE MVC

**Sinh viên thực hiện:** Đoàn Phước Miền  
**Giảng viên hướng dẫn:** [Tên giảng viên]  
**Khoa:** Công nghệ Thông tin  
**Trường:** [Tên trường]  
**Năm:** 2024

---

## MỤC LỤC

- [LỜI CẢM ƠN](#lời-cảm-ơn)
- [CHƯƠNG 1: MỞ ĐẦU](#chương-1-mở-đầu)
  - [1.1. Lý do chọn đề tài](#11-lý-do-chọn-đề-tài)
  - [1.2. Mục tiêu của đề tài](#12-mục-tiêu-của-đề-tài)
  - [1.3. Đối tượng và phạm vi nghiên cứu](#13-đối-tượng-và-phạm-vi-nghiên-cứu)
  - [1.4. Bố cục của báo cáo](#14-bố-cục-của-báo-cáo)
- [CHƯƠNG 2: CƠ SỞ LÝ THUYẾT VÀ CÔNG NGHỆ](#chương-2-cơ-sở-lý-thuyết-và-công-nghệ)
  - [2.1. Tổng quan về Website chia sẻ khóa học trực tuyến](#21-tổng-quan-về-website-chia-sẻ-khóa-học-trực-tuyến)
  - [2.2. Công nghệ ASP.NET Core MVC](#22-công-nghệ-aspnet-core-mvc)
  - [2.3. Các công nghệ và công cụ hỗ trợ khác](#23-các-công-nghệ-và-công-cụ-hỗ-trợ-khác)
- [CHƯƠNG 3: PHÂN TÍCH VÀ THIẾT KẾ HỆ THỐNG](#chương-3-phân-tích-và-thiết-kế-hệ-thống)
  - [3.1. Phân tích yêu cầu hệ thống](#31-phân-tích-yêu-cầu-hệ-thống)
  - [3.2. Đặc tả các trường hợp sử dụng](#32-đặc-tả-các-trường-hợp-sử-dụng)
  - [3.3. Thiết kế cơ sở dữ liệu](#33-thiết-kế-cơ-sở-dữ-liệu)
- [CHƯƠNG 4: KẾT QUẢ THỰC NGHIỆM](#chương-4-kết-quả-thực-nghiệm)
  - [4.1. Môi trường phát triển](#41-môi-trường-phát-triển)
  - [4.2. Kiến trúc tổng quan của ứng dụng](#42-kiến-trúc-tổng-quan-của-ứng-dụng)
  - [4.3. Giao diện tổng quan người dùng](#43-giao-diện-tổng-quan-người-dùng)
  - [4.4. Trang chức năng học viên](#44-trang-chức-năng-học-viên)
  - [4.5. Trang chức năng giảng viên](#45-trang-chức-năng-giảng-viên)
  - [4.6. Trang quản trị viên](#46-trang-quản-trị-viên)
- [CHƯƠNG 5: KẾT LUẬN VÀ HƯỚNG PHÁT TRIỂN](#chương-5-kết-luận-và-hướng-phát-triển)
  - [5.1. Kết luận](#51-kết-luận)
  - [5.2. Hướng phát triển của đề tài](#52-hướng-phát-triển-của-đề-tài)
- [TÀI LIỆU THAM KHẢO](#tài-liệu-tham-khảo)
- [PHỤ LỤC](#phụ-lục)

---

## LỜI CẢM ƠN

Tôi xin gửi lời cảm ơn chân thành và sâu sắc nhất đến thầy/cô giáo hướng dẫn đã tận tình chỉ bảo, định hướng và hỗ trợ tôi trong suốt quá trình thực hiện đồ án tốt nghiệp này. Những kiến thức chuyên môn sâu rộng và kinh nghiệm thực tiễn quý báu của thầy/cô đã giúp tôi hoàn thành đề tài một cách tốt nhất.

Tôi cũng xin chân thành cảm ơn Ban Giám hiệu nhà trường, Khoa Công nghệ Thông tin và toàn thể các thầy cô giáo đã tạo điều kiện thuận lợi, cung cấp môi trường học tập và nghiên cứu tốt nhất để tôi có thể hoàn thành đồ án này.

Đặc biệt, tôi xin gửi lời cảm ơn đến gia đình, bạn bè và đồng nghiệp đã luôn động viên, khích lệ và hỗ trợ tôi về mặt tinh thần cũng như vật chất trong suốt quá trình học tập và thực hiện đồ án.

Mặc dù đã cố gắng hết sức, nhưng do hạn chế về thời gian và kinh nghiệm, đồ án này chắc chắn còn nhiều thiếu sót. Tôi rất mong nhận được sự góp ý, chỉ bảo của các thầy cô và bạn bè để đồ án được hoàn thiện hơn.

Xin chân thành cảm ơn!

---

## CHƯƠNG 1: MỞ ĐẦU

### 1.1. Lý do chọn đề tài

Trong bối cảnh cuộc cách mạng công nghiệp 4.0 đang diễn ra mạnh mẽ và đặc biệt sau đại dịch COVID-19, việc học tập trực tuyến đã trở thành một xu hướng tất yếu và không thể đảo ngược. Theo báo cáo của Global Market Insights, thị trường học tập trực tuyến toàn cầu đã tăng từ 101 tỷ USD năm 2019 lên dự kiến 370 tỷ USD vào năm 2026, với tốc độ tăng trưởng kép hàng năm (CAGR) đạt 9.1%.

Tại Việt Nam, theo khảo sát của Bộ Giáo dục và Đào tạo năm 2023, hơn 85% học sinh, sinh viên đã từng tham gia các khóa học trực tuyến, và 67% trong số đó cho rằng học tập trực tuyến mang lại hiệu quả tương đương hoặc cao hơn so với học tập truyền thống. Điều này cho thấy nhu cầu to lớn về các nền tảng học tập trực tuyến chất lượng cao.

Tuy nhiên, các nền tảng học tập trực tuyến hiện tại tại Việt Nam vẫn còn nhiều hạn chế:

**Về mặt công nghệ:**
- Giao diện chưa thân thiện, trải nghiệm người dùng chưa tối ưu
- Thiếu tính năng tương tác và cá nhân hóa
- Hiệu suất hệ thống chưa ổn định, thường xảy ra tình trạng quá tải
- Bảo mật thông tin người dùng chưa được đảm bảo tốt

**Về mặt nội dung:**
- Chất lượng khóa học không đồng đều
- Thiếu hệ thống đánh giá và phản hồi hiệu quả
- Nội dung chưa được cập nhật thường xuyên
- Thiếu sự kết nối giữa giảng viên và học viên

**Về mặt quản lý:**
- Hệ thống theo dõi tiến độ học tập chưa chi tiết
- Thiếu báo cáo phân tích dữ liệu học tập
- Quản lý người dùng và phân quyền chưa linh hoạt

Việc phát triển một website chia sẻ khóa học trực tuyến sử dụng công nghệ ASP.NET Core MVC không chỉ giúp khắc phục những hạn chế trên mà còn mang lại nhiều lợi ích:

1. **Ứng dụng kiến thức thực tế:** Đề tài cho phép ứng dụng toàn bộ kiến thức đã học về lập trình web, cơ sở dữ liệu, và phát triển phần mềm vào một dự án thực tế có ý nghĩa.

2. **Đáp ứng nhu cầu xã hội:** Tạo ra một sản phẩm có thể đóng góp vào việc nâng cao chất lượng giáo dục trực tuyến tại Việt Nam.

3. **Phát triển kỹ năng chuyên môn:** Rèn luyện kỹ năng phân tích, thiết kế, và triển khai hệ thống phần mềm quy mô lớn.

### 1.2. Mục tiêu của đề tài

#### 1.2.1. Mục tiêu chung

Xây dựng một hệ thống website chia sẻ khóa học trực tuyến hoàn chỉnh, hiện đại và hiệu quả sử dụng công nghệ ASP.NET Core MVC, nhằm cung cấp một nền tảng học tập trực tuyến chất lượng cao cho cộng đồng.

#### 1.2.2. Mục tiêu cụ thể

**Về mặt công nghệ:**
- Nghiên cứu và ứng dụng thành công công nghệ ASP.NET Core MVC trong phát triển web
- Thiết kế và triển khai cơ sở dữ liệu hiệu quả với Entity Framework Core
- Xây dựng giao diện người dùng responsive, thân thiện và hiện đại
- Đảm bảo tính bảo mật và hiệu suất cao của hệ thống
- Tích hợp các công nghệ web hiện đại như Bootstrap, jQuery, và AJAX

**Về mặt chức năng:**
- Cung cấp nền tảng cho giảng viên tạo và quản lý khóa học
- Tạo môi trường học tập tương tác cho học viên
- Xây dựng hệ thống quản trị toàn diện cho administrator
- Phát triển các tính năng hỗ trợ như tìm kiếm, đánh giá, thống kê

**Về mặt học thuật:**
- Áp dụng các mô hình thiết kế phần mềm tiên tiến
- Thực hành quy trình phát triển phần mềm chuyên nghiệp
- Tạo ra sản phẩm có thể sử dụng thực tế và mở rộng trong tương lai

### 1.3. Đối tượng và phạm vi nghiên cứu

#### 1.3.1. Đối tượng nghiên cứu

Đối tượng chính của đề tài là hệ thống website chia sẻ khóa học trực tuyến được phát triển bằng công nghệ ASP.NET Core MVC, bao gồm:

- **Kiến trúc hệ thống:** Mô hình MVC, các design patterns
- **Cơ sở dữ liệu:** Thiết kế và tối ưu hóa database
- **Giao diện người dùng:** UX/UI design và responsive web
- **Tính năng nghiệp vụ:** Các chức năng cốt lõi của nền tảng e-learning

#### 1.3.2. Phạm vi nghiên cứu

**Phạm vi chức năng bao gồm:**

*Đối với học viên:*
- Hệ thống đăng ký, đăng nhập và quản lý tài khoản cá nhân
- Tìm kiếm, duyệt và lọc khóa học theo nhiều tiêu chí
- Đăng ký học và theo dõi tiến độ học tập
- Đánh giá khóa học và giảng viên
- Quản lý danh sách yêu thích (wishlist)
- Dashboard cá nhân với thống kê học tập

*Đối với giảng viên:*
- Tạo và quản lý khóa học
- Upload và tổ chức nội dung bài giảng
- Theo dõi học viên và tương tác với cộng đồng
- Xem báo cáo thống kê và doanh thu
- Quản lý profile và thông tin cá nhân

*Đối với quản trị viên:*
- Quản lý người dùng và phân quyền hệ thống
- Duyệt và quản lý nội dung khóa học
- Dashboard tổng quan với các báo cáo chi tiết
- Quản lý danh mục và cấu hình hệ thống
- Giám sát hoạt động và bảo mật hệ thống

**Phạm vi kỹ thuật:**
- Sử dụng ASP.NET Core 9.0 MVC framework
- Entity Framework Core cho data access layer
- SQL Server làm hệ quản trị cơ sở dữ liệu
- Bootstrap 5 cho responsive design
- jQuery và AJAX cho tương tác động
- ASP.NET Core Identity cho authentication và authorization

**Giới hạn của đề tài:**
- Chưa tích hợp hệ thống thanh toán trực tuyến
- Chưa hỗ trợ video streaming real-time
- Chưa có tính năng chat trực tiếp giữa giảng viên và học viên
- Chưa tích hợp với các hệ thống LMS bên ngoài
- Chưa hỗ trợ đa ngôn ngữ (chỉ tiếng Việt)

### 1.4. Bố cục của báo cáo

Báo cáo đồ án được tổ chức thành 5 chương chính với nội dung như sau:

**Chương 1 - Mở đầu:** Trình bày lý do chọn đề tài, mục tiêu nghiên cứu, đối tượng và phạm vi nghiên cứu, cùng với bố cục tổng thể của báo cáo.

**Chương 2 - Cơ sở lý thuyết và công nghệ:** Nghiên cứu lý thuyết về các website chia sẻ khóa học trực tuyến, công nghệ ASP.NET Core MVC và các công nghệ hỗ trợ khác được sử dụng trong dự án.

**Chương 3 - Phân tích và thiết kế hệ thống:** Phân tích yêu cầu hệ thống, thiết kế các use case, thiết kế cơ sở dữ liệu và kiến trúc tổng thể của ứng dụng.

**Chương 4 - Kết quả thực nghiệm:** Trình bày môi trường phát triển, kiến trúc ứng dụng đã triển khai, các giao diện chính và chức năng đã hoàn thành.

**Chương 5 - Kết luận và hướng phát triển:** Đánh giá kết quả đạt được, những hạn chế còn tồn tại và đề xuất hướng phát triển trong tương lai.

---

## CHƯƠNG 2: CƠ SỞ LÝ THUYẾT VÀ CÔNG NGHỆ

### 2.1. Tổng quan về Website chia sẻ khóa học trực tuyến

#### 2.1.1. Khái niệm và vai trò

**Khái niệm:**

Website chia sẻ khóa học trực tuyến (Online Learning Platform) là một hệ thống web-based cho phép các giảng viên, chuyên gia tạo, quản lý và chia sẻ nội dung giáo dục, đồng thời cung cấp môi trường học tập tương tác cho người học thông qua internet. Đây là một dạng của hệ thống quản lý học tập (Learning Management System - LMS) tập trung vào việc phân phối và chia sẻ kiến thức.

Theo định nghĩa của IEEE Learning Technology Standards Committee, một nền tảng học tập trực tuyến là "một hệ thống phần mềm được thiết kế để hỗ trợ việc quản lý, phân phối và theo dõi các hoạt động học tập, bao gồm cả học tập trực tuyến và học tập kết hợp (blended learning)."

**Vai trò trong giáo dục hiện đại:**

1. **Dân chủ hóa giáo dục:** Loại bỏ rào cản về địa lý, thời gian và kinh tế, cho phép mọi người tiếp cận với kiến thức chất lượng cao từ bất kỳ đâu.

2. **Học tập cá nhân hóa:** Cho phép người học tự điều chỉnh tốc độ học tập (self-paced learning), lựa chọn nội dung phù hợp với nhu cầu và khả năng cá nhân.

3. **Tiết kiệm chi phí:** Giảm đáng kể chi phí đào tạo so với phương pháp truyền thống, đặc biệt quan trọng trong bối cảnh kinh tế khó khăn.

4. **Linh hoạt thời gian:** Hỗ trợ học tập suốt đời (lifelong learning), phù hợp với nhịp sống hiện đại và nhu cầu nâng cao kỹ năng liên tục.

5. **Tương tác và cộng đồng:** Tạo ra các cộng đồng học tập trực tuyến, khuyến khích trao đổi kiến thức và kinh nghiệm.

#### 2.1.2. Các chức năng cơ bản của một website chia sẻ khóa học

**1. Quản lý người dùng và phân quyền:**
- Hệ thống đăng ký, đăng nhập với xác thực bảo mật
- Quản lý profile cá nhân và thông tin học tập
- Phân quyền theo vai trò: học viên, giảng viên, quản trị viên
- Hệ thống khôi phục mật khẩu và bảo mật tài khoản

**2. Quản lý khóa học và nội dung:**
- Tạo, chỉnh sửa và tổ chức cấu trúc khóa học
- Upload và quản lý tài liệu đa phương tiện (video, audio, PDF, slides)
- Thiết lập giá cả, khuyến mãi và điều kiện truy cập
- Phân loại khóa học theo chủ đề và độ khó

**3. Hệ thống học tập tương tác:**
- Giao diện học tập thân thiện và dễ sử dụng
- Theo dõi tiến độ học tập và hoàn thành bài học
- Hệ thống ghi chú và đánh dấu nội dung quan trọng
- Tính năng tua nhanh, tạm dừng và điều khiển phát media

**4. Tương tác cộng đồng:**
- Hệ thống đánh giá và review khóa học
- Diễn đàn thảo luận và Q&A
- Chia sẻ khóa học trên mạng xã hội
- Wishlist và theo dõi giảng viên yêu thích

**5. Phân tích và báo cáo:**
- Dashboard cá nhân cho từng loại người dùng
- Thống kê tiến độ học tập và thành tích
- Báo cáo doanh thu và hiệu quả khóa học
- Analytics về hành vi người dùng

#### 2.1.3. Các mô hình website chia sẻ khóa học phổ biến

**1. Mô hình Marketplace (Chợ khóa học):**

*Đặc điểm:*
- Nền tảng trung gian kết nối giảng viên và học viên
- Giảng viên tự tạo và bán khóa học, nền tảng nhận hoa hồng
- Đa dạng chủ đề và giảng viên từ khắp nơi trên thế giới
- Cạnh tranh về giá và chất lượng

*Ví dụ điển hình:* Udemy, Skillshare, Teachable

*Ưu điểm:*
- Đa dạng nội dung và giảng viên
- Giá cả cạnh tranh
- Dễ dàng tìm kiếm khóa học phù hợp
- Cơ hội kiếm thu nhập cho giảng viên

*Nhược điểm:*
- Chất lượng không đồng đều
- Cạnh tranh gay gắt giữa các giảng viên
- Khó kiểm soát chất lượng nội dung

**2. Mô hình Subscription (Đăng ký định kỳ):**

*Đặc điểm:*
- Người dùng trả phí định kỳ (tháng/năm) để truy cập toàn bộ thư viện khóa học
- Nội dung được tuyển chọn và sản xuất chuyên nghiệp
- Tập trung vào chất lượng và tính nhất quán

*Ví dụ điển hình:* LinkedIn Learning, Pluralsight, MasterClass

*Ưu điểm:*
- Chất lượng nội dung được đảm bảo
- Truy cập không giới hạn với một mức phí cố định
- Trải nghiệm người dùng nhất quán
- Cập nhật nội dung thường xuyên

*Nhược điểm:*
- Chi phí cao cho người dùng thỉnh thoảng
- Ít đa dạng về chủ đề so với marketplace
- Rào cản gia nhập cao cho giảng viên

**3. Mô hình Freemium:**

*Đặc điểm:*
- Kết hợp giữa nội dung miễn phí và trả phí
- Nội dung cơ bản miễn phí, nâng cao cần trả phí
- Thu hút người dùng bằng nội dung miễn phí, chuyển đổi sang trả phí

*Ví dụ điển hình:* Coursera, edX, Khan Academy

*Ưu điểm:*
- Dễ tiếp cận với người dùng mới
- Cơ hội trải nghiệm trước khi quyết định mua
- Mô hình kinh doanh bền vững

*Nhược điểm:*
- Tỷ lệ chuyển đổi từ miễn phí sang trả phí thường thấp
- Cần đầu tư lớn vào nội dung miễn phí
- Khó cân bằng giữa miễn phí và trả phí

**4. Mô hình Corporate Learning:**

*Đặc điểm:*
- Tập trung vào đào tạo nội bộ doanh nghiệp
- Nội dung được tùy chỉnh theo nhu cầu cụ thể của tổ chức
- Tích hợp với hệ thống HR và quản lý nhân sự

*Ví dụ điển hình:* Cornerstone OnDemand, Docebo, TalentLMS

*Ưu điểm:*
- Tùy chỉnh cao theo nhu cầu doanh nghiệp
- Tích hợp với hệ thống hiện có
- ROI rõ ràng cho doanh nghiệp

*Nhược điểm:*
- Chi phí triển khai cao
- Phức tạp trong việc tùy chỉnh và bảo trì
- Phụ thuộc vào quy mô tổ chức

### 2.2. Công nghệ ASP.NET Core MVC

#### 2.2.1. Giới thiệu về ASP.NET Core

**Lịch sử và phát triển:**

ASP.NET Core là framework phát triển web mã nguồn mở, đa nền tảng của Microsoft, được ra mắt lần đầu vào năm 2016. Đây là sự tiến hóa hoàn toàn mới của ASP.NET Framework truyền thống, được thiết kế lại từ đầu với triết lý "cloud-first" và "mobile-first".

**Đặc điểm chính:**

1. **Đa nền tảng (Cross-platform):**
   - Chạy trên Windows, Linux, và macOS
   - Hỗ trợ deployment trên cloud và on-premises
   - Tương thích với Docker containers

2. **Hiệu suất cao (High Performance):**
   - Kiến trúc modular giúp giảm overhead
   - Hỗ trợ async/await pattern tối ưu
   - Memory management hiệu quả
   - Benchmark cho thấy hiệu suất vượt trội so với các framework khác

3. **Mã nguồn mở (Open Source):**
   - Phát triển công khai trên GitHub
   - Cộng đồng developer tích cực đóng góp
   - Minh bạch trong quá trình phát triển và bug fixing

4. **Dependency Injection tích hợp:**
   - Built-in DI container
   - Hỗ trợ Inversion of Control (IoC)
   - Dễ dàng testing và maintainability

5. **Configuration linh hoạt:**
   - Hỗ trợ multiple configuration sources
   - Environment-specific configurations
   - Strongly-typed configuration objects

**Kiến trúc ASP.NET Core:**

```
┌─────────────────────────────────────────┐
│           Hosting Layer                 │
│  (Kestrel, IIS, Apache, Nginx)        │
├─────────────────────────────────────────┤
│           Middleware Pipeline           │
│  (Authentication, Routing, CORS, etc.)  │
├─────────────────────────────────────────┤
│           MVC Framework                 │
│  (Controllers, Views, Models)          │
├─────────────────────────────────────────┤
│           Services Layer                │
│  (Business Logic, Data Access)         │
├─────────────────────────────────────────┤
│           Data Layer                    │
│  (Entity Framework, Repositories)      │
└─────────────────────────────────────────┘
```

#### 2.2.2. Kiến trúc Model-View-Controller (MVC)

**Khái niệm MVC:**

Model-View-Controller là một architectural pattern được sử dụng rộng rãi trong phát triển phần mềm, đặc biệt là web applications. MVC tách biệt ứng dụng thành ba thành phần chính, mỗi thành phần có trách nhiệm riêng biệt.

**Các thành phần của MVC:**

1. **Model:**
   - Đại diện cho dữ liệu và business logic
   - Quản lý state của ứng dụng
   - Độc lập với presentation layer
   - Thông báo cho View khi có thay đổi dữ liệu

2. **View:**
   - Chịu trách nhiệm hiển thị dữ liệu cho người dùng
   - Nhận dữ liệu từ Model thông qua Controller
   - Không chứa business logic
   - Có thể có nhiều View cho cùng một Model

3. **Controller:**
   - Xử lý input từ người dùng
   - Điều phối giữa Model và View
   - Chứa application logic
   - Quyết định View nào sẽ được hiển thị

**Luồng xử lý trong MVC:**

```
User Request → Controller → Model → Controller → View → Response
```

**Ưu điểm của MVC:**

1. **Separation of Concerns:**
   - Tách biệt rõ ràng các concern khác nhau
   - Dễ dàng maintain và debug
   - Giảm coupling giữa các components

2. **Testability:**
   - Dễ dàng unit testing từng component riêng biệt
   - Mock objects có thể được sử dụng hiệu quả
   - Test-driven development (TDD) friendly

3. **Reusability:**
   - Models có thể được sử dụng bởi nhiều Views
   - Views có thể được tái sử dụng với different Models
   - Controllers có thể handle multiple Views

4. **Flexibility:**
   - Dễ dàng thay đổi UI without affecting business logic
   - Có thể thêm new features without major restructuring
   - Support multiple presentation formats (HTML, JSON, XML)

5. **Parallel Development:**
   - Teams có thể work independently trên different layers
   - Frontend và backend development có thể parallel
   - Faster development cycle

#### 2.2.3. Các thành phần chính trong ASP.NET Core MVC

**1. Model:**

Models trong ASP.NET Core MVC bao gồm nhiều loại:

*Entity Models:* Đại diện cho database entities
```csharp
public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }
}
```

*View Models:* Chứa dữ liệu specific cho View
```csharp
public class CourseListViewModel
{
    public IEnumerable<Course> Courses { get; set; }
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
```

*DTOs (Data Transfer Objects):* Để transfer data giữa layers
```csharp
public class CreateCourseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
```

**2. View:**

Views sử dụng Razor syntax để render HTML:

*Razor Syntax:*
```html
@model CourseListViewModel

<h1>Danh sách khóa học</h1>
@foreach(var course in Model.Courses)
{
    <div class="course-item">
        <h3>@course.Title</h3>
        <p>@course.Description</p>
        <span class="price">@course.Price.ToString("C")</span>
    </div>
}
```

*Layout Pages:* Định nghĩa structure chung
```html
<!DOCTYPE html>
<html>
<head>
    <title>@ViewData["Title"]</title>
</head>
<body>
    <header>@await RenderSectionAsync("Header", required: false)</header>
    <main>@RenderBody()</main>
    <footer>@await RenderSectionAsync("Footer", required: false)</footer>
</body>
</html>
```

*Partial Views:* Reusable view components
```html
@model Course
<div class="course-card">
    <h4>@Model.Title</h4>
    <p>@Model.Description</p>
    <a href="/courses/@Model.Id" class="btn btn-primary">Xem chi tiết</a>
</div>
```

*ViewComponents:* Complex reusable components
```csharp
public class CourseListViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(int categoryId)
    {
        var courses = GetCoursesByCategory(categoryId);
        return View(courses);
    }
}
```

**3. Controller:**

Controllers xử lý HTTP requests và return responses:

```csharp
public class CoursesController : Controller
{
    private readonly ICourseService _courseService;
    
    public CoursesController(ICourseService courseService)
    {
        _courseService = courseService;
    }
    
    public async Task<IActionResult> Index(int page = 1)
    {
        var courses = await _courseService.GetCoursesAsync(page);
        return View(courses);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(CreateCourseDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);
            
        await _courseService.CreateCourseAsync(dto);
        return RedirectToAction(nameof(Index));
    }
}
```

**4. Routing:**

ASP.NET Core hỗ trợ hai loại routing:

*Convention-based Routing:*
```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
```

*Attribute Routing:*
```csharp
[Route("courses")]
public class CoursesController : Controller
{
    [Route("")]
    [Route("list")]
    public IActionResult Index() { }
    
    [Route("{id:int}")]
    public IActionResult Details(int id) { }
}
```

**5. Middleware:**

Middleware components xử lý requests trong pipeline:

```csharp
public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;
    
    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    public async Task InvokeAsync(HttpContext context)
    {
        // Log request
        Console.WriteLine($"Request: {context.Request.Path}");
        
        await _next(context);
        
        // Log response
        Console.WriteLine($"Response: {context.Response.StatusCode}");
    }
}
```

#### 2.2.4. Ưu nhược điểm của ASP.NET Core MVC

**Ưu điểm:**

1. **Hiệu suất cao:**
   - Kiến trúc lightweight và modular
   - Async/await support tối ưu
   - Memory management hiệu quả
   - Kestrel web server performance cao

2. **Đa nền tảng:**
   - Chạy trên Windows, Linux, macOS
   - Deployment flexibility
   - Container support (Docker)
   - Cloud-native architecture

3. **Mã nguồn mở:**
   - Miễn phí sử dụng
   - Community support mạnh
   - Transparent development process
   - Regular updates và improvements

4. **Kiến trúc MVC rõ ràng:**
   - Separation of concerns tốt
   - Testability cao
   - Maintainability và scalability
   - Code organization tốt

5. **Ecosystem phong phú:**
   - NuGet package manager
   - Visual Studio integration
   - Third-party libraries đa dạng
   - Microsoft ecosystem support

6. **Security features:**
   - Built-in security features
   - HTTPS enforcement
   - CSRF protection
   - XSS prevention
   - Authentication và Authorization

**Nhược điểm:**

1. **Learning curve:**
   - Phức tạp cho beginners
   - Nhiều concepts cần nắm vững
   - Configuration có thể overwhelming
   - Debugging có thể khó khăn

2. **Microsoft ecosystem dependency:**
   - Tối ưu nhất trên Windows và Azure
   - Visual Studio licensing costs
   - Some features Windows-specific
   - Vendor lock-in potential

3. **Memory consumption:**
   - .NET runtime overhead
   - Garbage collection impact
   - Larger deployment size
   - Resource intensive cho small applications

4. **Rapid changes:**
   - Frequent version updates
   - Breaking changes giữa versions
   - Documentation có thể outdated
   - Migration complexity

5. **Overkill cho simple projects:**
   - Complex architecture cho small apps
   - Setup overhead
   - Performance overhead cho simple scenarios
   - Alternative frameworks có thể suitable hơn

### 2.3. Các công nghệ và công cụ hỗ trợ khác

#### 2.3.1. Entity Framework Core (ORM)

**Giới thiệu:**

Entity Framework Core (EF Core) là một Object-Relational Mapping (ORM) framework hiện đại, lightweight và mã nguồn mở của Microsoft. EF Core cho phép developers làm việc với database sử dụng .NET objects, loại bỏ nhu cầu viết SQL code trực tiếp.

**Đặc điểm chính:**

1. **Code First Approach:**
   - Định nghĩa models bằng C# classes
   - Database schema được generate từ models
   - Migrations tự động cho database changes

2. **LINQ Support:**
   - Strongly-typed queries
   - IntelliSense support
   - Compile-time error checking
   - Readable và maintainable code

3. **Change Tracking:**
   - Tự động track changes trong entities
   - Optimized SQL generation
   - Batch operations support
   - Concurrency conflict detection

4. **Database Providers:**
   - SQL Server, MySQL, PostgreSQL, SQLite
   - In-memory database cho testing
   - Third-party providers available
   - Cross-database compatibility

**Ví dụ sử dụng:**

```csharp
// DbContext definition
public class ApplicationDbContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enrollment>()
            .HasKey(e => new { e.UserId, e.CourseId });
            
        modelBuilder.Entity<Course>()
            .Property(c => c.Price)
            .HasColumnType("decimal(18,2)");
    }
}

// Repository pattern
public class CourseRepository : ICourseRepository
{
    private readonly ApplicationDbContext _context;
    
    public async Task<IEnumerable<Course>> GetAllAsync()
    {
        return await _context.Courses
            .Include(c => c.Instructor)
            .Include(c => c.Category)
            .ToListAsync();
    }
    
    public async Task<Course> GetByIdAsync(int id)
    {
        return await _context.Courses
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}
```

#### 2.3.2. HTML, CSS, JavaScript (Front-end Development)

**HTML5:**

HTML5 cung cấp semantic elements và APIs mới:

```html
<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Khóa học trực tuyến</title>
</head>
<body>
    <header>
        <nav>
            <ul>
                <li><a href="/">Trang chủ</a></li>
                <li><a href="/courses">Khóa học</a></li>
            </ul>
        </nav>
    </header>
    
    <main>
        <section class="hero">
            <h1>Học tập trực tuyến hiệu quả</h1>
            <p>Khám phá hàng nghìn khóa học chất lượng cao</p>
        </section>
        
        <section class="courses">
            <article class="course-card">
                <h3>ASP.NET Core MVC</h3>
                <p>Học lập trình web với ASP.NET Core</p>
            </article>
        </section>
    </main>
    
    <footer>
        <p>&copy; 2024 Online Learning Platform</p>
    </footer>
</body>
</html>
```

**CSS3:**

CSS3 với Flexbox và Grid cho responsive design:

```css
/* CSS Grid Layout */
.course-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 2rem;
    padding: 2rem;
}

/* Flexbox Layout */
.course-card {
    display: flex;
    flex-direction: column;
    background: white;
    border-radius: 8px;
    box-shadow: 0 2px 10px rgba(0,0,0,0.1);
    transition: transform 0.3s ease;
}

.course-card:hover {
    transform: translateY(-5px);
}

/* Responsive Design */
@media (max-width: 768px) {
    .course-grid {
        grid-template-columns: 1fr;
        padding: 1rem;
    }
}

/* CSS Variables */
:root {
    --primary-color: #007bff;
    --secondary-color: #6c757d;
    --success-color: #28a745;
    --danger-color: #dc3545;
}

.btn-primary {
    background-color: var(--primary-color);
    border-color: var(--primary-color);
}
```

**JavaScript ES6+:**

Modern JavaScript với async/await và modules:

```javascript
// ES6 Classes
class CourseManager {
    constructor(apiUrl) {
        this.apiUrl = apiUrl;
    }
    
    async getCourses(page = 1) {
        try {
            const response = await fetch(`${this.apiUrl}/courses?page=${page}`);
            const data = await response.json();
            return data;
        } catch (error) {
            console.error('Error fetching courses:', error);
            throw error;
        }
    }
    
    async enrollCourse(courseId) {
        const response = await fetch(`${this.apiUrl}/enrollments`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'X-Requested-With': 'XMLHttpRequest'
            },
            body: JSON.stringify({ courseId })
        });
        
        return response.json();
    }
}

// DOM Manipulation
document.addEventListener('DOMContentLoaded', () => {
    const courseManager = new CourseManager('/api');
    
    // Event delegation
    document.addEventListener('click', async (e) => {
        if (e.target.classList.contains('enroll-btn')) {
            e.preventDefault();
            const courseId = e.target.dataset.courseId;
            
            try {
                await courseManager.enrollCourse(courseId);
                showNotification('Đăng ký thành công!', 'success');
            } catch (error) {
                showNotification('Có lỗi xảy ra!', 'error');
            }
        }
    });
});

// Utility functions
const showNotification = (message, type) => {
    const notification = document.createElement('div');
    notification.className = `notification notification-${type}`;
    notification.textContent = message;
    
    document.body.appendChild(notification);
    
    setTimeout(() => {
        notification.remove();
    }, 3000);
};
```

#### 2.3.3. Bootstrap (Framework CSS)

**Giới thiệu:**

Bootstrap là CSS framework phổ biến nhất thế giới, cung cấp responsive grid system, pre-built components và utilities để phát triển web nhanh chóng.

**Grid System:**

```html
<div class="container">
    <div class="row">
        <div class="col-md-8">
            <h2>Nội dung chính</h2>
            <p>Danh sách khóa học...</p>
        </div>
        <div class="col-md-4">
            <h3>Sidebar</h3>
            <ul class="list-group">
                <li class="list-group-item">Danh mục 1</li>
                <li class="list-group-item">Danh mục 2</li>
            </ul>
        </div>
    </div>
</div>
```

**Components:**

```html
<!-- Navigation -->
<nav class="navbar navbar-expand-lg navbar-dark bg-primary">
    <div class="container">
        <a class="navbar-brand" href="/">Learning Platform</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav ms-auto">
                <li class="nav-item">
                    <a class="nav-link" href="/courses">Khóa học</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/login">Đăng nhập</a>
                </li>
            </ul>
        </div>
    </div>
</nav>

<!-- Cards -->
<div class="card">
    <img src="course-image.jpg" class="card-img-top" alt="Course Image">
    <div class="card-body">
        <h5 class="card-title">Tên khóa học</h5>
        <p class="card-text">Mô tả ngắn về khóa học...</p>
        <a href="#" class="btn btn-primary">Xem chi tiết</a>
    </div>
</div>

<!-- Forms -->
<form class="needs-validation" novalidate>
    <div class="mb-3">
        <label for="email" class="form-label">Email</label>
        <input type="email" class="form-control" id="email" required>
        <div class="invalid-feedback">
            Vui lòng nhập email hợp lệ.
        </div>
    </div>
    <button type="submit" class="btn btn-primary">Đăng nhập</button>
</form>
```

#### 2.3.4. jQuery (Thư viện JavaScript)

**Giới thiệu:**

jQuery là JavaScript library giúp đơn giản hóa DOM manipulation, event handling, AJAX calls và animations.

**DOM Manipulation:**

```javascript
$(document).ready(function() {
    // Selector và manipulation
    $('.course-card').hover(
        function() {
            $(this).addClass('shadow-lg');
        },
        function() {
            $(this).removeClass('shadow-lg');
        }
    );
    
    // Event handling
    $('.enroll-btn').click(function(e) {
        e.preventDefault();
        const courseId = $(this).data('course-id');
        enrollInCourse(courseId);
    });
    
    // Dynamic content
    $('#load-more').click(function() {
        const page = $(this).data('page');
        loadMoreCourses(page);
    });
});

// AJAX operations
function enrollInCourse(courseId) {
    $.ajax({
        url: '/api/enrollments',
        method: 'POST',
        data: { courseId: courseId },
        success: function(response) {
            showAlert('Đăng ký thành công!', 'success');
            updateEnrollmentButton(courseId);
        },
        error: function(xhr, status, error) {
            showAlert('Có lỗi xảy ra: ' + error, 'danger');
        }
    });
}

function loadMoreCourses(page) {
    $.get('/api/courses', { page: page })
        .done(function(data) {
            $('#course-list').append(data.html);
            $('#load-more').data('page', page + 1);
        })
        .fail(function() {
            showAlert('Không thể tải thêm khóa học', 'warning');
        });
}

// Utility functions
function showAlert(message, type) {
    const alertHtml = `
        <div class="alert alert-${type} alert-dismissible fade show" role="alert">
            ${message}
            <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
        </div>
    `;
    $('#alerts-container').append(alertHtml);
}
```

#### 2.3.5. SQL Server (Hệ quản trị cơ sở dữ liệu)

**Giới thiệu:**

Microsoft SQL Server là hệ quản trị cơ sở dữ liệu quan hệ (RDBMS) mạnh mẽ, cung cấp hiệu suất cao, bảo mật tốt và khả năng mở rộng cho các ứng dụng enterprise.

**Đặc điểm chính:**

1. **ACID Compliance:** Đảm bảo tính nhất quán và độ tin cậy của dữ liệu
2. **High Performance:** Query optimizer và indexing strategies tiên tiến
3. **Security:** Row-level security, encryption, auditing
4. **Scalability:** Horizontal và vertical scaling options
5. **Integration:** Tích hợp tốt với Microsoft ecosystem

**Ví dụ Database Schema:**

```sql
-- Tạo database
CREATE DATABASE OnlineLearningPlatform;
USE OnlineLearningPlatform;

-- Bảng Users
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(256) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(MAX) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL DEFAULT 'Student',
    CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
    IsActive BIT DEFAULT 1
);

-- Bảng Categories
CREATE TABLE Categories (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Slug NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(500),
    Icon NVARCHAR(50),
    CreatedAt DATETIME2 DEFAULT GETUTCDATE()
);

-- Bảng Courses
CREATE TABLE Courses (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Slug NVARCHAR(200) NOT NULL UNIQUE,
    Description NVARCHAR(MAX),
    Price DECIMAL(18,2) NOT NULL DEFAULT 0,
    InstructorId INT NOT NULL,
    CategoryId INT NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
    UpdatedAt DATETIME2 DEFAULT GETUTCDATE(),
    IsPublished BIT DEFAULT 0,
    
    FOREIGN KEY (InstructorId) REFERENCES Users(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

-- Bảng Enrollments
CREATE TABLE Enrollments (
    UserId INT NOT NULL,
    CourseId INT NOT NULL,
    EnrolledAt DATETIME2 DEFAULT GETUTCDATE(),
    Progress DECIMAL(5,2) DEFAULT 0,
    CompletedAt DATETIME2 NULL,
    
    PRIMARY KEY (UserId, CourseId),
    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (CourseId) REFERENCES Courses(Id)
);

-- Indexes cho performance
CREATE INDEX IX_Courses_CategoryId ON Courses(CategoryId);
CREATE INDEX IX_Courses_InstructorId ON Courses(InstructorId);
CREATE INDEX IX_Enrollments_UserId ON Enrollments(UserId);
CREATE INDEX IX_Enrollments_CourseId ON Enrollments(CourseId);

-- Stored Procedures
CREATE PROCEDURE GetCoursesByCategory
    @CategoryId INT,
    @PageNumber INT = 1,
    @PageSize INT = 10
AS
BEGIN
    DECLARE @Offset INT = (@PageNumber - 1) * @PageSize;
    
    SELECT 
        c.Id,
        c.Title,
        c.Description,
        c.Price,
        u.FullName AS InstructorName,
        cat.Name AS CategoryName
    FROM Courses c
    INNER JOIN Users u ON c.InstructorId = u.Id
    INNER JOIN Categories cat ON c.CategoryId = cat.Id
    WHERE c.CategoryId = @CategoryId AND c.IsPublished = 1
    ORDER BY c.CreatedAt DESC
    OFFSET @Offset ROWS
    FETCH NEXT @PageSize ROWS ONLY;
END
```

#### 2.3.6. Visual Studio (Môi trường phát triển tích hợp - IDE)

**Giới thiệu:**

Visual Studio là IDE mạnh mẽ của Microsoft, cung cấp môi trường phát triển hoàn chỉnh cho các ứng dụng .NET với nhiều tính năng hỗ trợ developer.

**Tính năng chính:**

1. **IntelliSense:** Code completion và error detection
2. **Debugging:** Powerful debugging tools với breakpoints, watch windows
3. **Git Integration:** Built-in source control management
4. **NuGet Package Manager:** Quản lý dependencies dễ dàng
5. **Project Templates:** Quick start với pre-configured templates
6. **Extensions:** Ecosystem phong phú với thousands of extensions

**Project Structure trong Visual Studio:**

```
OnlineLearningPlatform/
├── Controllers/
│   ├── HomeController.cs
│   ├── CoursesController.cs
│   ├── AccountController.cs
│   └── AdminController.cs
├── Models/
│   ├── Course.cs
│   ├── User.cs
│   ├── Category.cs
│   └── ViewModels/
│       ├── CourseListViewModel.cs
│       └── LoginViewModel.cs
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   ├── Courses/
│   │   ├── Index.cshtml
│   │   └── Details.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _ViewStart.cshtml
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Migrations/
├── Services/
│   ├── ICourseService.cs
│   └── CourseService.cs
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── images/
├── appsettings.json
├── Program.cs
└── Startup.cs
```

**Configuration và Setup:**

```csharp
// Program.cs
var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => {
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
}).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICourseService, CourseService>();

var app = builder.Build();

// Configure pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
```

---

*[Tiếp tục với Chương 3...]*
## CHƯƠNG 3: PHÂN TÍCH VÀ THIẾT KẾ HỆ THỐNG

### 3.1. Phân tích yêu cầu hệ thống

#### 3.1.1. Yêu cầu chức năng

##### 3.1.1.1. Đối với học viên (Students)

**Quản lý tài khoản:**
- Đăng ký tài khoản mới với email và thông tin cá nhân
- Đăng nhập/đăng xuất hệ thống
- Quản lý thông tin profile cá nhân
- Thay đổi mật khẩu và cài đặt bảo mật
- Khôi phục mật khẩu qua email

**Duyệt và tìm kiếm khóa học:**
- Xem danh sách tất cả khóa học có sẵn
- Tìm kiếm khóa học theo từ khóa, tên, mô tả
- Lọc khóa học theo danh mục, giá, độ khó, đánh giá
- Sắp xếp khóa học theo giá, độ phổ biến, ngày tạo
- Xem chi tiết khóa học với đầy đủ thông tin

**Quản lý học tập:**
- Đăng ký tham gia khóa học
- Theo dõi tiến độ học tập cá nhân
- Xem lịch sử các khóa học đã tham gia
- Đánh dấu khóa học yêu thích (wishlist)
- Nhận thông báo về khóa học mới

**Tương tác và đánh giá:**
- Đánh giá và review khóa học đã tham gia
- Xem đánh giá của học viên khác
- Chia sẻ khóa học trên mạng xã hội
- Theo dõi giảng viên yêu thích

**Dashboard cá nhân:**
- Xem tổng quan tiến độ học tập
- Thống kê số khóa học đã hoàn thành
- Lịch sử hoạt động và thành tích
- Quản lý danh sách khóa học đang học

##### 3.1.1.2. Đối với giảng viên (Instructors)

**Quản lý khóa học:**
- Tạo khóa học mới với thông tin chi tiết
- Chỉnh sửa và cập nhật nội dung khóa học
- Tổ chức cấu trúc bài học (modules, lessons)
- Upload tài liệu đa phương tiện (video, PDF, images)
- Thiết lập giá và điều kiện truy cập

**Quản lý nội dung:**
- Tạo và chỉnh sửa bài giảng
- Upload video bài giảng
- Tạo tài liệu hỗ trợ và bài tập
- Quản lý thứ tự và cấu trúc nội dung
- Preview khóa học trước khi publish

**Tương tác với học viên:**
- Xem danh sách học viên đã đăng ký
- Theo dõi tiến độ học tập của học viên
- Trả lời câu hỏi và hỗ trợ học viên
- Nhận và phản hồi đánh giá từ học viên

**Thống kê và báo cáo:**
- Xem số lượng học viên đăng ký
- Thống kê doanh thu từ khóa học
- Phân tích hiệu quả khóa học
- Báo cáo chi tiết về hoạt động giảng dạy

**Dashboard giảng viên:**
- Tổng quan về tất cả khóa học
- Thống kê nhanh về học viên và doanh thu
- Thông báo và tin nhắn từ học viên
- Quản lý lịch trình và deadline

##### 3.1.1.3. Đối với quản trị viên (Administrators)

**Quản lý người dùng:**
- Xem danh sách tất cả người dùng
- Tạo, chỉnh sửa, xóa tài khoản người dùng
- Phân quyền và quản lý vai trò
- Khóa/mở khóa tài khoản người dùng
- Theo dõi hoạt động của người dùng

**Quản lý nội dung:**
- Duyệt và phê duyệt khóa học mới
- Kiểm tra chất lượng nội dung
- Xóa hoặc ẩn nội dung vi phạm
- Quản lý danh mục khóa học
- Cấu hình thông tin hệ thống

**Quản lý hệ thống:**
- Dashboard tổng quan toàn hệ thống
- Giám sát hiệu suất và uptime
- Quản lý cấu hình và settings
- Backup và restore dữ liệu
- Quản lý logs và security

**Báo cáo và thống kê:**
- Báo cáo tổng quan về người dùng
- Thống kê khóa học và doanh thu
- Phân tích xu hướng và growth
- Export dữ liệu và reports
- Dashboard với charts và metrics

#### 3.1.2. Yêu cầu phi chức năng

**Hiệu suất (Performance):**
- Thời gian tải trang không quá 3 giây
- Hỗ trợ đồng thời tối thiểu 1000 người dùng
- Database response time dưới 500ms
- Tối ưu hóa cho mobile và desktop
- Caching hiệu quả cho nội dung tĩnh

**Bảo mật (Security):**
- Mã hóa HTTPS cho tất cả communications
- Hash và salt passwords với bcrypt
- Chống tấn công XSS, CSRF, SQL Injection
- Session management bảo mật
- Input validation và sanitization

**Khả dụng (Usability):**
- Giao diện responsive trên mọi thiết bị
- Tuân thủ Web Accessibility Guidelines (WCAG)
- Hỗ trợ các trình duyệt phổ biến
- UX/UI thân thiện và trực quan
- Thời gian học sử dụng tối thiểu

**Độ tin cậy (Reliability):**
- Uptime tối thiểu 99.9%
- Automatic backup hàng ngày
- Error handling và recovery
- Data integrity và consistency
- Monitoring và alerting system

**Khả năng mở rộng (Scalability):**
- Kiến trúc modular và loosely coupled
- Horizontal scaling capability
- Database optimization và indexing
- Caching layers (Redis, MemoryCache)
- Cloud deployment ready

**Tương thích (Compatibility):**
- Cross-browser compatibility
- Mobile-first responsive design
- API compatibility cho future integrations
- Backward compatibility cho data migration
- Standards compliance (HTML5, CSS3, ES6+)

### 3.2. Đặc tả các trường hợp sử dụng (Use Case Diagram)

#### 3.2.1. Sơ đồ Use Case tổng quát

```
                    Online Learning Platform Use Cases

    ┌─────────────┐                                           ┌─────────────┐
    │   Học viên  │                                           │ Giảng viên  │
    │ (Student)   │                                           │(Instructor) │
    └─────────────┘                                           └─────────────┘
           │                                                         │
           │                                                         │
           ├─── Đăng ký tài khoản                                   ├─── Tạo khóa học
           ├─── Đăng nhập hệ thống                                  ├─── Quản lý nội dung
           ├─── Tìm kiếm khóa học                                   ├─── Upload tài liệu
           ├─── Xem chi tiết khóa học                               ├─── Theo dõi học viên
           ├─── Đăng ký học khóa học                                ├─── Xem thống kê
           ├─── Theo dõi tiến độ                                    ├─── Trả lời Q&A
           ├─── Đánh giá khóa học                                   └─── Quản lý profile
           ├─── Quản lý wishlist                                           │
           ├─── Xem dashboard                                              │
           └─── Quản lý profile                                            │
                  │                                                        │
                  │                                                        │
                  └────────────────┬───────────────────────────────────────┘
                                   │
                                   │
                            ┌─────────────┐
                            │ Quản trị    │
                            │ viên (Admin)│
                            └─────────────┘
                                   │
                                   ├─── Quản lý người dùng
                                   ├─── Duyệt khóa học
                                   ├─── Quản lý danh mục
                                   ├─── Xem báo cáo tổng quan
                                   ├─── Quản lý hệ thống
                                   ├─── Backup/Restore
                                   └─── Cấu hình settings
```

#### 3.2.2. Đặc tả chi tiết các Use Case chính

**Use Case 1: Đăng ký tài khoản**

| Thuộc tính | Mô tả |
|------------|-------|
| **Use Case ID** | UC001 |
| **Tên** | Đăng ký tài khoản |
| **Mô tả** | Người dùng tạo tài khoản mới để truy cập hệ thống |
| **Actor chính** | Người dùng chưa có tài khoản |
| **Điều kiện tiên quyết** | Người dùng chưa có tài khoản trong hệ thống |
| **Điều kiện sau** | Tài khoản được tạo thành công và có thể đăng nhập |

**Luồng chính:**
1. Người dùng truy cập trang đăng ký
2. Hệ thống hiển thị form đăng ký
3. Người dùng nhập thông tin: email, mật khẩu, họ tên, vai trò
4. Hệ thống validate thông tin đầu vào
5. Hệ thống kiểm tra email đã tồn tại chưa
6. Hệ thống tạo tài khoản mới và hash mật khẩu
7. Hệ thống gửi email xác nhận (nếu cần)
8. Hệ thống chuyển hướng đến trang đăng nhập

**Luồng thay thế:**
- 4a. Thông tin không hợp lệ: Hiển thị lỗi validation
- 5a. Email đã tồn tại: Thông báo lỗi và yêu cầu nhập email khác
- 7a. Gửi email thất bại: Tạo tài khoản nhưng thông báo lỗi email

**Use Case 2: Tạo khóa học**

| Thuộc tính | Mô tả |
|------------|-------|
| **Use Case ID** | UC002 |
| **Tên** | Tạo khóa học |
| **Mô tả** | Giảng viên tạo khóa học mới với đầy đủ thông tin |
| **Actor chính** | Giảng viên |
| **Điều kiện tiên quyết** | Giảng viên đã đăng nhập với quyền Instructor |
| **Điều kiện sau** | Khóa học được tạo và lưu vào hệ thống |

**Luồng chính:**
1. Giảng viên truy cập trang tạo khóa học
2. Hệ thống hiển thị form tạo khóa học
3. Giảng viên nhập thông tin cơ bản: tên, mô tả, danh mục, giá
4. Giảng viên upload hình ảnh đại diện
5. Giảng viên thiết lập cấu trúc bài học
6. Hệ thống validate thông tin
7. Hệ thống lưu khóa học với trạng thái Draft
8. Hệ thống thông báo tạo thành công

**Use Case 3: Đăng ký học khóa học**

| Thuộc tính | Mô tả |
|------------|-------|
| **Use Case ID** | UC003 |
| **Tên** | Đăng ký học khóa học |
| **Mô tả** | Học viên đăng ký tham gia một khóa học |
| **Actor chính** | Học viên |
| **Điều kiện tiên quyết** | Học viên đã đăng nhập, khóa học đã được publish |
| **Điều kiện sau** | Học viên được ghi danh vào khóa học |

**Luồng chính:**
1. Học viên xem chi tiết khóa học
2. Học viên click nút "Đăng ký học"
3. Hệ thống kiểm tra học viên đã đăng ký chưa
4. Hệ thống kiểm tra điều kiện đăng ký (giá, prerequisites)
5. Hệ thống tạo enrollment record
6. Hệ thống cập nhật số lượng học viên của khóa học
7. Hệ thống gửi email xác nhận đăng ký
8. Hệ thống chuyển hướng đến trang học tập

### 3.3. Thiết kế cơ sở dữ liệu

#### 3.3.1. Mô hình thực thể liên kết (ER Diagram)

```
                    Entity Relationship Diagram

    ┌─────────────┐         ┌─────────────┐         ┌─────────────┐
    │    Users    │         │ Categories  │         │   Courses   │
    │─────────────│         │─────────────│         │─────────────│
    │ Id (PK)     │         │ Id (PK)     │         │ Id (PK)     │
    │ Email       │         │ Name        │    ┌────│ Title       │
    │ PasswordHash│         │ Slug        │    │    │ Slug        │
    │ FullName    │         │ Description │    │    │ Description │
    │ Role        │         │ Icon        │    │    │ Price       │
    │ CreatedAt   │         │ CreatedAt   │    │    │ InstructorId│──┐
    │ IsActive    │         └─────────────┘    │    │ CategoryId  │──┘
    └─────────────┘                            │    │ CreatedAt   │
           │                                   │    │ UpdatedAt   │
           │                                   │    │ IsPublished │
           │                                   │    └─────────────┘
           │                                   │           │
           │                                   └───────────┘
           │
           │    ┌─────────────┐                    ┌─────────────┐
           │    │ Enrollments │                    │  Wishlists  │
           │    │─────────────│                    │─────────────│
           └────│ UserId (PK) │                ┌───│ UserId (PK) │
                │ CourseId(PK)│────────────────┘   │ CourseId(PK)│──┐
                │ EnrolledAt  │                    │ AddedAt     │  │
                │ Progress    │                    └─────────────┘  │
                │ CompletedAt │                                     │
                └─────────────┘                                     │
                       │                                            │
                       │                                            │
                       │    ┌─────────────┐                        │
                       │    │   Reviews   │                        │
                       │    │─────────────│                        │
                       └────│ Id (PK)     │                        │
                            │ UserId (FK) │                        │
                            │ CourseId(FK)│────────────────────────┘
                            │ Rating      │
                            │ Comment     │
                            │ CreatedAt   │
                            └─────────────┘
```

#### 3.3.2. Thiết kế các bảng dữ liệu

**Bảng Users:**
```sql
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(256) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(MAX) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL DEFAULT 'Student',
    Avatar NVARCHAR(500) NULL,
    Bio NVARCHAR(1000) NULL,
    CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
    UpdatedAt DATETIME2 DEFAULT GETUTCDATE(),
    IsActive BIT DEFAULT 1,
    EmailConfirmed BIT DEFAULT 0,
    LastLoginAt DATETIME2 NULL
);
```

**Bảng Categories:**
```sql
CREATE TABLE Categories (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Slug NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(500) NULL,
    Icon NVARCHAR(50) NULL,
    ParentId INT NULL,
    DisplayOrder INT DEFAULT 0,
    CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
    IsActive BIT DEFAULT 1,
    
    FOREIGN KEY (ParentId) REFERENCES Categories(Id)
);
```

**Bảng Courses:**
```sql
CREATE TABLE Courses (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Slug NVARCHAR(200) NOT NULL UNIQUE,
    ShortDescription NVARCHAR(500) NULL,
    Description NVARCHAR(MAX) NULL,
    Price DECIMAL(18,2) NOT NULL DEFAULT 0,
    DiscountPrice DECIMAL(18,2) NULL,
    ThumbnailUrl NVARCHAR(500) NULL,
    VideoPreviewUrl NVARCHAR(500) NULL,
    Level NVARCHAR(20) DEFAULT 'Beginner',
    Language NVARCHAR(10) DEFAULT 'vi',
    Duration INT DEFAULT 0, -- in minutes
    InstructorId INT NOT NULL,
    CategoryId INT NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
    UpdatedAt DATETIME2 DEFAULT GETUTCDATE(),
    PublishedAt DATETIME2 NULL,
    IsPublished BIT DEFAULT 0,
    IsFeatured BIT DEFAULT 0,
    ViewCount INT DEFAULT 0,
    EnrollmentCount INT DEFAULT 0,
    
    FOREIGN KEY (InstructorId) REFERENCES Users(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);
```

**Bảng Modules (Chương học):**
```sql
CREATE TABLE Modules (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CourseId INT NOT NULL,
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(1000) NULL,
    DisplayOrder INT NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
    
    FOREIGN KEY (CourseId) REFERENCES Courses(Id) ON DELETE CASCADE
);
```

**Bảng Lessons (Bài học):**
```sql
CREATE TABLE Lessons (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ModuleId INT NOT NULL,
    Title NVARCHAR(200) NOT NULL,
    Content NVARCHAR(MAX) NULL,
    VideoUrl NVARCHAR(500) NULL,
    Duration INT DEFAULT 0, -- in seconds
    DisplayOrder INT NOT NULL,
    IsFree BIT DEFAULT 0,
    CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
    
    FOREIGN KEY (ModuleId) REFERENCES Modules(Id) ON DELETE CASCADE
);
```

**Bảng Enrollments:**
```sql
CREATE TABLE Enrollments (
    UserId INT NOT NULL,
    CourseId INT NOT NULL,
    EnrolledAt DATETIME2 DEFAULT GETUTCDATE(),
    Progress DECIMAL(5,2) DEFAULT 0,
    CompletedAt DATETIME2 NULL,
    LastAccessedAt DATETIME2 NULL,
    CertificateUrl NVARCHAR(500) NULL,
    
    PRIMARY KEY (UserId, CourseId),
    FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (CourseId) REFERENCES Courses(Id) ON DELETE CASCADE
);
```

**Bảng LessonProgress:**
```sql
CREATE TABLE LessonProgress (
    UserId INT NOT NULL,
    LessonId INT NOT NULL,
    IsCompleted BIT DEFAULT 0,
    WatchedDuration INT DEFAULT 0, -- in seconds
    CompletedAt DATETIME2 NULL,
    LastWatchedAt DATETIME2 DEFAULT GETUTCDATE(),
    
    PRIMARY KEY (UserId, LessonId),
    FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (LessonId) REFERENCES Lessons(Id) ON DELETE CASCADE
);
```

**Bảng Reviews:**
```sql
CREATE TABLE Reviews (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    CourseId INT NOT NULL,
    Rating INT NOT NULL CHECK (Rating >= 1 AND Rating <= 5),
    Comment NVARCHAR(1000) NULL,
    CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
    UpdatedAt DATETIME2 DEFAULT GETUTCDATE(),
    IsApproved BIT DEFAULT 1,
    
    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (CourseId) REFERENCES Courses(Id),
    UNIQUE(UserId, CourseId)
);
```

**Bảng Wishlists:**
```sql
CREATE TABLE Wishlists (
    UserId INT NOT NULL,
    CourseId INT NOT NULL,
    AddedAt DATETIME2 DEFAULT GETUTCDATE(),
    
    PRIMARY KEY (UserId, CourseId),
    FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (CourseId) REFERENCES Courses(Id) ON DELETE CASCADE
);
```

#### 3.3.3. Mối quan hệ giữa các bảng

**Quan hệ One-to-Many:**

1. **Users → Courses (Instructor):**
   - Một giảng viên có thể tạo nhiều khóa học
   - Một khóa học chỉ có một giảng viên chính

2. **Categories → Courses:**
   - Một danh mục có thể chứa nhiều khóa học
   - Một khóa học thuộc về một danh mục

3. **Courses → Modules:**
   - Một khóa học có thể có nhiều chương
   - Một chương thuộc về một khóa học

4. **Modules → Lessons:**
   - Một chương có thể có nhiều bài học
   - Một bài học thuộc về một chương

5. **Categories → Categories (Self-referencing):**
   - Hỗ trợ danh mục con (subcategories)
   - ParentId tham chiếu đến Id của cùng bảng

**Quan hệ Many-to-Many:**

1. **Users ↔ Courses (Enrollments):**
   - Một học viên có thể đăng ký nhiều khóa học
   - Một khóa học có thể có nhiều học viên
   - Bảng trung gian: Enrollments

2. **Users ↔ Courses (Wishlists):**
   - Một người dùng có thể có nhiều khóa học trong wishlist
   - Một khóa học có thể được nhiều người thêm vào wishlist
   - Bảng trung gian: Wishlists

3. **Users ↔ Lessons (LessonProgress):**
   - Một học viên có thể có tiến độ với nhiều bài học
   - Một bài học có thể có tiến độ từ nhiều học viên
   - Bảng trung gian: LessonProgress

**Ràng buộc và Index:**

```sql
-- Indexes for performance
CREATE INDEX IX_Courses_CategoryId ON Courses(CategoryId);
CREATE INDEX IX_Courses_InstructorId ON Courses(InstructorId);
CREATE INDEX IX_Courses_IsPublished ON Courses(IsPublished);
CREATE INDEX IX_Enrollments_UserId ON Enrollments(UserId);
CREATE INDEX IX_Enrollments_CourseId ON Enrollments(CourseId);
CREATE INDEX IX_Reviews_CourseId ON Reviews(CourseId);
CREATE INDEX IX_Reviews_Rating ON Reviews(Rating);

-- Computed columns
ALTER TABLE Courses ADD AverageRating AS (
    SELECT AVG(CAST(Rating AS FLOAT)) 
    FROM Reviews 
    WHERE CourseId = Courses.Id AND IsApproved = 1
);

-- Triggers for maintaining data consistency
CREATE TRIGGER TR_UpdateCourseEnrollmentCount
ON Enrollments
AFTER INSERT, DELETE
AS
BEGIN
    UPDATE Courses 
    SET EnrollmentCount = (
        SELECT COUNT(*) 
        FROM Enrollments 
        WHERE CourseId = Courses.Id
    )
    WHERE Id IN (
        SELECT DISTINCT CourseId 
        FROM inserted 
        UNION 
        SELECT DISTINCT CourseId 
        FROM deleted
    );
END;
```

---

*[Tiếp tục với Chương 4...]*
## CHƯƠNG 4: KẾT QUẢ THỰC NGHIỆM

### 4.1. Môi trường phát triển

#### 4.1.1. Cấu hình phần cứng

**Máy tính phát triển:**
- **CPU:** Intel Core i5-8400 (6 cores, 2.8GHz base, 4.0GHz boost)
- **RAM:** 16GB DDR4 2666MHz
- **Storage:** SSD NVMe 512GB + HDD 1TB
- **GPU:** NVIDIA GTX 1060 6GB (hỗ trợ CUDA cho machine learning tasks)
- **Network:** Gigabit Ethernet + Wi-Fi 802.11ac

**Máy chủ test:**
- **Cloud Provider:** Microsoft Azure
- **Instance Type:** Standard B2s (2 vCPUs, 4GB RAM)
- **Storage:** Premium SSD 128GB
- **Database:** Azure SQL Database (Basic tier)
- **CDN:** Azure CDN cho static files

#### 4.1.2. Cấu hình phần mềm

**Hệ điều hành và runtime:**
- **OS:** Windows 11 Pro (Build 22H2)
- **.NET Version:** .NET 9.0 SDK
- **Runtime:** ASP.NET Core 9.0
- **Database:** SQL Server 2022 Developer Edition
- **Web Server:** IIS Express (development), Kestrel (production)

**IDE và công cụ phát triển:**
- **Primary IDE:** Visual Studio 2022 Community (Version 17.8)
- **Extensions:** 
  - Web Essentials
  - GitHub Copilot
  - SonarLint
  - Entity Framework Power Tools
- **Version Control:** Git với GitHub Desktop
- **Database Tools:** SQL Server Management Studio (SSMS) 19.0

**Package và dependencies chính:**
```xml
<PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="9.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="9.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="9.0.0" />
<PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.1" />
<PackageReference Include="Serilog.AspNetCore" Version="7.0.0" />
<PackageReference Include="FluentValidation.AspNetCore" Version="11.3.0" />
```

#### 4.1.3. Cấu hình deployment

**Development Environment:**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=OnlineLearningPlatform_Dev;Trusted_Connection=true;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

**Production Environment:**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=tcp:server.database.windows.net,1433;Initial Catalog=OnlineLearningPlatform_Prod;Persist Security Info=False;User ID=admin;Password=***;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*.azurewebsites.net"
}
```

### 4.2. Kiến trúc tổng quan của ứng dụng

#### 4.2.1. Kiến trúc 3-Layer

```
┌─────────────────────────────────────────────────────────────┐
│                    Presentation Layer                        │
│  ┌─────────────┐  ┌─────────────┐  ┌─────────────────────┐  │
│  │ Controllers │  │    Views    │  │   ViewModels/DTOs   │  │
│  │             │  │             │  │                     │  │
│  │ - Home      │  │ - Razor     │  │ - CourseListVM      │  │
│  │ - Courses   │  │ - Layout    │  │ - LoginVM           │  │
│  │ - Account   │  │ - Partials  │  │ - CreateCourseVM    │  │
│  │ - Admin     │  │ - Components│  │ - DashboardVM       │  │
│  └─────────────┘  └─────────────┘  └─────────────────────┘  │
└─────────────────────────────────────────────────────────────┘
                                │
                                ▼
┌─────────────────────────────────────────────────────────────┐
│                   Business Logic Layer                      │
│  ┌─────────────┐  ┌─────────────┐  ┌─────────────────────┐  │
│  │  Services   │  │ Validators  │  │    AutoMapper       │  │
│  │             │  │             │  │                     │  │
│  │ - Course    │  │ - Fluent    │  │ - Entity to DTO     │  │
│  │ - User      │  │ - Custom    │  │ - DTO to Entity     │  │
│  │ - Email     │  │ - Model     │  │ - ViewModel Maps    │  │
│  │ - File      │  │ - Business  │  │                     │  │
│  └─────────────┘  └─────────────┘  └─────────────────────┘  │
└─────────────────────────────────────────────────────────────┘
                                │
                                ▼
┌─────────────────────────────────────────────────────────────┐
│                   Data Access Layer                         │
│  ┌─────────────┐  ┌─────────────┐  ┌─────────────────────┐  │
│  │ DbContext   │  │ Repositories│  │      Entities       │  │
│  │             │  │             │  │                     │  │
│  │ - App       │  │ - Generic   │  │ - Course            │  │
│  │ - Identity  │  │ - Course    │  │ - User              │  │
│  │ - Migrations│  │ - User      │  │ - Category          │  │
│  │ - Seeding   │  │ - Category  │  │ - Enrollment        │  │
│  └─────────────┘  └─────────────┘  └─────────────────────┘  │
└─────────────────────────────────────────────────────────────┘
```

#### 4.2.2. Cấu trúc thư mục dự án

```
OnlineLearningPlatform/
├── Controllers/
│   ├── HomeController.cs
│   ├── CoursesController.cs
│   ├── AccountController.cs
│   ├── EnrollmentController.cs
│   └── Api/
│       ├── CoursesApiController.cs
│       └── WishlistApiController.cs
├── Areas/
│   ├── Admin/
│   │   ├── Controllers/
│   │   │   ├── DashboardController.cs
│   │   │   ├── UsersController.cs
│   │   │   └── CoursesController.cs
│   │   └── Views/
│   └── Instructor/
│       ├── Controllers/
│       └── Views/
├── Models/
│   ├── Entities/
│   │   ├── Course.cs
│   │   ├── User.cs
│   │   ├── Category.cs
│   │   ├── Enrollment.cs
│   │   └── Review.cs
│   ├── ViewModels/
│   │   ├── CourseListViewModel.cs
│   │   ├── CourseDetailsViewModel.cs
│   │   ├── DashboardViewModel.cs
│   │   └── Account/
│   └── DTOs/
│       ├── CreateCourseDto.cs
│       └── UpdateCourseDto.cs
├── Services/
│   ├── Interfaces/
│   │   ├── ICourseService.cs
│   │   ├── IUserService.cs
│   │   └── IEmailService.cs
│   └── Implementations/
│       ├── CourseService.cs
│       ├── UserService.cs
│       └── EmailService.cs
├── Data/
│   ├── ApplicationDbContext.cs
│   ├── Repositories/
│   │   ├── IRepository.cs
│   │   ├── Repository.cs
│   │   └── CourseRepository.cs
│   ├── Migrations/
│   └── Seeders/
│       └── DataSeeder.cs
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   ├── Courses/
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   │   └── Search.cshtml
│   ├── Account/
│   │   ├── Login.cshtml
│   │   ├── Register.cshtml
│   │   └── Dashboard.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _LoginPartial.cshtml
│       └── Components/
├── wwwroot/
│   ├── css/
│   │   ├── bootstrap.min.css
│   │   ├── site.css
│   │   └── admin.css
│   ├── js/
│   │   ├── bootstrap.bundle.min.js
│   │   ├── jquery.min.js
│   │   └── site.js
│   ├── images/
│   └── uploads/
│       ├── courses/
│       └── avatars/
├── Configurations/
│   ├── AutoMapperProfile.cs
│   └── ServiceExtensions.cs
├── Middleware/
│   ├── ErrorHandlingMiddleware.cs
│   └── RequestLoggingMiddleware.cs
├── Utilities/
│   ├── FileHelper.cs
│   ├── SlugGenerator.cs
│   └── Constants.cs
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
└── OnlineLearningPlatform.csproj
```

#### 4.2.3. Dependency Injection Configuration

```csharp
// Program.cs
var builder = WebApplication.CreateBuilder(args);

// Database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity
builder.Services.AddDefaultIdentity<ApplicationUser>(options => {
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>();

// Services
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IFileService, FileService>();

// Repositories
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICourseRepository, CourseRepository>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// Logging
builder.Services.AddLogging(builder => {
    builder.AddConsole();
    builder.AddDebug();
});

// MVC
builder.Services.AddControllersWithViews()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Program>());

var app = builder.Build();

// Middleware Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

// Custom Middleware
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<RequestLoggingMiddleware>();

// Routes
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

// Seed Data
using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<DataSeeder>();
    await seeder.SeedAsync();
}

app.Run();
```

### 4.3. Giao diện tổng quan người dùng

#### 4.3.1. Giao diện trang chủ

**Mô tả chức năng:**
Trang chủ là điểm tiếp xúc đầu tiên của người dùng với hệ thống, đóng vai trò quan trọng trong việc giới thiệu nền tảng và thu hút người dùng đăng ký sử dụng dịch vụ.

**Đối với người dùng (học viên):**
- **Khám phá nền tảng:** Tìm hiểu về dịch vụ học tập trực tuyến
- **Duyệt khóa học:** Xem khóa học nổi bật và danh mục phổ biến
- **Đăng ký tài khoản:** Truy cập nhanh form đăng ký học viên
- **Tìm kiếm khóa học:** Sử dụng thanh tìm kiếm để tìm nội dung mong muốn

**Đối với giảng viên:**
- **Tìm hiểu cơ hội:** Khám phá khả năng tạo và bán khóa học
- **Xem thống kê nền tảng:** Đánh giá tiềm năng của thị trường
- **Đăng ký làm giảng viên:** Truy cập form đăng ký với vai trò instructor
- **Xem mẫu khóa học:** Tham khảo các khóa học chất lượng cao

**Đối với quản trị viên:**
- **Giám sát tổng quan:** Xem thống kê nhanh về hoạt động nền tảng
- **Truy cập admin panel:** Link nhanh đến trang quản trị
- **Kiểm tra nội dung:** Xem các khóa học đang được hiển thị
- **Theo dõi user engagement:** Quan sát tương tác của người dùng

#### 4.3.2. Layout chung và Navigation

**_Layout.cshtml:**
```html
<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - Online Learning Platform</title>
    <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="~/css/site.css" asp-append-version="true" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" />
</head>
<body>
    <header>
        <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
            <div class="container">
                <a class="navbar-brand" asp-area="" asp-controller="Home" asp-action="Index">
                    <i class="fas fa-graduation-cap me-2"></i>
                    Learning Platform
                </a>
                
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav">
                    <span class="navbar-toggler-icon"></span>
                </button>
                
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav me-auto">
                        <li class="nav-item">
                            <a class="nav-link" asp-controller="Home" asp-action="Index">
                                <i class="fas fa-home me-1"></i>Trang chủ
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" asp-controller="Courses" asp-action="Index">
                                <i class="fas fa-book me-1"></i>Khóa học
                            </a>
                        </li>
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown">
                                <i class="fas fa-list me-1"></i>Danh mục
                            </a>
                            <ul class="dropdown-menu">
                                @await Component.InvokeAsync("CategoryMenu")
                            </ul>
                        </li>
                    </ul>
                    
                    <!-- Search Form -->
                    <form class="d-flex me-3" asp-controller="Courses" asp-action="Search" method="get">
                        <div class="input-group">
                            <input class="form-control" type="search" name="q" placeholder="Tìm kiếm khóa học..." />
                            <button class="btn btn-outline-light" type="submit">
                                <i class="fas fa-search"></i>
                            </button>
                        </div>
                    </form>
                    
                    <!-- User Menu -->
                    <partial name="_LoginPartial" />
                </div>
            </div>
        </nav>
    </header>
    
    <main role="main" class="pb-3">
        @RenderBody()
    </main>
    
    <footer class="border-top footer text-muted bg-light">
        <div class="container py-4">
            <div class="row">
                <div class="col-md-4">
                    <h5>Online Learning Platform</h5>
                    <p>Nền tảng học tập trực tuyến hàng đầu Việt Nam</p>
                </div>
                <div class="col-md-4">
                    <h6>Liên kết nhanh</h6>
                    <ul class="list-unstyled">
                        <li><a href="#" class="text-decoration-none">Về chúng tôi</a></li>
                        <li><a href="#" class="text-decoration-none">Liên hệ</a></li>
                        <li><a href="#" class="text-decoration-none">Điều khoản</a></li>
                    </ul>
                </div>
                <div class="col-md-4">
                    <h6>Theo dõi chúng tôi</h6>
                    <div class="social-links">
                        <a href="#" class="text-decoration-none me-3"><i class="fab fa-facebook"></i></a>
                        <a href="#" class="text-decoration-none me-3"><i class="fab fa-twitter"></i></a>
                        <a href="#" class="text-decoration-none"><i class="fab fa-youtube"></i></a>
                    </div>
                </div>
            </div>
            <hr>
            <div class="text-center">
                <p>&copy; 2024 Online Learning Platform. All rights reserved.</p>
            </div>
        </div>
    </footer>
    
    <script src="~/lib/jquery/dist/jquery.min.js"></script>
    <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
    <script src="~/js/site.js" asp-append-version="true"></script>
    @await RenderSectionAsync("Scripts", required: false)
</body>
</html>
```

#### 4.3.3. Danh sách khóa học

**Mô tả chức năng:**
Trang danh sách khóa học cho phép người dùng duyệt, tìm kiếm và lọc toàn bộ khóa học có sẵn trên nền tảng.

**Đối với người dùng (học viên):**
- **Duyệt khóa học:** Xem toàn bộ khóa học có sẵn với thông tin cơ bản
- **Tìm kiếm nâng cao:** Sử dụng bộ lọc theo danh mục, giá, độ khó, đánh giá
- **So sánh khóa học:** Xem thông tin giá, rating, instructor để so sánh
- **Thêm vào wishlist:** Lưu khóa học yêu thích để xem sau
- **Đăng ký nhanh:** Truy cập trực tiếp vào trang chi tiết để đăng ký

**Đối với giảng viên:**
- **Nghiên cứu thị trường:** Xem các khóa học cạnh tranh trong cùng lĩnh vực
- **Phân tích giá cả:** Tham khảo mức giá của các khóa học tương tự
- **Học hỏi kinh nghiệm:** Xem cách các giảng viên khác trình bày khóa học
- **Tìm cơ hội hợp tác:** Kết nối với các giảng viên cùng chuyên môn

**Đối với quản trị viên:**
- **Giám sát nội dung:** Kiểm tra chất lượng và tính phù hợp của khóa học
- **Quản lý danh mục:** Đảm bảo phân loại khóa học chính xác
- **Theo dõi xu hướng:** Phân tích khóa học nào được quan tâm nhiều
- **Kiểm soát chất lượng:** Xác định khóa học cần review hoặc gỡ bỏ

#### 4.3.4. Chi tiết khóa học

**Mô tả chức năng:**
Trang chi tiết khóa học cung cấp thông tin đầy đủ về một khóa học cụ thể và cho phép người dùng đăng ký học.

**Đối với người dùng (học viên):**
- **Xem thông tin chi tiết:** Đọc mô tả, mục tiêu học tập, yêu cầu tiên quyết
- **Preview nội dung:** Xem curriculum và video giới thiệu miễn phí
- **Đánh giá khóa học:** Đọc reviews từ học viên khác để quyết định
- **Đăng ký học:** Thực hiện enrollment và thanh toán (nếu có)
- **Chia sẻ khóa học:** Share với bạn bè qua mạng xã hội
- **Liên hệ giảng viên:** Đặt câu hỏi trước khi đăng ký

**Đối với giảng viên:**
- **Xem khóa học của đồng nghiệp:** Học hỏi cách trình bày và tổ chức nội dung
- **Phân tích cạnh tranh:** So sánh với khóa học cùng chủ đề
- **Tham khảo giá cả:** Định giá cho khóa học của mình
- **Kết nối networking:** Liên hệ với giảng viên khác để hợp tác

**Đối với quản trị viên:**
- **Kiểm duyệt nội dung:** Xem xét chất lượng và tính phù hợp
- **Giám sát đánh giá:** Theo dõi feedback từ học viên
- **Quản lý khiếu nại:** Xử lý các vấn đề về nội dung hoặc chất lượng
- **Phê duyệt khóa học:** Quyết định publish hoặc reject khóa học mới

#### 4.3.5. Trang chủ (Homepage) - Code Implementation

**HomeController.cs:**
```csharp
public class HomeController : Controller
{
    private readonly ICourseService _courseService;
    private readonly ICategoryService _categoryService;
    
    public HomeController(ICourseService courseService, ICategoryService categoryService)
    {
        _courseService = courseService;
        _categoryService = categoryService;
    }
    
    public async Task<IActionResult> Index()
    {
        var viewModel = new HomeViewModel
        {
            FeaturedCourses = await _courseService.GetFeaturedCoursesAsync(6),
            PopularCategories = await _categoryService.GetPopularCategoriesAsync(8),
            RecentCourses = await _courseService.GetRecentCoursesAsync(4),
            Statistics = await _courseService.GetPlatformStatisticsAsync()
        };
        
        return View(viewModel);
    }
}
```

**Index.cshtml (Homepage):**
```html
@model HomeViewModel
@{
    ViewData["Title"] = "Trang chủ";
}

<!-- Hero Section -->
<section class="hero-section bg-primary text-white py-5">
    <div class="container">
        <div class="row align-items-center">
            <div class="col-lg-6">
                <h1 class="display-4 fw-bold mb-4">
                    Học tập trực tuyến hiệu quả
                </h1>
                <p class="lead mb-4">
                    Khám phá hàng nghìn khóa học chất lượng cao từ các chuyên gia hàng đầu. 
                    Học mọi lúc, mọi nơi với chi phí hợp lý.
                </p>
                <div class="d-flex gap-3">
                    <a asp-controller="Courses" asp-action="Index" class="btn btn-light btn-lg">
                        <i class="fas fa-search me-2"></i>Khám phá khóa học
                    </a>
                    <a asp-controller="Account" asp-action="Register" class="btn btn-outline-light btn-lg">
                        <i class="fas fa-user-plus me-2"></i>Đăng ký ngay
                    </a>
                </div>
            </div>
            <div class="col-lg-6">
                <img src="~/images/hero-illustration.svg" alt="Online Learning" class="img-fluid" />
            </div>
        </div>
    </div>
</section>

<!-- Statistics Section -->
<section class="py-5 bg-light">
    <div class="container">
        <div class="row text-center">
            <div class="col-md-3 mb-4">
                <div class="stat-item">
                    <i class="fas fa-book fa-3x text-primary mb-3"></i>
                    <h3 class="fw-bold">@Model.Statistics.TotalCourses</h3>
                    <p class="text-muted">Khóa học</p>
                </div>
            </div>
            <div class="col-md-3 mb-4">
                <div class="stat-item">
                    <i class="fas fa-users fa-3x text-success mb-3"></i>
                    <h3 class="fw-bold">@Model.Statistics.TotalStudents</h3>
                    <p class="text-muted">Học viên</p>
                </div>
            </div>
            <div class="col-md-3 mb-4">
                <div class="stat-item">
                    <i class="fas fa-chalkboard-teacher fa-3x text-warning mb-3"></i>
                    <h3 class="fw-bold">@Model.Statistics.TotalInstructors</h3>
                    <p class="text-muted">Giảng viên</p>
                </div>
            </div>
            <div class="col-md-3 mb-4">
                <div class="stat-item">
                    <i class="fas fa-star fa-3x text-info mb-3"></i>
                    <h3 class="fw-bold">@Model.Statistics.AverageRating.ToString("F1")</h3>
                    <p class="text-muted">Đánh giá trung bình</p>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- Featured Courses -->
<section class="py-5">
    <div class="container">
        <div class="row mb-4">
            <div class="col-12 text-center">
                <h2 class="fw-bold mb-3">Khóa học nổi bật</h2>
                <p class="text-muted">Những khóa học được đánh giá cao nhất từ cộng đồng</p>
            </div>
        </div>
        <div class="row">
            @foreach (var course in Model.FeaturedCourses)
            {
                <div class="col-lg-4 col-md-6 mb-4">
                    <partial name="_CourseCard" model="course" />
                </div>
            }
        </div>
        <div class="text-center mt-4">
            <a asp-controller="Courses" asp-action="Index" class="btn btn-primary btn-lg">
                Xem tất cả khóa học <i class="fas fa-arrow-right ms-2"></i>
            </a>
        </div>
    </div>
</section>

<!-- Popular Categories -->
<section class="py-5 bg-light">
    <div class="container">
        <div class="row mb-4">
            <div class="col-12 text-center">
                <h2 class="fw-bold mb-3">Danh mục phổ biến</h2>
                <p class="text-muted">Khám phá các lĩnh vực học tập đa dạng</p>
            </div>
        </div>
        <div class="row">
            @foreach (var category in Model.PopularCategories)
            {
                <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
                    <div class="category-card text-center p-4 bg-white rounded shadow-sm h-100">
                        <i class="@category.Icon fa-3x text-primary mb-3"></i>
                        <h5 class="fw-bold mb-2">@category.Name</h5>
                        <p class="text-muted small mb-3">@category.CourseCount khóa học</p>
                        <a asp-controller="Courses" asp-action="Index" asp-route-category="@category.Slug" 
                           class="btn btn-outline-primary btn-sm">
                            Khám phá
                        </a>
                    </div>
                </div>
            }
        </div>
    </div>
</section>

<!-- Features Section -->
<section class="py-5">
    <div class="container">
        <div class="row mb-5">
            <div class="col-12 text-center">
                <h2 class="fw-bold mb-3">Tại sao chọn chúng tôi?</h2>
                <p class="text-muted">Những ưu điểm vượt trội của nền tảng</p>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4 mb-4">
                <div class="feature-item text-center">
                    <div class="feature-icon bg-primary text-white rounded-circle mx-auto mb-3 d-flex align-items-center justify-content-center" style="width: 80px; height: 80px;">
                        <i class="fas fa-clock fa-2x"></i>
                    </div>
                    <h5 class="fw-bold mb-3">Học mọi lúc, mọi nơi</h5>
                    <p class="text-muted">Truy cập khóa học 24/7 trên mọi thiết bị. Học theo tốc độ của riêng bạn.</p>
                </div>
            </div>
            <div class="col-md-4 mb-4">
                <div class="feature-item text-center">
                    <div class="feature-icon bg-success text-white rounded-circle mx-auto mb-3 d-flex align-items-center justify-content-center" style="width: 80px; height: 80px;">
                        <i class="fas fa-certificate fa-2x"></i>
                    </div>
                    <h5 class="fw-bold mb-3">Chứng chỉ uy tín</h5>
                    <p class="text-muted">Nhận chứng chỉ hoàn thành được công nhận bởi các doanh nghiệp hàng đầu.</p>
                </div>
            </div>
            <div class="col-md-4 mb-4">
                <div class="feature-item text-center">
                    <div class="feature-icon bg-warning text-white rounded-circle mx-auto mb-3 d-flex align-items-center justify-content-center" style="width: 80px; height: 80px;">
                        <i class="fas fa-users fa-2x"></i>
                    </div>
                    <h5 class="fw-bold mb-3">Cộng đồng hỗ trợ</h5>
                    <p class="text-muted">Tham gia cộng đồng học tập sôi động với hàng nghìn thành viên.</p>
                </div>
            </div>
        </div>
    </div>
</section>

@section Scripts {
    <script>
        // Animation for statistics counter
        $(document).ready(function() {
            $('.stat-item h3').each(function() {
                var $this = $(this);
                var countTo = parseInt($this.text().replace(/,/g, ''));
                
                $({ countNum: 0 }).animate({
                    countNum: countTo
                }, {
                    duration: 2000,
                    easing: 'linear',
                    step: function() {
                        $this.text(Math.floor(this.countNum).toLocaleString());
                    },
                    complete: function() {
                        $this.text(countTo.toLocaleString());
                    }
                });
            });
        });
    </script>
}
```

#### 4.3.6. Course Card Component

**_CourseCard.cshtml:**
```html
@model CourseCardViewModel

<div class="course-card card h-100 shadow-sm">
    <div class="position-relative">
        <img src="@(Model.ThumbnailUrl ?? "/images/default-course.jpg")" 
             class="card-img-top" alt="@Model.Title" style="height: 200px; object-fit: cover;">
        
        @if (Model.DiscountPrice.HasValue && Model.DiscountPrice < Model.Price)
        {
            <span class="badge bg-danger position-absolute top-0 end-0 m-2">
                -@(Math.Round((Model.Price - Model.DiscountPrice.Value) / Model.Price * 100))%
            </span>
        }
        
        @if (Model.IsFeatured)
        {
            <span class="badge bg-warning position-absolute top-0 start-0 m-2">
                <i class="fas fa-star me-1"></i>Nổi bật
            </span>
        }
    </div>
    
    <div class="card-body d-flex flex-column">
        <div class="mb-2">
            <span class="badge bg-light text-dark">@Model.CategoryName</span>
            <span class="badge bg-info ms-1">@Model.Level</span>
        </div>
        
        <h5 class="card-title fw-bold mb-2">
            <a asp-controller="Courses" asp-action="Details" asp-route-id="@Model.Id" 
               class="text-decoration-none text-dark">
                @Model.Title
            </a>
        </h5>
        
        <p class="card-text text-muted small flex-grow-1">
            @(Model.ShortDescription?.Length > 100 ? 
              Model.ShortDescription.Substring(0, 100) + "..." : 
              Model.ShortDescription)
        </p>
        
        <div class="instructor-info mb-2">
            <small class="text-muted">
                <i class="fas fa-user me-1"></i>@Model.InstructorName
            </small>
        </div>
        
        <div class="course-meta d-flex justify-content-between align-items-center mb-3">
            <div class="rating">
                @for (int i = 1; i <= 5; i++)
                {
                    if (i <= Model.AverageRating)
                    {
                        <i class="fas fa-star text-warning"></i>
                    }
                    else if (i - 0.5 <= Model.AverageRating)
                    {
                        <i class="fas fa-star-half-alt text-warning"></i>
                    }
                    else
                    {
                        <i class="far fa-star text-warning"></i>
                    }
                }
                <small class="text-muted ms-1">(@Model.ReviewCount)</small>
            </div>
            <small class="text-muted">
                <i class="fas fa-users me-1"></i>@Model.EnrollmentCount học viên
            </small>
        </div>
        
        <div class="price-section mb-3">
            @if (Model.Price == 0)
            {
                <span class="h5 text-success fw-bold">Miễn phí</span>
            }
            else if (Model.DiscountPrice.HasValue && Model.DiscountPrice < Model.Price)
            {
                <span class="h5 text-danger fw-bold">@Model.DiscountPrice.Value.ToString("C0")</span>
                <span class="text-muted text-decoration-line-through ms-2">@Model.Price.ToString("C0")</span>
            }
            else
            {
                <span class="h5 text-primary fw-bold">@Model.Price.ToString("C0")</span>
            }
        </div>
        
        <div class="card-actions d-flex gap-2">
            <a asp-controller="Courses" asp-action="Details" asp-route-id="@Model.Id" 
               class="btn btn-primary flex-grow-1">
                <i class="fas fa-eye me-1"></i>Chi tiết
            </a>
            
            @if (User.Identity.IsAuthenticated)
            {
                <button class="btn btn-outline-danger wishlist-btn" data-course-id="@Model.Id" 
                        data-bs-toggle="tooltip" title="Thêm vào yêu thích">
                    <i class="far fa-heart"></i>
                </button>
            }
        </div>
    </div>
</div>
```

### 4.4. Trang chức năng học viên

#### 4.4.1. Dashboard học viên

**Mô tả chức năng:**
Dashboard cá nhân cung cấp tổng quan về tiến độ học tập và quản lý các hoạt động của học viên.

**Nhiệm vụ chính:**
- **Theo dõi tiến độ:** Hiển thị % hoàn thành các khóa học đang học
- **Quản lý khóa học:** Truy cập nhanh vào các khóa học đã đăng ký
- **Lịch sử học tập:** Xem các khóa học đã hoàn thành và chứng chỉ
- **Wishlist management:** Quản lý danh sách khóa học yêu thích
- **Thống kê cá nhân:** Xem thời gian học, điểm số, thành tích
- **Thông báo:** Nhận updates về khóa học mới, deadline, tin nhắn

#### 4.4.2. Trang học tập (Learning Interface)

**Mô tả chức năng:**
Giao diện học tập chính nơi học viên xem video, đọc tài liệu và hoàn thành bài tập.

**Nhiệm vụ chính:**
- **Phát video bài giảng:** Video player với controls và tốc độ phát
- **Theo dõi tiến độ:** Tự động cập nhật % hoàn thành bài học
- **Ghi chú cá nhân:** Tạo notes tại các thời điểm trong video
- **Tải tài liệu:** Download slides, PDF và tài liệu bổ sung
- **Hoàn thành quiz:** Làm bài kiểm tra và nhận feedback
- **Navigation:** Di chuyển giữa các bài học trong khóa học

#### 4.4.3. Danh sách khóa học với bộ lọc

**CoursesController.cs:**
```csharp
public class CoursesController : Controller
{
    private readonly ICourseService _courseService;
    private readonly ICategoryService _categoryService;
    
    public CoursesController(ICourseService courseService, ICategoryService categoryService)
    {
        _courseService = courseService;
        _categoryService = categoryService;
    }
    
    public async Task<IActionResult> Index(CourseFilterViewModel filter)
    {
        var courses = await _courseService.GetCoursesAsync(filter);
        var categories = await _categoryService.GetAllAsync();
        
        var viewModel = new CourseListViewModel
        {
            Courses = courses,
            Filter = filter,
            Categories = categories,
            TotalCount = courses.TotalCount,
            PageCount = courses.PageCount
        };
        
        return View(viewModel);
    }
    
    public async Task<IActionResult> Details(int id)
    {
        var course = await _courseService.GetCourseDetailsAsync(id);
        if (course == null)
            return NotFound();
            
        var viewModel = new CourseDetailsViewModel
        {
            Course = course,
            IsEnrolled = User.Identity.IsAuthenticated && 
                        await _courseService.IsUserEnrolledAsync(User.GetUserId(), id),
            RelatedCourses = await _courseService.GetRelatedCoursesAsync(id, 4)
        };
        
        return View(viewModel);
    }
    
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Enroll(int courseId)
    {
        try
        {
            var userId = User.GetUserId();
            await _courseService.EnrollUserAsync(userId, courseId);
            
            TempData["Success"] = "Đăng ký khóa học thành công!";
            return RedirectToAction("Learn", new { id = courseId });
        }
        catch (Exception ex)
        {
            TempData["Error"] = ex.Message;
            return RedirectToAction("Details", new { id = courseId });
        }
    }
}
```

**Index.cshtml (Course List):**
```html
@model CourseListViewModel
@{
    ViewData["Title"] = "Danh sách khóa học";
}

<div class="container py-4">
    <!-- Page Header -->
    <div class="row mb-4">
        <div class="col-12">
            <h1 class="fw-bold mb-2">Khóa học</h1>
            <p class="text-muted">Khám phá @Model.TotalCount khóa học chất lượng cao</p>
        </div>
    </div>
    
    <!-- Filters -->
    <div class="row mb-4">
        <div class="col-12">
            <div class="card">
                <div class="card-body">
                    <form asp-action="Index" method="get" id="filterForm">
                        <div class="row g-3">
                            <!-- Search -->
                            <div class="col-md-4">
                                <label class="form-label">Tìm kiếm</label>
                                <input asp-for="Filter.SearchTerm" class="form-control" 
                                       placeholder="Nhập từ khóa..." />
                            </div>
                            
                            <!-- Category -->
                            <div class="col-md-3">
                                <label class="form-label">Danh mục</label>
                                <select asp-for="Filter.CategoryId" class="form-select">
                                    <option value="">Tất cả danh mục</option>
                                    @foreach (var category in Model.Categories)
                                    {
                                        <option value="@category.Id">@category.Name</option>
                                    }
                                </select>
                            </div>
                            
                            <!-- Price Range -->
                            <div class="col-md-2">
                                <label class="form-label">Giá</label>
                                <select asp-for="Filter.PriceRange" class="form-select">
                                    <option value="">Tất cả</option>
                                    <option value="free">Miễn phí</option>
                                    <option value="under-500k">Dưới 500k</option>
                                    <option value="500k-1m">500k - 1M</option>
                                    <option value="over-1m">Trên 1M</option>
                                </select>
                            </div>
                            
                            <!-- Sort -->
                            <div class="col-md-2">
                                <label class="form-label">Sắp xếp</label>
                                <select asp-for="Filter.SortBy" class="form-select">
                                    <option value="newest">Mới nhất</option>
                                    <option value="popular">Phổ biến</option>
                                    <option value="rating">Đánh giá cao</option>
                                    <option value="price-low">Giá thấp</option>
                                    <option value="price-high">Giá cao</option>
                                </select>
                            </div>
                            
                            <!-- Filter Button -->
                            <div class="col-md-1 d-flex align-items-end">
                                <button type="submit" class="btn btn-primary w-100">
                                    <i class="fas fa-filter"></i>
                                </button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    
    <!-- Results -->
    <div class="row">
        <!-- Sidebar Filters (Desktop) -->
        <div class="col-lg-3 d-none d-lg-block">
            <div class="card">
                <div class="card-header">
                    <h6 class="mb-0">Bộ lọc nâng cao</h6>
                </div>
                <div class="card-body">
                    <!-- Level Filter -->
                    <div class="mb-4">
                        <h6>Độ khó</h6>
                        <div class="form-check">
                            <input class="form-check-input" type="checkbox" value="beginner" id="levelBeginner">
                            <label class="form-check-label" for="levelBeginner">Cơ bản</label>
                        </div>
                        <div class="form-check">
                            <input class="form-check-input" type="checkbox" value="intermediate" id="levelIntermediate">
                            <label class="form-check-label" for="levelIntermediate">Trung bình</label>
                        </div>
                        <div class="form-check">
                            <input class="form-check-input" type="checkbox" value="advanced" id="levelAdvanced">
                            <label class="form-check-label" for="levelAdvanced">Nâng cao</label>
                        </div>
                    </div>
                    
                    <!-- Rating Filter -->
                    <div class="mb-4">
                        <h6>Đánh giá</h6>
                        @for (int i = 5; i >= 1; i--)
                        {
                            <div class="form-check">
                                <input class="form-check-input" type="radio" name="rating" value="@i" id="rating@(i)">
                                <label class="form-check-label" for="rating@(i)">
                                    @for (int j = 1; j <= i; j++)
                                    {
                                        <i class="fas fa-star text-warning"></i>
                                    }
                                    @for (int j = i + 1; j <= 5; j++)
                                    {
                                        <i class="far fa-star text-warning"></i>
                                    }
                                    trở lên
                                </label>
                            </div>
                        }
                    </div>
                </div>
            </div>
        </div>
        
        <!-- Course Grid -->
        <div class="col-lg-9">
            <!-- Results Header -->
            <div class="d-flex justify-content-between align-items-center mb-3">
                <span class="text-muted">
                    Hiển thị @Model.Courses.Count() trong tổng số @Model.TotalCount khóa học
                </span>
                <div class="view-toggle">
                    <button class="btn btn-sm btn-outline-secondary active" data-view="grid">
                        <i class="fas fa-th"></i>
                    </button>
                    <button class="btn btn-sm btn-outline-secondary" data-view="list">
                        <i class="fas fa-list"></i>
                    </button>
                </div>
            </div>
            
            <!-- Course Grid -->
            <div class="row" id="courseGrid">
                @foreach (var course in Model.Courses)
                {
                    <div class="col-lg-4 col-md-6 mb-4">
                        <partial name="_CourseCard" model="course" />
                    </div>
                }
            </div>
            
            <!-- No Results -->
            @if (!Model.Courses.Any())
            {
                <div class="text-center py-5">
                    <i class="fas fa-search fa-3x text-muted mb-3"></i>
                    <h4>Không tìm thấy khóa học nào</h4>
                    <p class="text-muted">Thử thay đổi bộ lọc hoặc từ khóa tìm kiếm</p>
                    <a asp-action="Index" class="btn btn-primary">Xem tất cả khóa học</a>
                </div>
            }
            
            <!-- Pagination -->
            @if (Model.PageCount > 1)
            {
                <nav aria-label="Course pagination">
                    <ul class="pagination justify-content-center">
                        @if (Model.Filter.Page > 1)
                        {
                            <li class="page-item">
                                <a class="page-link" asp-route-page="@(Model.Filter.Page - 1)" 
                                   asp-all-route-data="@Model.Filter.ToDictionary()">Trước</a>
                            </li>
                        }
                        
                        @for (int i = Math.Max(1, Model.Filter.Page - 2); 
                              i <= Math.Min(Model.PageCount, Model.Filter.Page + 2); i++)
                        {
                            <li class="page-item @(i == Model.Filter.Page ? "active" : "")">
                                <a class="page-link" asp-route-page="@i" 
                                   asp-all-route-data="@Model.Filter.ToDictionary()">@i</a>
                            </li>
                        }
                        
                        @if (Model.Filter.Page < Model.PageCount)
                        {
                            <li class="page-item">
                                <a class="page-link" asp-route-page="@(Model.Filter.Page + 1)" 
                                   asp-all-route-data="@Model.Filter.ToDictionary()">Sau</a>
                            </li>
                        }
                    </ul>
                </nav>
            }
        </div>
    </div>
</div>

@section Scripts {
    <script>
        $(document).ready(function() {
            // Auto-submit form when filters change
            $('#filterForm select').change(function() {
                $('#filterForm').submit();
            });
            
            // View toggle
            $('.view-toggle button').click(function() {
                $('.view-toggle button').removeClass('active');
                $(this).addClass('active');
                
                var view = $(this).data('view');
                if (view === 'list') {
                    $('#courseGrid').removeClass('row').addClass('list-view');
                    $('#courseGrid .col-lg-4').removeClass('col-lg-4 col-md-6').addClass('col-12');
                } else {
                    $('#courseGrid').removeClass('list-view').addClass('row');
                    $('#courseGrid .col-12').removeClass('col-12').addClass('col-lg-4 col-md-6');
                }
            });
            
            // Wishlist functionality
            $('.wishlist-btn').click(function() {
                var courseId = $(this).data('course-id');
                var btn = $(this);
                
                $.post('/api/wishlist/toggle', { courseId: courseId })
                    .done(function(response) {
                        if (response.isInWishlist) {
                            btn.find('i').removeClass('far').addClass('fas');
                            btn.removeClass('btn-outline-danger').addClass('btn-danger');
                        } else {
                            btn.find('i').removeClass('fas').addClass('far');
                            btn.removeClass('btn-danger').addClass('btn-outline-danger');
                        }
                        
                        showToast(response.message, 'success');
                    })
                    .fail(function() {
                        showToast('Có lỗi xảy ra', 'error');
                    });
            });
        });
        
        function showToast(message, type) {
            // Toast notification implementation
            var toast = $('<div class="toast align-items-center text-white bg-' + 
                         (type === 'success' ? 'success' : 'danger') + 
                         ' border-0" role="alert">' +
                         '<div class="d-flex"><div class="toast-body">' + message + '</div></div></div>');
            
            $('.toast-container').append(toast);
            var bsToast = new bootstrap.Toast(toast[0]);
            bsToast.show();
        }
    </script>
}
```

---

*[Tiếp tục với phần còn lại của Chương 4 và Chương 5...]*
#### 4.4.2. Chi tiết khóa học và đăng ký

**Details.cshtml (Course Details):**
```html
@model CourseDetailsViewModel
@{
    ViewData["Title"] = Model.Course.Title;
}

<div class="container py-4">
    <div class="row">
        <!-- Course Content -->
        <div class="col-lg-8">
            <!-- Course Header -->
            <div class="course-header mb-4">
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a asp-controller="Home" asp-action="Index">Trang chủ</a></li>
                        <li class="breadcrumb-item"><a asp-controller="Courses" asp-action="Index">Khóa học</a></li>
                        <li class="breadcrumb-item active">@Model.Course.Title</li>
                    </ol>
                </nav>
                
                <h1 class="fw-bold mb-3">@Model.Course.Title</h1>
                <p class="lead text-muted mb-3">@Model.Course.ShortDescription</p>
                
                <!-- Course Meta -->
                <div class="course-meta d-flex flex-wrap gap-3 mb-4">
                    <div class="meta-item">
                        <i class="fas fa-user text-primary me-1"></i>
                        <strong>Giảng viên:</strong> @Model.Course.InstructorName
                    </div>
                    <div class="meta-item">
                        <i class="fas fa-tag text-primary me-1"></i>
                        <strong>Danh mục:</strong> @Model.Course.CategoryName
                    </div>
                    <div class="meta-item">
                        <i class="fas fa-clock text-primary me-1"></i>
                        <strong>Thời lượng:</strong> @Model.Course.TotalDuration phút
                    </div>
                    <div class="meta-item">
                        <i class="fas fa-signal text-primary me-1"></i>
                        <strong>Độ khó:</strong> @Model.Course.Level
                    </div>
                </div>
                
                <!-- Rating and Stats -->
                <div class="course-stats d-flex align-items-center gap-4 mb-4">
                    <div class="rating">
                        @for (int i = 1; i <= 5; i++)
                        {
                            if (i <= Model.Course.AverageRating)
                            {
                                <i class="fas fa-star text-warning"></i>
                            }
                            else
                            {
                                <i class="far fa-star text-warning"></i>
                            }
                        }
                        <span class="ms-2"><strong>@Model.Course.AverageRating.ToString("F1")</strong> (@Model.Course.ReviewCount đánh giá)</span>
                    </div>
                    <div class="enrollment-count">
                        <i class="fas fa-users text-muted me-1"></i>
                        @Model.Course.EnrollmentCount học viên
                    </div>
                    <div class="last-updated">
                        <i class="fas fa-calendar text-muted me-1"></i>
                        Cập nhật: @Model.Course.UpdatedAt.ToString("dd/MM/yyyy")
                    </div>
                </div>
            </div>
            
            <!-- Course Video Preview -->
            @if (!string.IsNullOrEmpty(Model.Course.VideoPreviewUrl))
            {
                <div class="video-preview mb-4">
                    <div class="ratio ratio-16x9">
                        <video controls poster="@Model.Course.ThumbnailUrl">
                            <source src="@Model.Course.VideoPreviewUrl" type="video/mp4">
                            Trình duyệt không hỗ trợ video.
                        </video>
                    </div>
                </div>
            }
            else if (!string.IsNullOrEmpty(Model.Course.ThumbnailUrl))
            {
                <div class="course-thumbnail mb-4">
                    <img src="@Model.Course.ThumbnailUrl" alt="@Model.Course.Title" class="img-fluid rounded">
                </div>
            }
            
            <!-- Course Tabs -->
            <div class="course-tabs">
                <ul class="nav nav-tabs" id="courseTabs" role="tablist">
                    <li class="nav-item" role="presentation">
                        <button class="nav-link active" id="overview-tab" data-bs-toggle="tab" data-bs-target="#overview" type="button">
                            Tổng quan
                        </button>
                    </li>
                    <li class="nav-item" role="presentation">
                        <button class="nav-link" id="curriculum-tab" data-bs-toggle="tab" data-bs-target="#curriculum" type="button">
                            Nội dung khóa học
                        </button>
                    </li>
                    <li class="nav-item" role="presentation">
                        <button class="nav-link" id="instructor-tab" data-bs-toggle="tab" data-bs-target="#instructor" type="button">
                            Giảng viên
                        </button>
                    </li>
                    <li class="nav-item" role="presentation">
                        <button class="nav-link" id="reviews-tab" data-bs-toggle="tab" data-bs-target="#reviews" type="button">
                            Đánh giá (@Model.Course.ReviewCount)
                        </button>
                    </li>
                </ul>
                
                <div class="tab-content" id="courseTabsContent">
                    <!-- Overview Tab -->
                    <div class="tab-pane fade show active" id="overview" role="tabpanel">
                        <div class="p-4">
                            <h4>Mô tả khóa học</h4>
                            <div class="course-description">
                                @Html.Raw(Model.Course.Description)
                            </div>
                            
                            <h5 class="mt-4">Bạn sẽ học được gì?</h5>
                            <ul class="learning-objectives">
                                @foreach (var objective in Model.Course.LearningObjectives)
                                {
                                    <li><i class="fas fa-check text-success me-2"></i>@objective</li>
                                }
                            </ul>
                            
                            <h5 class="mt-4">Yêu cầu</h5>
                            <ul class="requirements">
                                @foreach (var requirement in Model.Course.Requirements)
                                {
                                    <li><i class="fas fa-dot-circle text-primary me-2"></i>@requirement</li>
                                }
                            </ul>
                        </div>
                    </div>
                    
                    <!-- Curriculum Tab -->
                    <div class="tab-pane fade" id="curriculum" role="tabpanel">
                        <div class="p-4">
                            <div class="curriculum-info mb-3">
                                <span class="badge bg-primary">@Model.Course.Modules.Count() chương</span>
                                <span class="badge bg-info ms-2">@Model.Course.TotalLessons bài học</span>
                                <span class="badge bg-success ms-2">@Model.Course.TotalDuration phút</span>
                            </div>
                            
                            <div class="accordion" id="curriculumAccordion">
                                @foreach (var module in Model.Course.Modules.OrderBy(m => m.DisplayOrder))
                                {
                                    <div class="accordion-item">
                                        <h2 class="accordion-header" id="heading@(module.Id)">
                                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapse@(module.Id)">
                                                <div class="d-flex justify-content-between w-100 me-3">
                                                    <span><strong>Chương @(module.DisplayOrder):</strong> @module.Title</span>
                                                    <span class="text-muted">@module.Lessons.Count() bài học</span>
                                                </div>
                                            </button>
                                        </h2>
                                        <div id="collapse@(module.Id)" class="accordion-collapse collapse" data-bs-parent="#curriculumAccordion">
                                            <div class="accordion-body">
                                                @if (!string.IsNullOrEmpty(module.Description))
                                                {
                                                    <p class="text-muted mb-3">@module.Description</p>
                                                }
                                                
                                                <ul class="list-unstyled">
                                                    @foreach (var lesson in module.Lessons.OrderBy(l => l.DisplayOrder))
                                                    {
                                                        <li class="d-flex justify-content-between align-items-center py-2 border-bottom">
                                                            <div class="lesson-info">
                                                                <i class="fas fa-play-circle text-primary me-2"></i>
                                                                <span>@lesson.Title</span>
                                                                @if (lesson.IsFree)
                                                                {
                                                                    <span class="badge bg-success ms-2">Miễn phí</span>
                                                                }
                                                            </div>
                                                            <span class="text-muted">@lesson.Duration giây</span>
                                                        </li>
                                                    }
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                }
                            </div>
                        </div>
                    </div>
                    
                    <!-- Instructor Tab -->
                    <div class="tab-pane fade" id="instructor" role="tabpanel">
                        <div class="p-4">
                            <div class="instructor-profile d-flex">
                                <img src="@(Model.Course.Instructor.Avatar ?? "/images/default-avatar.jpg")" 
                                     alt="@Model.Course.InstructorName" 
                                     class="rounded-circle me-3" style="width: 80px; height: 80px; object-fit: cover;">
                                <div>
                                    <h4>@Model.Course.InstructorName</h4>
                                    <p class="text-muted">@Model.Course.Instructor.Bio</p>
                                    <div class="instructor-stats">
                                        <span class="me-3"><i class="fas fa-book me-1"></i>@Model.Course.Instructor.CourseCount khóa học</span>
                                        <span class="me-3"><i class="fas fa-users me-1"></i>@Model.Course.Instructor.StudentCount học viên</span>
                                        <span><i class="fas fa-star me-1"></i>@Model.Course.Instructor.AverageRating.ToString("F1") đánh giá</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <!-- Reviews Tab -->
                    <div class="tab-pane fade" id="reviews" role="tabpanel">
                        <div class="p-4">
                            <!-- Review Summary -->
                            <div class="review-summary mb-4">
                                <div class="row">
                                    <div class="col-md-4 text-center">
                                        <div class="average-rating">
                                            <h2 class="display-4 fw-bold text-warning">@Model.Course.AverageRating.ToString("F1")</h2>
                                            <div class="stars mb-2">
                                                @for (int i = 1; i <= 5; i++)
                                                {
                                                    <i class="fas fa-star text-warning"></i>
                                                }
                                            </div>
                                            <p class="text-muted">@Model.Course.ReviewCount đánh giá</p>
                                        </div>
                                    </div>
                                    <div class="col-md-8">
                                        <div class="rating-breakdown">
                                            @for (int i = 5; i >= 1; i--)
                                            {
                                                var count = Model.Course.Reviews.Count(r => r.Rating == i);
                                                var percentage = Model.Course.ReviewCount > 0 ? (count * 100.0 / Model.Course.ReviewCount) : 0;
                                                
                                                <div class="d-flex align-items-center mb-2">
                                                    <span class="me-2">@i sao</span>
                                                    <div class="progress flex-grow-1 me-2" style="height: 8px;">
                                                        <div class="progress-bar bg-warning" style="width: @(percentage)%"></div>
                                                    </div>
                                                    <span class="text-muted">@count</span>
                                                </div>
                                            }
                                        </div>
                                    </div>
                                </div>
                            </div>
                            
                            <!-- Individual Reviews -->
                            <div class="reviews-list">
                                @foreach (var review in Model.Course.Reviews.OrderByDescending(r => r.CreatedAt).Take(10))
                                {
                                    <div class="review-item border-bottom pb-3 mb-3">
                                        <div class="d-flex justify-content-between align-items-start mb-2">
                                            <div class="reviewer-info d-flex align-items-center">
                                                <img src="@(review.User.Avatar ?? "/images/default-avatar.jpg")" 
                                                     alt="@review.User.FullName" 
                                                     class="rounded-circle me-2" style="width: 40px; height: 40px; object-fit: cover;">
                                                <div>
                                                    <h6 class="mb-0">@review.User.FullName</h6>
                                                    <small class="text-muted">@review.CreatedAt.ToString("dd/MM/yyyy")</small>
                                                </div>
                                            </div>
                                            <div class="rating">
                                                @for (int i = 1; i <= 5; i++)
                                                {
                                                    if (i <= review.Rating)
                                                    {
                                                        <i class="fas fa-star text-warning"></i>
                                                    }
                                                    else
                                                    {
                                                        <i class="far fa-star text-warning"></i>
                                                    }
                                                }
                                            </div>
                                        </div>
                                        <p class="mb-0">@review.Comment</p>
                                    </div>
                                }
                            </div>
                            
                            @if (Model.Course.ReviewCount > 10)
                            {
                                <div class="text-center">
                                    <button class="btn btn-outline-primary" id="loadMoreReviews">
                                        Xem thêm đánh giá
                                    </button>
                                </div>
                            }
                        </div>
                    </div>
                </div>
            </div>
        </div>
        
        <!-- Sidebar -->
        <div class="col-lg-4">
            <div class="course-sidebar">
                <!-- Enrollment Card -->
                <div class="card mb-4">
                    <div class="card-body text-center">
                        <!-- Price -->
                        <div class="price-section mb-3">
                            @if (Model.Course.Price == 0)
                            {
                                <h3 class="text-success fw-bold">Miễn phí</h3>
                            }
                            else if (Model.Course.DiscountPrice.HasValue && Model.Course.DiscountPrice < Model.Course.Price)
                            {
                                <h3 class="text-danger fw-bold">@Model.Course.DiscountPrice.Value.ToString("C0")</h3>
                                <p class="text-muted text-decoration-line-through">@Model.Course.Price.ToString("C0")</p>
                                <span class="badge bg-danger">
                                    Giảm @(Math.Round((Model.Course.Price - Model.Course.DiscountPrice.Value) / Model.Course.Price * 100))%
                                </span>
                            }
                            else
                            {
                                <h3 class="text-primary fw-bold">@Model.Course.Price.ToString("C0")</h3>
                            }
                        </div>
                        
                        <!-- Enrollment Button -->
                        @if (User.Identity.IsAuthenticated)
                        {
                            @if (Model.IsEnrolled)
                            {
                                <a asp-controller="Learn" asp-action="Index" asp-route-id="@Model.Course.Id" 
                                   class="btn btn-success btn-lg w-100 mb-3">
                                    <i class="fas fa-play me-2"></i>Tiếp tục học
                                </a>
                            }
                            else
                            {
                                <form asp-action="Enroll" method="post" class="mb-3">
                                    <input type="hidden" name="courseId" value="@Model.Course.Id" />
                                    <button type="submit" class="btn btn-primary btn-lg w-100">
                                        <i class="fas fa-shopping-cart me-2"></i>Đăng ký ngay
                                    </button>
                                </form>
                            }
                            
                            <button class="btn btn-outline-danger w-100 wishlist-btn" data-course-id="@Model.Course.Id">
                                <i class="far fa-heart me-2"></i>Thêm vào yêu thích
                            </button>
                        }
                        else
                        {
                            <a asp-controller="Account" asp-action="Login" asp-route-returnUrl="@Context.Request.Path" 
                               class="btn btn-primary btn-lg w-100 mb-3">
                                <i class="fas fa-sign-in-alt me-2"></i>Đăng nhập để học
                            </a>
                        }
                    </div>
                </div>
                
                <!-- Course Info -->
                <div class="card mb-4">
                    <div class="card-header">
                        <h6 class="mb-0">Thông tin khóa học</h6>
                    </div>
                    <div class="card-body">
                        <ul class="list-unstyled mb-0">
                            <li class="d-flex justify-content-between py-2 border-bottom">
                                <span><i class="fas fa-clock text-primary me-2"></i>Thời lượng</span>
                                <span>@Model.Course.TotalDuration phút</span>
                            </li>
                            <li class="d-flex justify-content-between py-2 border-bottom">
                                <span><i class="fas fa-book text-primary me-2"></i>Bài học</span>
                                <span>@Model.Course.TotalLessons bài</span>
                            </li>
                            <li class="d-flex justify-content-between py-2 border-bottom">
                                <span><i class="fas fa-signal text-primary me-2"></i>Độ khó</span>
                                <span>@Model.Course.Level</span>
                            </li>
                            <li class="d-flex justify-content-between py-2 border-bottom">
                                <span><i class="fas fa-language text-primary me-2"></i>Ngôn ngữ</span>
                                <span>Tiếng Việt</span>
                            </li>
                            <li class="d-flex justify-content-between py-2">
                                <span><i class="fas fa-certificate text-primary me-2"></i>Chứng chỉ</span>
                                <span>Có</span>
                            </li>
                        </ul>
                    </div>
                </div>
                
                <!-- Share -->
                <div class="card">
                    <div class="card-header">
                        <h6 class="mb-0">Chia sẻ khóa học</h6>
                    </div>
                    <div class="card-body">
                        <div class="d-flex gap-2">
                            <button class="btn btn-outline-primary flex-fill" onclick="shareOnFacebook()">
                                <i class="fab fa-facebook"></i>
                            </button>
                            <button class="btn btn-outline-info flex-fill" onclick="shareOnTwitter()">
                                <i class="fab fa-twitter"></i>
                            </button>
                            <button class="btn btn-outline-success flex-fill" onclick="copyLink()">
                                <i class="fas fa-link"></i>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
    <!-- Related Courses -->
    @if (Model.RelatedCourses.Any())
    {
        <div class="row mt-5">
            <div class="col-12">
                <h3 class="fw-bold mb-4">Khóa học liên quan</h3>
                <div class="row">
                    @foreach (var course in Model.RelatedCourses)
                    {
                        <div class="col-lg-3 col-md-6 mb-4">
                            <partial name="_CourseCard" model="course" />
                        </div>
                    }
                </div>
            </div>
        </div>
    }
</div>

@section Scripts {
    <script>
        $(document).ready(function() {
            // Wishlist functionality
            $('.wishlist-btn').click(function() {
                var courseId = $(this).data('course-id');
                var btn = $(this);
                
                $.post('/api/wishlist/toggle', { courseId: courseId })
                    .done(function(response) {
                        if (response.isInWishlist) {
                            btn.html('<i class="fas fa-heart me-2"></i>Đã thêm vào yêu thích');
                            btn.removeClass('btn-outline-danger').addClass('btn-danger');
                        } else {
                            btn.html('<i class="far fa-heart me-2"></i>Thêm vào yêu thích');
                            btn.removeClass('btn-danger').addClass('btn-outline-danger');
                        }
                        
                        showToast(response.message, 'success');
                    })
                    .fail(function() {
                        showToast('Có lỗi xảy ra', 'error');
                    });
            });
            
            // Load more reviews
            $('#loadMoreReviews').click(function() {
                var courseId = @Model.Course.Id;
                var currentCount = $('.review-item').length;
                
                $.get('/api/courses/' + courseId + '/reviews', { skip: currentCount, take: 10 })
                    .done(function(data) {
                        $('.reviews-list').append(data);
                        if (data.trim() === '') {
                            $('#loadMoreReviews').hide();
                        }
                    });
            });
        });
        
        // Share functions
        function shareOnFacebook() {
            var url = encodeURIComponent(window.location.href);
            window.open('https://www.facebook.com/sharer/sharer.php?u=' + url, '_blank');
        }
        
        function shareOnTwitter() {
            var url = encodeURIComponent(window.location.href);
            var text = encodeURIComponent('@Model.Course.Title');
            window.open('https://twitter.com/intent/tweet?url=' + url + '&text=' + text, '_blank');
        }
        
        function copyLink() {
            navigator.clipboard.writeText(window.location.href).then(function() {
                showToast('Đã copy link khóa học', 'success');
            });
        }
    </script>
}
```

### 4.5. Trang chức năng giảng viên

#### 4.5.1. Dashboard giảng viên

**Mô tả chức năng:**
Dashboard dành cho giảng viên quản lý khóa học, theo dõi học viên và phân tích doanh thu.

**Nhiệm vụ chính:**
- **Quản lý khóa học:** Tạo mới, chỉnh sửa, publish/unpublish khóa học
- **Theo dõi học viên:** Xem danh sách, tiến độ và tương tác của học viên
- **Phân tích doanh thu:** Thống kê thu nhập từ các khóa học
- **Quản lý nội dung:** Upload video, tài liệu, tạo quiz và bài tập
- **Tương tác học viên:** Trả lời câu hỏi, feedback và hỗ trợ
- **Báo cáo hiệu quả:** Analytics về engagement và completion rate

#### 4.5.2. Tạo và chỉnh sửa khóa học

**Mô tả chức năng:**
Giao diện tạo khóa học cho phép giảng viên xây dựng nội dung học tập hoàn chỉnh.

**Nhiệm vụ chính:**
- **Thiết lập thông tin cơ bản:** Tên, mô tả, giá, danh mục khóa học
- **Tổ chức curriculum:** Tạo modules và lessons với thứ tự logic
- **Upload nội dung:** Video lectures, slides, documents, resources
- **Tạo assessments:** Quiz, assignments và rubric đánh giá
- **Preview khóa học:** Xem trước giao diện học viên sẽ thấy
- **Publish management:** Kiểm soát trạng thái công khai của khóa học

**InstructorController.cs:**
```csharp
[Area("Instructor")]
[Authorize(Roles = "Instructor")]
public class DashboardController : Controller
{
    private readonly ICourseService _courseService;
    private readonly IEnrollmentService _enrollmentService;
    
    public DashboardController(ICourseService courseService, IEnrollmentService enrollmentService)
    {
        _courseService = courseService;
        _enrollmentService = enrollmentService;
    }
    
    public async Task<IActionResult> Index()
    {
        var instructorId = User.GetUserId();
        
        var viewModel = new InstructorDashboardViewModel
        {
            TotalCourses = await _courseService.GetInstructorCourseCountAsync(instructorId),
            TotalStudents = await _enrollmentService.GetInstructorStudentCountAsync(instructorId),
            TotalRevenue = await _courseService.GetInstructorRevenueAsync(instructorId),
            RecentCourses = await _courseService.GetInstructorRecentCoursesAsync(instructorId, 5),
            RecentEnrollments = await _enrollmentService.GetRecentEnrollmentsAsync(instructorId, 10),
            MonthlyStats = await _courseService.GetInstructorMonthlyStatsAsync(instructorId, 12)
        };
        
        return View(viewModel);
    }
}
```

### 4.6. Trang quản trị viên

#### 4.6.1. Admin Dashboard

**Mô tả chức năng:**
Dashboard tổng quan cho quản trị viên giám sát và quản lý toàn bộ hệ thống.

**Nhiệm vụ chính:**
- **Giám sát hệ thống:** Theo dõi performance, uptime và health checks
- **Quản lý người dùng:** CRUD operations cho users, roles và permissions
- **Kiểm duyệt nội dung:** Review và approve/reject khóa học mới
- **Phân tích dữ liệu:** Reports về users, courses, revenue, engagement
- **Cấu hình hệ thống:** Settings, categories, payment methods
- **Xử lý khiếu nại:** Manage disputes, refunds và support tickets

#### 4.6.2. Quản lý người dùng

**Mô tả chức năng:**
Giao diện quản lý toàn bộ người dùng trong hệ thống với các quyền khác nhau.

**Nhiệm vụ chính:**
- **User management:** Tạo, sửa, xóa, khóa/mở khóa tài khoản
- **Role assignment:** Phân quyền Student, Instructor, Admin
- **Activity monitoring:** Theo dõi hoạt động và hành vi người dùng
- **Bulk operations:** Thao tác hàng loạt với nhiều users
- **Security management:** Password resets, suspicious activity alerts
- **Communication:** Gửi thông báo và email đến users

#### 4.6.3. Quản lý khóa học và nội dung

**Mô tả chức năng:**
Kiểm soát chất lượng và quản lý toàn bộ nội dung khóa học trên nền tảng.

**Nhiệm vụ chính:**
- **Content moderation:** Review và approve khóa học trước khi publish
- **Quality control:** Đảm bảo tiêu chuẩn chất lượng nội dung
- **Category management:** Quản lý danh mục và tags
- **Featured content:** Chọn khóa học nổi bật hiển thị trang chủ
- **Violation handling:** Xử lý nội dung vi phạm policy
- **Analytics:** Thống kê về khóa học phổ biến và xu hướng

**AdminController.cs:**
```csharp
[Area("Admin")]
[Authorize(Roles = "Admin")]
public class DashboardController : Controller
{
    private readonly IUserService _userService;
    private readonly ICourseService _courseService;
    private readonly ISystemService _systemService;
    
    public async Task<IActionResult> Index()
    {
        var viewModel = new AdminDashboardViewModel
        {
            TotalUsers = await _userService.GetTotalUsersAsync(),
            TotalCourses = await _courseService.GetTotalCoursesAsync(),
            TotalRevenue = await _courseService.GetTotalRevenueAsync(),
            PendingCourses = await _courseService.GetPendingCoursesCountAsync(),
            RecentUsers = await _userService.GetRecentUsersAsync(10),
            SystemHealth = await _systemService.GetSystemHealthAsync(),
            MonthlyGrowth = await _systemService.GetMonthlyGrowthAsync(12)
        };
        
        return View(viewModel);
    }
}
```

---

## CHƯƠNG 5: KẾT LUẬN VÀ HƯỚNG PHÁT TRIỂN

### 5.1. Kết luận

#### 5.1.1. Kết quả đạt được

**Về mặt kỹ thuật:**

Đồ án đã thành công trong việc xây dựng một hệ thống website chia sẻ khóa học trực tuyến hoàn chỉnh sử dụng công nghệ ASP.NET Core MVC. Các kết quả cụ thể đạt được bao gồm:

1. **Kiến trúc hệ thống vững chắc:**
   - Áp dụng thành công mô hình MVC với separation of concerns rõ ràng
   - Triển khai 3-layer architecture (Presentation, Business Logic, Data Access)
   - Sử dụng Dependency Injection và Repository pattern hiệu quả
   - Code structure có tính maintainability và scalability cao

2. **Cơ sở dữ liệu tối ưu:**
   - Thiết kế database schema với 12 bảng chính và các mối quan hệ phù hợp
   - Sử dụng Entity Framework Core với Code First approach
   - Triển khai indexing và optimization cho performance
   - Đảm bảo data integrity với constraints và foreign keys

3. **Giao diện người dùng hiện đại:**
   - Responsive design với Bootstrap 5 framework
   - UX/UI thân thiện và trực quan
   - Cross-browser compatibility
   - Mobile-first approach

4. **Tính năng nghiệp vụ đầy đủ:**
   - Hệ thống authentication và authorization với ASP.NET Identity
   - CRUD operations hoàn chỉnh cho tất cả entities
   - Search và filtering với multiple criteria
   - File upload và management
   - Real-time notifications với SignalR

**Về mặt chức năng:**

Hệ thống đã triển khai thành công các chức năng cốt lõi của một nền tảng e-learning:

1. **Đối với học viên:**
   - ✅ Đăng ký, đăng nhập và quản lý profile
   - ✅ Tìm kiếm, lọc và duyệt khóa học
   - ✅ Đăng ký học và theo dõi tiến độ
   - ✅ Đánh giá và wishlist management
   - ✅ Personal dashboard với statistics

2. **Đối với giảng viên:**
   - ✅ Tạo và quản lý khóa học
   - ✅ Upload nội dung và tổ chức curriculum
   - ✅ Theo dõi học viên và engagement
   - ✅ Revenue tracking và analytics
   - ✅ Instructor dashboard

3. **Đối với quản trị viên:**
   - ✅ User management và role assignment
   - ✅ Course moderation và approval
   - ✅ System monitoring và health checks
   - ✅ Comprehensive reporting và analytics
   - ✅ Admin dashboard với real-time data

**Về mặt hiệu suất và bảo mật:**

1. **Performance optimization:**
   - Database query optimization với proper indexing
   - Caching implementation với MemoryCache
   - Lazy loading và pagination cho large datasets
   - Image optimization và CDN integration
   - Async/await pattern throughout the application

2. **Security measures:**
   - HTTPS enforcement và secure headers
   - Input validation và XSS prevention
   - CSRF protection với anti-forgery tokens
   - SQL injection prevention với parameterized queries
   - Secure password hashing với bcrypt

#### 5.1.2. Ý nghĩa của đề tài

**Ý nghĩa học thuật:**

1. **Ứng dụng kiến thức lý thuyết:** Đồ án đã thành công trong việc áp dụng các kiến thức lý thuyết về lập trình web, cơ sở dữ liệu, và software engineering vào một dự án thực tế có quy mô và độ phức tạp cao.

2. **Rèn luyện kỹ năng chuyên môn:** Quá trình thực hiện đã giúp nâng cao kỹ năng phân tích, thiết kế, và triển khai hệ thống phần mềm, đặc biệt là trong lĩnh vực web development với .NET ecosystem.

3. **Hiểu biết về software development lifecycle:** Từ requirements analysis, system design, implementation, testing đến deployment, đồ án đã cung cấp trải nghiệm toàn diện về quy trình phát triển phần mềm chuyên nghiệp.

**Ý nghĩa thực tiễn:**

1. **Đóng góp vào giáo dục trực tuyến:** Sản phẩm tạo ra có thể được sử dụng thực tế để hỗ trợ việc dạy và học trực tuyến, đặc biệt quan trọng trong bối cảnh post-COVID khi e-learning trở thành xu hướng chủ đạo.

2. **Giải pháp cho tổ chức giáo dục:** Hệ thống có thể được triển khai cho các trường học, trung tâm đào tạo, hoặc doanh nghiệp có nhu cầu đào tạo nội bộ.

3. **Nền tảng cho startup:** Với architecture scalable và feature-rich, sản phẩm có thể trở thành nền tảng cho các startup trong lĩnh vực EdTech.

#### 5.1.3. Đánh giá tổng quan

**Điểm mạnh của dự án:**

1. **Technical excellence:** Sử dụng công nghệ hiện đại và best practices
2. **Comprehensive features:** Đầy đủ chức năng cho một nền tảng e-learning
3. **Scalable architecture:** Có thể mở rộng và maintain dễ dàng
4. **User-centric design:** Tập trung vào trải nghiệm người dùng
5. **Security-first approach:** Đảm bảo bảo mật ở mọi layer

**Hạn chế và thách thức:**

1. **Complexity management:** Độ phức tạp cao đòi hỏi kinh nghiệm và kỹ năng sâu
2. **Performance optimization:** Cần continuous monitoring và tuning
3. **Content delivery:** Video streaming và large file handling cần infrastructure mạnh
4. **Scalability testing:** Chưa được test với high concurrent users
5. **Mobile app:** Chưa có native mobile application

### 5.2. Hướng phát triển của đề tài

#### 5.2.1. Tính năng mở rộng ngắn hạn (3-6 tháng)

**1. Payment Integration:**
```csharp
// VNPay Integration
public class VNPayService : IPaymentService
{
    public async Task<PaymentResult> ProcessPaymentAsync(PaymentRequest request)
    {
        // VNPay API integration
        // Handle payment callback
        // Update enrollment status
    }
}

// Stripe Integration for international payments
public class StripeService : IPaymentService
{
    public async Task<PaymentResult> ProcessPaymentAsync(PaymentRequest request)
    {
        // Stripe API integration
        // Handle webhooks
        // Manage subscriptions
    }
}
```

**2. Advanced Video Player:**
- Video streaming với adaptive bitrate
- Subtitle support và multiple languages
- Video analytics và watch time tracking
- Offline download capability
- Interactive video elements (quizzes, notes)

**3. Mobile Application:**
```csharp
// Xamarin.Forms hoặc .NET MAUI
public class MobileApiController : ControllerBase
{
    [HttpGet("courses/mobile")]
    public async Task<IActionResult> GetCoursesForMobile([FromQuery] MobileFilterRequest request)
    {
        var courses = await _courseService.GetCoursesForMobileAsync(request);
        return Ok(courses);
    }
    
    [HttpPost("sync")]
    public async Task<IActionResult> SyncOfflineData([FromBody] OfflineSyncRequest request)
    {
        await _syncService.SyncUserDataAsync(request);
        return Ok();
    }
}
```

**4. Advanced Analytics:**
```csharp
public class AnalyticsService : IAnalyticsService
{
    public async Task<LearningAnalytics> GetLearningAnalyticsAsync(int userId)
    {
        return new LearningAnalytics
        {
            CompletionRate = await CalculateCompletionRateAsync(userId),
            LearningPath = await GetOptimalLearningPathAsync(userId),
            SkillGaps = await IdentifySkillGapsAsync(userId),
            Recommendations = await GetPersonalizedRecommendationsAsync(userId)
        };
    }
}
```

#### 5.2.2. Tính năng mở rộng trung hạn (6-12 tháng)

**1. AI-Powered Features:**

*Personalized Learning:*
```csharp
public class AIRecommendationService
{
    public async Task<List<Course>> GetAIRecommendationsAsync(int userId)
    {
        var userProfile = await _userService.GetLearningProfileAsync(userId);
        var mlModel = await _mlService.LoadRecommendationModelAsync();
        
        var predictions = mlModel.Predict(userProfile);
        return await _courseService.GetCoursesByIdsAsync(predictions.CourseIds);
    }
}
```

*Automated Content Generation:*
```csharp
public class ContentGenerationService
{
    public async Task<Quiz> GenerateQuizAsync(int lessonId)
    {
        var lessonContent = await _lessonService.GetContentAsync(lessonId);
        var aiQuestions = await _aiService.GenerateQuestionsAsync(lessonContent);
        
        return new Quiz
        {
            LessonId = lessonId,
            Questions = aiQuestions,
            GeneratedAt = DateTime.UtcNow
        };
    }
}
```

**2. Advanced Communication:**

*Real-time Chat và Video Conferencing:*
```csharp
public class CommunicationHub : Hub
{
    public async Task JoinCourseRoom(int courseId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, $"course_{courseId}");
    }
    
    public async Task SendMessage(int courseId, string message)
    {
        await Clients.Group($"course_{courseId}").SendAsync("ReceiveMessage", Context.User.Identity.Name, message);
    }
    
    public async Task StartVideoCall(int courseId, string roomId)
    {
        await Clients.Group($"course_{courseId}").SendAsync("VideoCallStarted", roomId);
    }
}
```

**3. Blockchain Integration:**

*Certificate Verification:*
```csharp
public class BlockchainCertificateService
{
    public async Task<string> IssueCertificateAsync(int userId, int courseId)
    {
        var certificate = new DigitalCertificate
        {
            UserId = userId,
            CourseId = courseId,
            IssuedAt = DateTime.UtcNow,
            Hash = GenerateHash()
        };
        
        var transactionHash = await _blockchainService.RecordCertificateAsync(certificate);
        return transactionHash;
    }
    
    public async Task<bool> VerifyCertificateAsync(string certificateHash)
    {
        return await _blockchainService.VerifyTransactionAsync(certificateHash);
    }
}
```

#### 5.2.3. Tính năng mở rộng dài hạn (1-2 năm)

**1. Virtual Reality (VR) Learning:**
```csharp
public class VRLearningService
{
    public async Task<VRSession> CreateVRSessionAsync(int courseId, int lessonId)
    {
        var vrContent = await _contentService.GetVRContentAsync(lessonId);
        
        return new VRSession
        {
            SessionId = Guid.NewGuid(),
            CourseId = courseId,
            LessonId = lessonId,
            VREnvironment = vrContent.Environment,
            InteractiveElements = vrContent.Elements
        };
    }
}
```

**2. Microlearning Platform:**
```csharp
public class MicrolearningService
{
    public async Task<List<MicroLesson>> GenerateMicroLessonsAsync(int courseId)
    {
        var course = await _courseService.GetAsync(courseId);
        var microLessons = new List<MicroLesson>();
        
        foreach (var lesson in course.Lessons)
        {
            var chunks = await _aiService.ChunkContentAsync(lesson.Content, maxDuration: 300); // 5 minutes
            microLessons.AddRange(chunks.Select(chunk => new MicroLesson
            {
                OriginalLessonId = lesson.Id,
                Content = chunk.Content,
                Duration = chunk.Duration,
                LearningObjective = chunk.Objective
            }));
        }
        
        return microLessons;
    }
}
```

**3. Advanced Gamification:**
```csharp
public class GamificationEngine
{
    public async Task<UserProgress> UpdateProgressAsync(int userId, LearningActivity activity)
    {
        var user = await _userService.GetAsync(userId);
        var points = CalculatePoints(activity);
        var badges = await CheckBadgeEligibilityAsync(userId, activity);
        
        user.TotalPoints += points;
        user.Level = CalculateLevel(user.TotalPoints);
        
        if (badges.Any())
        {
            await _badgeService.AwardBadgesAsync(userId, badges);
        }
        
        // Trigger achievements
        await _achievementService.CheckAchievementsAsync(userId);
        
        return new UserProgress
        {
            PointsEarned = points,
            NewBadges = badges,
            CurrentLevel = user.Level,
            NextLevelProgress = CalculateNextLevelProgress(user.TotalPoints)
        };
    }
}
```

#### 5.2.4. Kiến trúc và công nghệ tương lai

**1. Microservices Architecture:**
```yaml
# docker-compose.yml
version: '3.8'
services:
  user-service:
    image: onlinelearning/user-service:latest
    ports:
      - "5001:80"
    
  course-service:
    image: onlinelearning/course-service:latest
    ports:
      - "5002:80"
    
  payment-service:
    image: onlinelearning/payment-service:latest
    ports:
      - "5003:80"
    
  notification-service:
    image: onlinelearning/notification-service:latest
    ports:
      - "5004:80"
    
  api-gateway:
    image: onlinelearning/api-gateway:latest
    ports:
      - "5000:80"
    depends_on:
      - user-service
      - course-service
      - payment-service
```

**2. Cloud-Native Deployment:**
```yaml
# kubernetes-deployment.yml
apiVersion: apps/v1
kind: Deployment
metadata:
  name: online-learning-platform
spec:
  replicas: 3
  selector:
    matchLabels:
      app: online-learning-platform
  template:
    metadata:
      labels:
        app: online-learning-platform
    spec:
      containers:
      - name: web-app
        image: onlinelearning/web-app:latest
        ports:
        - containerPort: 80
        env:
        - name: ConnectionStrings__DefaultConnection
          valueFrom:
            secretKeyRef:
              name: db-secret
              key: connection-string
```

**3. Event-Driven Architecture:**
```csharp
public class CourseEnrollmentHandler : IEventHandler<UserEnrolledEvent>
{
    public async Task HandleAsync(UserEnrolledEvent @event)
    {
        // Update analytics
        await _analyticsService.RecordEnrollmentAsync(@event.UserId, @event.CourseId);
        
        // Send welcome email
        await _emailService.SendWelcomeEmailAsync(@event.UserId, @event.CourseId);
        
        // Update instructor dashboard
        await _dashboardService.UpdateInstructorStatsAsync(@event.CourseId);
        
        // Trigger recommendations update
        await _recommendationService.UpdateUserRecommendationsAsync(@event.UserId);
    }
}
```

#### 5.2.5. Roadmap tổng quan

**Phase 1 (0-6 tháng): Foundation Enhancement**
- Payment gateway integration
- Mobile app development
- Advanced video player
- Performance optimization
- Security hardening

**Phase 2 (6-12 tháng): Intelligence Layer**
- AI-powered recommendations
- Automated content generation
- Advanced analytics và reporting
- Real-time communication features
- Blockchain certificate system

**Phase 3 (1-2 năm): Innovation Platform**
- VR/AR learning experiences
- Microlearning platform
- Advanced gamification
- Microservices architecture
- Global scalability

**Phase 4 (2+ năm): Ecosystem Expansion**
- Corporate learning solutions
- Marketplace for third-party integrations
- API platform for developers
- International expansion
- Strategic partnerships

---

## TÀI LIỆU THAM KHẢO

### Sách và tài liệu học thuật

1. **Freeman, A., & Sanderson, S.** (2022). *Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages*. 9th Edition. Apress.

2. **Lock, A.** (2021). *ASP.NET Core in Action, Second Edition*. Manning Publications.

3. **Smith, S., & Ardalis** (2020). *Architecting Modern Web Applications with ASP.NET Core and Microsoft Azure*. Microsoft Press.

4. **Lerman, J., & Miller, R.** (2022). *Programming Entity Framework: DbContext*. O'Reilly Media.

5. **Fowler, M.** (2018). *Patterns of Enterprise Application Architecture*. Addison-Wesley Professional.

### Tài liệu kỹ thuật và documentation

6. **Microsoft Corporation** (2024). *ASP.NET Core Documentation*. Retrieved from https://docs.microsoft.com/en-us/aspnet/core/

7. **Microsoft Corporation** (2024). *Entity Framework Core Documentation*. Retrieved from https://docs.microsoft.com/en-us/ef/core/

8. **Bootstrap Team** (2024). *Bootstrap 5 Documentation*. Retrieved from https://getbootstrap.com/docs/5.3/

9. **jQuery Foundation** (2024). *jQuery API Documentation*. Retrieved from https://api.jquery.com/

### Nghiên cứu và báo cáo thị trường

10. **Global Market Insights** (2023). *Online Learning Market Size By Technology, By Provider, By Application, Industry Analysis Report, Regional Outlook, Growth Potential, Competitive Market Share & Forecast, 2023 – 2032*.

11. **Coursera Inc.** (2023). *Global Skills Report 2023: Skills-based hiring and the future of work*. Coursera Impact Report.

12. **Udemy Inc.** (2023). *2023 Workplace Learning Trends Report: The Skills of the Future*. Udemy Business.

### Bài báo khoa học

13. **Dhawan, S.** (2020). Online Learning: A Panacea in the Time of COVID-19 Crisis. *Journal of Educational Technology Systems*, 49(1), 5-22.

14. **Means, B., Toyama, Y., Murphy, R., & Baki, M.** (2013). The effectiveness of online and blended learning: A meta-analysis of the empirical literature. *Teachers College Record*, 115(3), 1-47.

15. **Siemens, G.** (2013). Learning analytics: The emergence of a discipline. *American Behavioral Scientist*, 57(10), 1380-1400.

### Tài liệu về UX/UI Design

16. **Norman, D.** (2013). *The Design of Everyday Things: Revised and Expanded Edition*. Basic Books.

17. **Krug, S.** (2014). *Don't Make Me Think, Revisited: A Common Sense Approach to Web Usability*. New Riders.

18. **Nielsen, J.** (2020). *Usability Engineering*. Morgan Kaufmann.

### Tài liệu về Database Design

19. **Hernandez, M. J.** (2013). *Database Design for Mere Mortals: A Hands-On Guide to Relational Database Design*. 3rd Edition. Addison-Wesley Professional.

20. **Date, C. J.** (2019). *Database Design and Relational Theory: Normal Forms and All That Jazz*. 2nd Edition. O'Reilly Media.

### Web Standards và Best Practices

21. **W3C** (2024). *Web Content Accessibility Guidelines (WCAG) 2.1*. Retrieved from https://www.w3.org/WAI/WCAG21/

22. **Mozilla Developer Network** (2024). *Web APIs*. Retrieved from https://developer.mozilla.org/en-US/docs/Web/API

23. **OWASP Foundation** (2024). *OWASP Top Ten Web Application Security Risks*. Retrieved from https://owasp.org/www-project-top-ten/

### Tài liệu về Software Architecture

24. **Martin, R. C.** (2017). *Clean Architecture: A Craftsman's Guide to Software Structure and Design*. Prentice Hall.

25. **Evans, E.** (2003). *Domain-Driven Design: Tackling Complexity in the Heart of Software*. Addison-Wesley Professional.

### Blogs và Resources

26. **Scott Hanselman** (2024). *Hanselman.com - ASP.NET Core Tips and Tricks*. Retrieved from https://www.hanselman.com/

27. **Jon Skeet** (2024). *C# in Depth Blog*. Retrieved from https://codeblog.jonskeet.uk/

28. **Stack Overflow** (2024). *ASP.NET Core Questions and Answers*. Retrieved from https://stackoverflow.com/questions/tagged/asp.net-core

---

## PHỤ LỤC

### Phụ lục A: Cấu trúc Database Schema

```sql
-- Complete Database Schema
-- Generated on: 2024-12-28

-- Users Table
CREATE TABLE [dbo].[Users] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Email] NVARCHAR(256) NOT NULL UNIQUE,
    [PasswordHash] NVARCHAR(MAX) NOT NULL,
    [FullName] NVARCHAR(100) NOT NULL,
    [Role] NVARCHAR(20) NOT NULL DEFAULT 'Student',
    [Avatar] NVARCHAR(500) NULL,
    [Bio] NVARCHAR(1000) NULL,
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME2 DEFAULT GETUTCDATE(),
    [IsActive] BIT DEFAULT 1,
    [EmailConfirmed] BIT DEFAULT 0,
    [LastLoginAt] DATETIME2 NULL
);

-- Categories Table
CREATE TABLE [dbo].[Categories] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL,
    [Slug] NVARCHAR(100) NOT NULL UNIQUE,
    [Description] NVARCHAR(500) NULL,
    [Icon] NVARCHAR(50) NULL,
    [ParentId] INT NULL,
    [DisplayOrder] INT DEFAULT 0,
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE(),
    [IsActive] BIT DEFAULT 1,
    FOREIGN KEY ([ParentId]) REFERENCES [Categories]([Id])
);

-- Courses Table
CREATE TABLE [dbo].[Courses] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Title] NVARCHAR(200) NOT NULL,
    [Slug] NVARCHAR(200) NOT NULL UNIQUE,
    [ShortDescription] NVARCHAR(500) NULL,
    [Description] NVARCHAR(MAX) NULL,
    [Price] DECIMAL(18,2) NOT NULL DEFAULT 0,
    [DiscountPrice] DECIMAL(18,2) NULL,
    [ThumbnailUrl] NVARCHAR(500) NULL,
    [VideoPreviewUrl] NVARCHAR(500) NULL,
    [Level] NVARCHAR(20) DEFAULT 'Beginner',
    [Language] NVARCHAR(10) DEFAULT 'vi',
    [Duration] INT DEFAULT 0,
    [InstructorId] INT NOT NULL,
    [CategoryId] INT NOT NULL,
    [CreatedAt] DATETIME2 DEFAULT GETUTCDATE(),
    [UpdatedAt] DATETIME2 DEFAULT GETUTCDATE(),
    [PublishedAt] DATETIME2 NULL,
    [IsPublished] BIT DEFAULT 0,
    [IsFeatured] BIT DEFAULT 0,
    [ViewCount] INT DEFAULT 0,
    [EnrollmentCount] INT DEFAULT 0,
    FOREIGN KEY ([InstructorId]) REFERENCES [Users]([Id]),
    FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])
);

-- Additional tables...
-- (Modules, Lessons, Enrollments, Reviews, Wishlists, etc.)
```

### Phụ lục B: API Endpoints Documentation

```yaml
# API Documentation
openapi: 3.0.0
info:
  title: Online Learning Platform API
  version: 1.0.0
  description: RESTful API for Online Learning Platform

paths:
  /api/courses:
    get:
      summary: Get list of courses
      parameters:
        - name: page
          in: query
          schema:
            type: integer
            default: 1
        - name: pageSize
          in: query
          schema:
            type: integer
            default: 10
        - name: category
          in: query
          schema:
            type: string
        - name: search
          in: query
          schema:
            type: string
      responses:
        200:
          description: Successful response
          content:
            application/json:
              schema:
                type: object
                properties:
                  data:
                    type: array
                    items:
                      $ref: '#/components/schemas/Course'
                  totalCount:
                    type: integer
                  pageCount:
                    type: integer

  /api/courses/{id}:
    get:
      summary: Get course by ID
      parameters:
        - name: id
          in: path
          required: true
          schema:
            type: integer
      responses:
        200:
          description: Course found
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/CourseDetails'
        404:
          description: Course not found

components:
  schemas:
    Course:
      type: object
      properties:
        id:
          type: integer
        title:
          type: string
        slug:
          type: string
        shortDescription:
          type: string
        price:
          type: number
        discountPrice:
          type: number
        thumbnailUrl:
          type: string
        level:
          type: string
        instructorName:
          type: string
        categoryName:
          type: string
        averageRating:
          type: number
        enrollmentCount:
          type: integer
```

### Phụ lục C: Deployment Guide

```bash
# Production Deployment Guide

# 1. Prerequisites
# - Windows Server 2019/2022 or Linux (Ubuntu 20.04+)
# - .NET 9.0 Runtime
# - SQL Server 2019+ or Azure SQL Database
# - IIS (Windows) or Nginx (Linux)

# 2. Build and Publish
dotnet publish -c Release -o ./publish

# 3. Database Migration
dotnet ef database update --connection "Server=...;Database=...;..."

# 4. IIS Configuration (Windows)
# - Create Application Pool (.NET CLR Version: No Managed Code)
# - Create Website pointing to publish folder
# - Install ASP.NET Core Hosting Bundle

# 5. Nginx Configuration (Linux)
server {
    listen 80;
    server_name yourdomain.com;
    location / {
        proxy_pass http://localhost:5000;
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection keep-alive;
        proxy_set_header Host $host;
        proxy_cache_bypass $http_upgrade;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto $scheme;
    }
}

# 6. SSL Configuration with Let's Encrypt
sudo certbot --nginx -d yourdomain.com

# 7. Environment Variables
export ASPNETCORE_ENVIRONMENT=Production
export ConnectionStrings__DefaultConnection="Server=...;Database=...;..."

# 8. Service Configuration (Linux)
sudo systemctl enable onlinelearning.service
sudo systemctl start onlinelearning.service
```

### Phụ lục D: Performance Benchmarks

```
Performance Test Results
========================

Test Environment:
- Server: Azure Standard B2s (2 vCPUs, 4GB RAM)
- Database: Azure SQL Database (Basic tier)
- Load Testing Tool: NBomber

Scenarios Tested:
1. Homepage Load
2. Course List with Filters
3. Course Details Page
4. User Registration
5. Course Enrollment

Results:
--------
Homepage Load:
- Concurrent Users: 100
- Average Response Time: 245ms
- 95th Percentile: 380ms
- Throughput: 408 req/sec
- Error Rate: 0%

Course List (with filters):
- Concurrent Users: 50
- Average Response Time: 312ms
- 95th Percentile: 485ms
- Throughput: 160 req/sec
- Error Rate: 0%

Course Details:
- Concurrent Users: 75
- Average Response Time: 198ms
- 95th Percentile: 295ms
- Throughput: 378 req/sec
- Error Rate: 0%

Database Performance:
- Average Query Time: 45ms
- Slowest Query: Course search with filters (125ms)
- Index Usage: 98.5%
- Cache Hit Ratio: 94.2%
```

### Phụ lục E: Security Checklist

```markdown
# Security Implementation Checklist

## Authentication & Authorization
- [x] ASP.NET Core Identity implementation
- [x] Strong password policy enforcement
- [x] Account lockout after failed attempts
- [x] Two-factor authentication support
- [x] Role-based access control
- [x] JWT token implementation for API

## Data Protection
- [x] HTTPS enforcement (HSTS)
- [x] Secure cookie configuration
- [x] Data encryption at rest
- [x] Connection string encryption
- [x] Personal data anonymization
- [x] GDPR compliance measures

## Input Validation
- [x] Server-side validation for all inputs
- [x] XSS prevention (HTML encoding)
- [x] SQL injection prevention (parameterized queries)
- [x] CSRF protection (anti-forgery tokens)
- [x] File upload validation and sanitization
- [x] Request size limitations

## Security Headers
- [x] Content Security Policy (CSP)
- [x] X-Frame-Options
- [x] X-Content-Type-Options
- [x] X-XSS-Protection
- [x] Referrer-Policy
- [x] Permissions-Policy

## Logging & Monitoring
- [x] Security event logging
- [x] Failed login attempt monitoring
- [x] Suspicious activity detection
- [x] Error logging without sensitive data
- [x] Audit trail for admin actions
- [x] Real-time security alerts
```

---

**Kết thúc báo cáo**

*Báo cáo này được hoàn thành vào ngày 28 tháng 12 năm 2024*  
*Tổng số trang: 48*  
*Sinh viên thực hiện: Đoàn Phước Miền*  
*Lớp: [Tên lớp]*  
*Khoa Công nghệ Thông tin*