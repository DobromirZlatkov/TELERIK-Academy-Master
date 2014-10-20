using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        private string name;
        private IList<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Teacher name cannot be null");
                }
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string[] teacherCoursesName = new string[courses.Count] ;
            int indexer = 0;
            foreach (var course in courses)
            {

                teacherCoursesName[indexer] = course.Name;
                indexer++;
            }
            string teacherCoursesComaSeparated = string.Join(",",teacherCoursesName);

            result.Append(string.Format("Teacher: Name={0}", this.Name));
            if (courses.Count > 0)
            {
                result.Append(string.Format("; "));                
                result.Append(string.Format("Courses=[{0}]", teacherCoursesComaSeparated));
            }
            result.AppendLine();
            return result.ToString();
        }
    }
}
