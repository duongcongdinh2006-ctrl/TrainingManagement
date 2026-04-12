using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Input;
using TrainingManagement.WPF.Models; // Điều chỉnh namespace cho khớp project của bri

namespace TrainingManagement.WPF.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            // Đảm bảo database đã được tạo
            context.Database.Migrate();

            // 1. Seed Programmes (Chương trình đào tạo)
            if (!context.Programmes.Any())
            {
                context.Programmes.AddRange(
                    new Programme { ProgrammeName = "Kỹ thuật Phần mềm", TotalCredits = 120 },
                    new Programme { ProgrammeName = "Trí tuệ Nhân tạo", TotalCredits = 120 },
                    new Programme { ProgrammeName = "Quản lý Hoạt động Bay", TotalCredits = 130 }
                );
                context.SaveChanges();
            }

            // 2. Seed Semesters (Học kỳ)
            if (!context.Semesters.Any())
            {
                context.Semesters.AddRange(
                    new Semester { SemesterName = "Học kỳ 1 (2025 - 2026)", StartDate = new DateTime(2025, 9, 5), EndDate = new DateTime(2026, 1, 15) },
                    new Semester { SemesterName = "Học kỳ 2 (2025 - 2026)", StartDate = new DateTime(2026, 2, 10), EndDate = new DateTime(2026, 6, 20) },
                    new Semester { SemesterName = "Học kỳ Hè (2025 - 2026)", StartDate = new DateTime(2026, 7, 1), EndDate = new DateTime(2026, 8, 15) }
                );
                context.SaveChanges();
            }

            // 3. Seed Rooms (Phòng học)
            if (!context.Rooms.Any())
            {
                context.Rooms.AddRange(
                    new Room { RoomName = "Phòng máy PM1", Capacity = 40, RoomType = "Thực hành" },
                    new Room { RoomName = "Phòng máy PM2", Capacity = 40, RoomType = "Thực hành" },
                    new Room { RoomName = "Phòng lý thuyết F201", Capacity = 60, RoomType = "Lý thuyết" },
                    new Room { RoomName = "Phòng lý thuyết F202", Capacity = 60, RoomType = "Lý thuyết" },
                    new Room { RoomName = "Hội trường A", Capacity = 150, RoomType = "Lý thuyết" }
                );
                context.SaveChanges();
            }

            // 4. Seed Lecturers (Giảng viên)
            if (!context.Lecturers.Any())
            {
                context.Lecturers.AddRange(
                    new Lecturer { Name = "Nguyễn Văn A", Email = "nva@university.edu.vn", Department = "Khoa CNTT" },
                    new Lecturer { Name = "Trần Thị B", Email = "ttb@university.edu.vn", Department = "Khoa CNTT" },
                    new Lecturer { Name = "Lê Hoàng C", Email = "lhc@university.edu.vn", Department = "Khoa Cơ bản" },
                    new Lecturer { Name = "Phạm Đình D", Email = "pdd@university.edu.vn", Department = "Khoa Khai thác Hàng không" },
                    new Lecturer { Name = "Vũ Trọng E", Email = "vte@university.edu.vn", Department = "Khoa CNTT" }
                );
                context.SaveChanges();
            }

            // 5. Seed Courses (Học phần - khoảng 10 môn)
            if (!context.Courses.Any())
            {
                context.Courses.AddRange(
                    new Course { CourseCode = "IT101", CourseName = "Lập trình C++", Credits = 3 },
                    new Course { CourseCode = "IT102", CourseName = "Nhập môn Python", Credits = 3 },
                    new Course { CourseCode = "IT201", CourseName = "Cơ sở dữ liệu (SQL)", Credits = 4 },
                    new Course { CourseCode = "IT202", CourseName = "Kiến trúc máy tính (Assembly)", Credits = 3 },
                    new Course { CourseCode = "IT301", CourseName = "Phân tích thiết kế hệ thống", Credits = 3 },
                    new Course { CourseCode = "MATH101", CourseName = "Toán cơ sở (Giải tích đa biến)", Credits = 3 },
                    new Course { CourseCode = "MATH102", CourseName = "Toán rời rạc", Credits = 3 },
                    new Course { CourseCode = "AVIA101", CourseName = "Luật Hàng không", Credits = 2 },
                    new Course { CourseCode = "AVIA102", CourseName = "Khí tượng Hàng không", Credits = 2 },
                    new Course { CourseCode = "MIL101", CourseName = "Giáo dục Quốc phòng An ninh", Credits = 0 } // Thường tính theo chứng chỉ
                );
                context.SaveChanges();
            }
            if (!context.TrainingPlans.Any())
            {
                var program = context.Programmes.FirstOrDefault();
                if (program != null)
                {
                    context.TrainingPlans.Add(new TrainingPlan { PlanName = "Kế hoạch 2026", AcademicYear = 2026, ProgrammeId = program.Id });
                    context.SaveChanges();
                }
            }
        }
    }
}