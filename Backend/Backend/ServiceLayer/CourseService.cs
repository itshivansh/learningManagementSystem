using Backend.Exception;
using Backend.Models;
using Backend.Repo;
using System.Collections.Generic;

namespace Backend.ServiceLayer
{
    #region Service
    public class CourseService : ICourseService
    {
        private readonly ICourseRepo _courseRepository;
        public CourseService(ICourseRepo courseRepository)
        {
            _courseRepository = courseRepository;
        }

        #region Add
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
        #endregion

        #region Delete

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
        #endregion

        #region GetById
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
        #endregion

        #region Get
        List<Course> ICourseService.GetCourses()
        {
            return _courseRepository.GetCourses();
        }
        #endregion
    }
    #endregion
}
