using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfStudents
{
    class MainClass
    {
        static void Main(string[] args)
        {
       
            Student[] students =
            {
                new Student("Ivan", "Avanov", 18),
                new Student("Georgi", "Ivanov", 14),
                new Student("Todor", "Batkov", 24),
                new Student("Georgi", "Syrmov", 20),
                new Student("Petar", "Vejdireshidov", 55),
                new Student("Genadi", "Popov", 25)
            };
            //task 3
            FirstBeforeSecond(students);
            //task 4
            Console.WriteLine();
            Console.WriteLine();
            //task 5
            FindStudentsBetween18and24(students);
            Console.WriteLine();
            Console.WriteLine();
            OrderByLambda(students);
            Console.WriteLine();
            Console.WriteLine();
            OrderByLinq(students);
        }

        private static void OrderByLinq(Student[] students)
        {
            var orderByLastName =
                from student in students
                orderby student.FirstName, student.LastName 
                select student.FirstName + " " + student.LastName;
            foreach (var item in orderByLastName)
            {
                Console.WriteLine(item);
            }
        }

        private static void OrderByLambda(Student[] students)
        {
            var orderByFirstName = students.OrderBy(st => st.FirstName).ThenBy(st => st.LastName);
            foreach (var item in orderByFirstName)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

        private static void FindStudentsBetween18and24(Student[] students)
        {
            var findStudentsBetween18and24 =
                from student in students
                where student.Age > 17 && student.Age < 25
                select  student.FirstName + " " + student.LastName ;
            foreach (var student in findStudentsBetween18and24)
            {
                Console.WriteLine(student);
            }
        }

        public static void FirstBeforeSecond(Student[] students)
        {
            var secondBeforeFirstSecondWay =
                 from student in students
                 where student.FirstName.CompareTo(student.LastName) == -1
                 select student;
            foreach (var item in secondBeforeFirstSecondWay)
            {
                Console.WriteLine(item.ToString());
            }
        }


    }
}
