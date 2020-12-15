using Backend.Exception;
using Backend.Models;
using Backend.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.ServiceLayer
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepo _courseRepository;
        public CourseService(ICourseRepo courseRepository)
        {
            _courseRepository = courseRepository;
        }
        Course ICourseService.AddCourse(Course course)
        {
            var courseAvailablity = _courseRepository.IsCourseExist(course);
            if (courseAvailablity)
            {
                return _courseRepository.AddCourse(course);
            }
            else
            {
                throw new CourseAlreadyexist("course already existy");
            }
        }

        bool ICourseService.DeleteCourse(int id)
        {
            var courseAvailablity = _courseRepository.IsCourseExistWithId(id);
            if (courseAvailablity)
            {
                return _courseRepository.DeleteCourse(id);
            }
            else
            {
                throw new CourseNotFound("Course does not exist");
            }
        }

        List<Course> ICourseService.GetCourseById(int id)
        {
            var courseAvailablity = _courseRepository.IsCourseExistWithId(id);
            if (courseAvailablity)
            {
                return _courseRepository.GetCourseById(id);
            }
            else
            {
                throw new CourseNotFound("Course does not exist");
            }
        }

        List<Course> ICourseService.GetCourses()
        {
            return _courseRepository.GetCourses();
        }
    }
}
