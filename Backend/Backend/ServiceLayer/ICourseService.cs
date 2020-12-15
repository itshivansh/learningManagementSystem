using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.ServiceLayer
{
    interface ICourseService

    {
        Course AddCourse(Course course);

        List<Course> GetCourses();

        List<Course> GetCourseById(int id);

        bool DeleteCourse(int id);
    }
}
