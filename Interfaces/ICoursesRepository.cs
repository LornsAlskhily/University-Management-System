using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
