using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELERIK_KPK_UnitTesting
{
    public class School
    {
        public List<Course> Courses { get; set; }

        public School(IEnumerable<Course> courses)
        {

            if (!isAllStudentsHaveUniqueNumber(new List<Course>(courses)))
            {
                throw new ArgumentException("Not all students have the uniqueNumber");
            }
            this.Courses = new List<Course>(courses);

        }

        public bool isAllStudentsHaveUniqueNumber(List<Course> allCourses)
        {
            for (int indexCheckedCourse = 0; indexCheckedCourse < allCourses.Count - 1; indexCheckedCourse++)
            {
                for (int indexTheRestOfTheCourses = indexCheckedCourse + 1; indexTheRestOfTheCourses < allCourses.Count; indexTheRestOfTheCourses++)
                {
                    foreach (var itemOne in allCourses[indexCheckedCourse].StudentsInTheCourse)
                    {
                        foreach (var item in allCourses[indexTheRestOfTheCourses].StudentsInTheCourse)
                        {
                            if (itemOne.UniqueNumber == item.UniqueNumber)
                            {
                                return false;
                            }
                        }
                    }
                }

            }
            return true;
        }
    }
}
