using System;

namespace Backend.Exception
{
    #region Start
    public class CourseNotFound:ApplicationException
    {
        public CourseNotFound()
        {

        }
        public CourseNotFound(string message):base(message)
        {
                
        }
    }
    #endregion
}
