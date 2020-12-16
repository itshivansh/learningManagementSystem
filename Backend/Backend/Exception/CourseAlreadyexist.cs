using System;

namespace Backend.Exception
{
    #region Start
    public class CourseAlreadyexist:ApplicationException
    {
        public CourseAlreadyexist()
        {

        }
        public CourseAlreadyexist(string message):base(message)
        {

        }
    }
    #endregion
}
