using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Backend.Repo
{
    public class CourseRepo : ICourseRepo
    {
        CourseContext context;
        private int id;

        public CourseRepo(CourseContext _context)
        {
            context = _context;
        }
        public Course AddCourse(Course course)
        {
            context.Courses.InsertOne(course);
            return course;
        }

        public bool DeleteCourse(int id)
        {
            {
                var deletedStatus = context.Courses.DeleteOne(x => x.Id == id);
                return deletedStatus.IsAcknowledged && deletedStatus.DeletedCount > 0;
            }
        }

        public List<Course> GetCourseById(int id)
        {
            return context.Courses.Find(x => x.Id == id).ToList();
        }

        public List<Course> GetCourses()
        {
            return context.Courses.Find(x => x.Id == id).ToList();
        }

        public bool IsCourseExist(Course course)
        {
            {
                var courseExist = context.Courses.Find(courses => courses.Id == course.Id);
                if (courseExist != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public bool IsCourseExistWithId(int id)
        {
            bool ICourseRepository.IsCourseExistWithId(int id)
        {
                var courseExist = context.Courses.Find(x => x.Id == id).FirstOrDefault();
                if (courseExist != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}