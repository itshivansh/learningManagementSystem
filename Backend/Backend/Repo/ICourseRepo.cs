using System.Collections.Generic;
using Backend.Models;

namespace Backend.Repo
{
    #region Repo_Interface
    public interface ICourseRepo
    {
        Course AddCourse(Course course);
        List<Course> GetCourses();
        List<Course> GetCourseById(int id);
        bool DeleteCourse(int id);
        public bool IsCourseExist(Course course);
        public bool IsCourseExistWithId(int id);
    }
    #endregion
}
