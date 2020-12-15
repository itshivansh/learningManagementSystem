using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Repo
{
    public interface ICourseRepo
    {
        Course AddCourse(Course course);
        List<Course> GetCourses();
        List<Course> GetCourseById(int id);
        bool DeleteCourse(int id);
        public bool IsCourseExist(Course course);
        public bool IsCourseExistWithId(int id);
    }
}
