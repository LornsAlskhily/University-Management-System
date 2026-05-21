using System.Collections.Generic;
using UniversitySystem.Models;

namespace UniversitySystem.Interfaces
{
    public interface ICoursesRepository
    {
        List<Courses> GetAllCourses();
        Courses GetCourseById(string id);
        bool AddCourse(Courses course);
    }
}
