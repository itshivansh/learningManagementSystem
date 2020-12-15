using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Exception
{
    public class CourseAlreadyexist:ApplicationException
    {
        public CourseAlreadyexist()
        {

        }
        public CourseAlreadyexist(string message):base(message)
        {

        }
    }
}
