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
}
