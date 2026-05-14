using System.Collections.Generic;
using UniversitySystem.Models;

namespace UniversitySystem.Interfaces
{
    internal interface ICoursesRepository
    {
        List<Courses> GetAllCourses();
        Courses GetCourseById(string id);
        bool AddCourse(Courses course);
    }
}
