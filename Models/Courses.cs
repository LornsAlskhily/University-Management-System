namespace UniversitySystem.Models
{
    public class Courses
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PrerequisiteId { get; set; }
        public string Major { get; set; }
        public int Hours { get; set; }

    }
}
