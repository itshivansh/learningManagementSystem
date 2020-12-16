using Backend.Models;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;

namespace Backend.Repo
{
    #region Repo
    public class CourseRepo : ICourseRepo
    {
        CourseContext context;
        private int id;

        public CourseRepo(CourseContext _context)
        {
            context = _context;
        }
        #region Add
        public Course AddCourse(Course course)
        {
            context.Courses.InsertOne(course);
            return course;
        }
        #endregion

        #region Delete
        public bool DeleteCourse(int id)
        {
            {
                var deletedStatus = context.Courses.DeleteOne(x => x.Id == id);
                return deletedStatus.IsAcknowledged && deletedStatus.DeletedCount > 0;
            }
        }
        #endregion

        #region GetById
        public List<Course> GetCourseById(int id)
        {
            return context.Courses.Find(x => x.Id == id).ToList();
        }
        #endregion

        #region Get
        public List<Course> GetCourses()
        {
            return context.Courses.Find(x => true).ToList();
        }
        #endregion

        #region ExistenceCheck
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
        #endregion

        #region ExistenceWithId
        bool ICourseRepo.IsCourseExistWithId(int id)
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
        #endregion


    }
    #endregion

}