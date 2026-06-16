
using System;

namespace UniversitySystem.Models
{
    public class Divisions
    {
        public string Id { get; set; }
        public string DivisionNumber { get; set; }
        public string CoursesId { get; set; }
        public int Capacity { get; set; }
        public DateTime Time { get; set; }
        public DateTime Date { get; set; }
        public string Lecturer { get; set; }
    }
}
