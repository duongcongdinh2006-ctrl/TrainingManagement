🎓 Hệ Thống Quản Lý Kế Hoạch Đào Tạo (TMS)
Dự án phát triển phần mềm Hệ Thống Quản Lý Kế Hoạch Đào Tạo (Training Management System) dành cho học phần Công nghệ .NET. Hệ thống được xây dựng với kiến trúc MVVM, tối ưu hóa giao diện cho ứng dụng Desktop và sử dụng cơ sở dữ liệu SQLite cục bộ.

Đơn vị thực hiện: Nhóm 04 - Đại học Công Thương TP. Hồ Chí Minh (HUIT)

Technical Lead: Dương Công Định

🛠 1. Công Nghệ Sử Dụng
Ngôn ngữ: C#

Framework UI: Windows Presentation Foundation (WPF) trên nền tảng .NET 6/8

Kiến trúc: MVVM (Model-View-ViewModel)

Cơ sở dữ liệu: SQLite (Gọn nhẹ, hoạt động độc lập không cần cài đặt server)

ORM: Entity Framework Core (EF Core)

🚀 2. Hướng Dẫn Cài Đặt (Getting Started)
Yêu cầu môi trường: Visual Studio 2022 và .NET SDK 6/8.

Thực hiện các bước sau để chạy dự án trên môi trường local:

Bước 1: Clone kho lưu trữ

Bash
git clone [https://github.com/duongcongdinh2006-ctrl/TrainingManagement.git]
Bước 2: Cài đặt các Dependencies
Mở file TrainingManagement.sln bằng Visual Studio 2022. Quá trình Restore NuGet Packages (EF Core, SQLite, CsvHelper) sẽ tự động diễn ra.
Lưu ý: Nếu thư viện không tự tải, vui lòng điều hướng đến Tools > NuGet Package Manager > Manage NuGet Packages for Solution để restore thủ công.

Bước 3: Khởi chạy ứng dụng
Nhấn F5 hoặc chọn Start Debugging.

Ở lần chạy đầu tiên, hệ thống sẽ tự động khởi tạo file cơ sở dữ liệu Training.db.

Dữ liệu mẫu (Seed Data) bao gồm danh sách học phần, giảng viên và phòng học sẽ được tự động thêm vào để phục vụ quá trình kiểm thử giao diện.

🏗 3. Cấu Trúc Thư Mục Dự Án
Việc tuân thủ kiến trúc thư mục là bắt buộc để đảm bảo tính nhất quán của pattern MVVM:

📁 Models/: Chứa các lớp thực thể đại diện cho cấu trúc dữ liệu (VD: Course, Room, Lecturer).

📁 ViewModels/: Xử lý logic và ràng buộc dữ liệu (Data Binding) cho giao diện. Mọi ViewModel đều phải kế thừa từ BaseViewModel.

📁 Views/: Nơi lưu trữ các file giao diện .xaml. Tuyệt đối không viết logic xử lý vào file code-behind (.xaml.cs).

📁 Data/: Chứa cấu hình ngữ cảnh cơ sở dữ liệu (AppDbContext) và file cấp phát dữ liệu mẫu (SeedData).

📁 Services/: Xử lý các nghiệp vụ logic độc lập dùng chung trên toàn hệ thống (VD: ExportCsvService, ConflictDetectionService).

🚦 4. Quy Trình Làm Việc Với Git (Git Workflow)
Để hạn chế xung đột mã nguồn (conflict), toàn bộ thành viên vui lòng tuân thủ quy trình sau:

1. Quản lý nhánh (Branching):

Không commit và push trực tiếp lên nhánh main.

Tạo nhánh làm việc riêng cho từng tính năng từ nhánh main với cú pháp: feature/[tên-thành-viên]-[tên-module]

Ví dụ: feature/dev2-course-crud

2. Tiêu chuẩn Commit Message:
Sử dụng tiền tố để phân loại thay đổi:

feat(Tên_Module): [Mô tả tính năng mới] (VD: feat(UC01): them chuc nang them xoa sua hoc phan)

fix(Tên_Module): [Mô tả lỗi đã sửa] (VD: fix(UI): sua loi mau nut bam luu du lieu)

refactor(Tên_Module): [Mô tả việc tối ưu code]

3. Tích hợp mã nguồn (Merge/Pull Request):
Sau khi hoàn thiện tính năng trên nhánh cá nhân, thực hiện Push nhánh lên remote repository và báo cáo với Technical Lead để tiến hành Code Review trước khi Merge vào main.

⚠️ 5. Lưu Ý Quan Trọng
Về Cơ sở dữ liệu: File Training.db đã được định cấu hình trong file .gitignore. CSDL ở mỗi máy local sẽ hoạt động độc lập, không gây ra lỗi ghi đè dữ liệu giữa các thành viên khi đẩy code.

Về Migrations: Nếu có sự thay đổi về cấu trúc bảng (Models) cần cập nhật xuống Database, vui lòng thông báo cho Tech Lead để tạo file Migration chuẩn hóa dùng chung cho toàn dự án.
