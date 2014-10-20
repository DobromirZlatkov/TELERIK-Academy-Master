using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELERIK_KPK_UnitTesting
{
    public class Course
    {
        public const int maxStudentInCourse = 29;
        private List<Student> studentsInTheCourse = new List<Student>();
        private string name;

        public Course(string name, IEnumerable<Student> studentsInTheCourse)
        {
            this.StudentsInTheCourse = new List<Student>(studentsInTheCourse);
            this.Name = name;
        }

        public List<Student> StudentsInTheCourse
        {
            get
            {
                return this.studentsInTheCourse;
            }
            set
            {
                bool isAllStudentsUnique = isAllStudentsHaveUniqueNumber(value);

                if (!isAllStudentsUnique)
                {
                    throw new ArgumentException("Not all the students have unique number");
                }

                if (value.Count > maxStudentInCourse)
                {
                    throw new ArgumentOutOfRangeException("The course should not have more then 30 students");
                }

                this.studentsInTheCourse = value;
            }
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
                    throw new ArgumentNullException("The name of the course can't be null or empty");
                }
                this.name = value;
            }
        }

        public void AddStudent(Student newStudent)
        {
            bool isTheNumberUnique = isTheNumberOfStudentUnique(newStudent);

            if (!isTheNumberUnique)
            {
                throw new ArgumentException("There can't be two student's with the same unique number in the school");
            }

            if (this.studentsInTheCourse.Count + 1 > maxStudentInCourse)
            {
                throw new ArgumentOutOfRangeException("The limet of the course is reach - 30 Students");
            }

            this.studentsInTheCourse.Add(newStudent);
        }

        public void RemoveStudent(Student studentForRemove)
        {
            if (isTheNumberOfStudentUnique(studentForRemove))
            {
                throw new ArgumentException("There no such student in the Course");
            }

            this.studentsInTheCourse.Remove(studentForRemove);
        }

        public bool isTheNumberOfStudentUnique(Student checkedStudent)
        {
            foreach (var student in this.StudentsInTheCourse)
            {
                if (student.UniqueNumber == checkedStudent.UniqueNumber)
                {
                    return false;
                }
            }

            return true;
        }

        public bool isAllStudentsHaveUniqueNumber(List<Student> students)
        {
            for (int index = 0; index < students.Count - 1; index++)
            {
                for (int indexToTheEnd = index + 1; indexToTheEnd < students.Count; indexToTheEnd++)
                {
                    if (students[index].UniqueNumber == students[indexToTheEnd].UniqueNumber)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
