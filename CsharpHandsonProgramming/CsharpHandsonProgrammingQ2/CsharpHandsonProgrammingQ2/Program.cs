using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHandsonProgrammingQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var course = new Course("course", 10, 100);
            var partCourse = new PartTimeCourse("partCourse", 10, 100);
            var onsiteCourse = new OnsiteCourse("onsiteCourse", 10, 100);


            course.Print();
            partCourse.Print();
            onsiteCourse.Print();
        }
    }
}
