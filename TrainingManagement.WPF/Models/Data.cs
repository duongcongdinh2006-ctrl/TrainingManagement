using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.WPF.Models
{
    // File: Programme.cs
    public class Programme
    {
        public int Id { get; set; }
        public string ProgrammeName { get; set; } = string.Empty;
        public int TotalCredits { get; set; }
    }

    // File: Semester.cs
    public class Semester
    {
        public int Id { get; set; }
        public string SemesterName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    // File: Room.cs
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string RoomType { get; set; } = string.Empty;
    }

    // File: Lecturer.cs
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
    }

    // File: Course.cs
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public int Credits { get; set; }
    }
    public class TrainingPlan
    {
        public int Id { get; set; }
        public string PlanName { get; set; } = string.Empty;
        public int AcademicYear { get; set; }
        public int ProgrammeId { get; set; }
        public Programme? Programme { get; set; }
        public ICollection<TrainingPlanCourse> TrainingPlanCourses { get; set; } = new List<TrainingPlanCourse>();
    }

    public class TrainingPlanCourse
    {
        public int Id { get; set; }
        public int TrainingPlanId { get; set; }
        public TrainingPlan? TrainingPlan { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int RecommendedSemester { get; set; }
    }
}
