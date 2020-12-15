using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Exception
{
    public class CourseNotFound:ApplicationException
    {
        public CourseNotFound()
        {

        }
        public CourseNotFound(string message):base(message)
        {
                
        }
    }
}
