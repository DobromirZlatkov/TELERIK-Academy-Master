using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfStudents
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        { 
            get{ return this.firstName; }
            set{ this.firstName = value;}
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }        
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName)
        { 
            this.age = age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.firstName + " " + this.lastName + " " + this.age);
            return sb.ToString();
        }


        public static void FirstBeforeSecond(Student[] students)
        {
            var secondBeforeFirstSecondWay =
                students.
                Where(student => student.FirstName.CompareTo(student.LastName) < 0).
                Select(student => student);
            foreach (var item in secondBeforeFirstSecondWay)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

    }
}
