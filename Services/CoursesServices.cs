using System;
using UniversitySystem.Interfaces;
using UniversitySystem.Models;

namespace UniversitySystem.Services
{
    public class CoursesServices : ICoursesServices
    {
        ICoursesRepository _repository;
        public CoursesServices(ICoursesRepository courseRepo)
        {
            _repository = courseRepo;
        }

       bool CourseValdation(Courses course)
        {
            if (course == null) return false;
            if (course.Id == null ||
                course.Name == null ||
                course.Major == null) return false;
            if (course.Hours < 0) return false;
            if (_repository.GetCourseById(course.Id)
                != null) return false;

            return true;
        }
       public bool CreateCourse(Courses course)
       {
            return CourseValdation(course) ? _repository.AddCourse(course) : false;
            
       }

    }
}
