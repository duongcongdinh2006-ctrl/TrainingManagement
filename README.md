🎓 Hệ Thống Quản Lý Kế Hoạch Đào Tạo (TMS)
Dự án Nhóm 04 — Môn Công nghệ .NET

Chào anh em! Đây là repo chính thức của dự án. Tui (Định - Tech Lead) đã dựng sẵn khung xương MVVM và cấu hình Database. Anh em đọc kỹ hướng dẫn bên dưới để bắt đầu "cày" task nhé.

🛠 1. Công nghệ sử dụng
Ngôn ngữ: C#

Framework UI: WPF (.NET 6/8)

Kiến trúc: MVVM (Model-View-ViewModel)

Database: SQLite (Gọn nhẹ, không cần cài SQL Server)

ORM: Entity Framework Core

🚀 2. Hướng dẫn cài đặt cho anh em
Để chạy được project trên máy cá nhân, anh em làm đúng các bước:

Clone project:

Bash
git clone [Link_Repo_Của_Nhom_Minh]
Mở Solution: Mở file TrainingManagement.sln bằng Visual Studio 2022.

Restore NuGet Packages: Visual Studio sẽ tự động tải các thư viện (EF Core, SQLite, CsvHelper). Nếu không thấy chạy, vào Tools > NuGet Package Manager > Manage NuGet Packages for Solution để kiểm tra.

Chạy App (F5): - Lần đầu chạy, hệ thống sẽ tự động tạo file Training.db.

Dữ liệu mẫu (Seed Data) về học phần, giảng viên, phòng học sẽ tự động được bơm vào để anh em test UI.

🏗 3. Cấu trúc Project (Quan trọng!)
Anh em chú ý code đúng thư mục quy định để không bị loạn:

📁 Models: Chứa các class thực thể (Course, Room, Lecturer...).

📁 ViewModels: Chứa logic xử lý cho giao diện. Tất cả ViewModel phải kế thừa BaseViewModel.

📁 Views: Chứa file .xaml giao diện. TUYỆT ĐỐI KHÔNG viết code logic vào file .xaml.cs (code-behind).

📁 Data: Chứa AppDbContext và SeedData.

📁 Services: Chứa các class xử lý logic dùng chung (ví dụ: Export CSV, Conflict Detection).

🚦 4. Quy trình làm việc với Git
Để tránh đè code lên nhau, anh em tuân thủ:

Không code trực tiếp trên nhánh main.

Tạo nhánh riêng cho task của mình:

Cú pháp: feature/ten-thanh-vien-ten-module

Ví dụ: feature/dev2-course-crud

Commit message chuẩn:

Thêm tính năng: feat(UC01): mo ta ngan gon

Sửa lỗi: fix(UI): sua loi mau nut bam

Push code: Sau khi làm xong, push nhánh của mình lên rồi báo tui review để merge vào main.

⚠️ Lưu ý cho anh em
File Training.db đã được tui cho vào danh sách phớt lờ (.gitignore). Anh em yên tâm là mỗi máy sẽ có một database riêng, không lo bị conflict data khi push code.

Nếu thêm bảng mới vào Database, hãy báo tui để tui tạo Migration dùng chung cho cả nhóm.
