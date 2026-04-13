using Microsoft.EntityFrameworkCore;
using TrainingManagement.WPF.Models; // Sửa lại thành Namespace project của bri

namespace TrainingManagement.WPF.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        public DbSet<TrainingPlanCourse> TrainingPlanCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình lưu file SQLite thẳng vào thư mục chạy app
            optionsBuilder.UseSqlite("Data Source=Training.db");
        }
    }
}