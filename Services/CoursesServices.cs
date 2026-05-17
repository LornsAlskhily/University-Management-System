using System;
using UniversitySystem.Interfaces;
using UniversitySystem.Models;
using UniversitySystem.Repositories;

namespace UniversitySystem.Services
{
    public class CoursesServices : ICoursesServices
    {
      public string IdGeneration()
        {
            throw new NotImplementedException();
        }
      public bool CreateCourse(Courses course)
        {
            if (course == null) return false;
            if (course.Id == null && course.Name == null && course.Major == null) return false;
            if (course.Hours < 0) return false;

            new CoursesRepository().AddCourse(course);
            return true;
        }
    }
}
