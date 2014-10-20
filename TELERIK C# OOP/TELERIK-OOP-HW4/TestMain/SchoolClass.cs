using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class SchoolClass : SchoolObj
    {
        public List<Teacher> teachers;
        public List<Student> students;      
       //properties
        public List<Student> Students
        {
            get { return this.students; }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
        }
        //constructors
        public SchoolClass(string name,List<Teacher> teachers, List<Student> students)
            : base(name)
        {
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();           
        }
        public SchoolClass(string name, List<Teacher> teachers, List<Student> students, List<string> comments)
            : base(name, comments)            
        { 
            this.teachers = new List<Teacher>();
            this.students = new List<Student>(); 
        }

        // methods
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }


    }
}
