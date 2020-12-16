using Backend.Models;
using System.Collections.Generic;

namespace Backend.ServiceLayer
{
    public interface ICourseService
    #region Service_Interface

    {
        Course AddCourse(Course course);

        List<Course> GetCourses();

        List<Course> GetCourseById(int id);

        bool DeleteCourse(int id);
    }
    #endregion
}
