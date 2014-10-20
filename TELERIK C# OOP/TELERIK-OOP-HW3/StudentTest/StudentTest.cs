using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    class StudentTest
    {
        public static List<Student> students;
        static void Main(string[] args)
        {
            students = new List<Student>
            {
                new Student("Ivan", "Ivanov", 430606, "02/088-88-88-88", "vanka@gmail.com", new List<int>{5,6}, 2),
                new Student("Petkan", "Chaushev", 1231234, "02/088-77-87-78", "peshkata@abv.bg", new List<int>{2,3,2}, 1),
                new Student("Genadi", "Gruev", 4321235, "073/089-89-89-98", "gruio@gmail.com", new List<int>{4,6,4}, 2 ),
                new Student("Nadejda", "Tzareva", 1312325, "123/086-11-87-81", "natka@abv.bg", new List<int>{5,6,2,6}, 3 ),
                new Student("Rosen", "Gacov", 11060606, "099-99-99-99", "kukata@gmail.com", new List<int>{5,6,6,6,6}, 2),
                new Student("Ivo", "Andonov", 22014236, "077-87-77-77", "ivaka@abv.bg", new List<int>{5,6,2,2,2,2}, 1),
            };

            //task 9
            SelectStudentsFromGroup2ByLINQ();
            //task 10
            SelectStudentsFromGroup2ByLAMBDA();
            //task 11
            ExtractStudentsWithAbvMail();
            //taskt 12
            ExtractStudentsWithNumberFromSofia();
            //task 13
            FIndStudentsWithOneExelentMark();
            //task 14
            FindStudentsWithTwoPoorMarks();
            //task 15
            MarksOfStudentsEnrolledIn2006();
            //task 16
            ExtractStudentsWithMathematics();
        }
        
        
        
       
        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
        //task 9 Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. Create a List<Student> with sample students. Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
        public static void SelectStudentsFromGroup2ByLINQ()
        {
            var secondGroup =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            PrintStudents(secondGroup); 
        }
        //task 10 Implement the previous using the same query expressed with extension methods.
        public static void SelectStudentsFromGroup2ByLAMBDA()
        {
            var secondGroup = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
                
            PrintStudents(secondGroup);
        }
        //task 11 Extract all students that have email in abv.bg. Use string methods and LINQ.
        public static void ExtractStudentsWithAbvMail()
        {
            var studentsWithAbv =
                from student in students
                where student.Email.Contains("abv.bg")
                select student;
            PrintStudents(studentsWithAbv);
        }
        //task 12 Extract all students with phones in Sofia. Use LINQ.
        public static void ExtractStudentsWithNumberFromSofia()
        {
            var studentsFromSofia =
                from student in students
                where student.Tel.StartsWith("02")
                select student;
            PrintStudents(studentsFromSofia);
        }
        //task 13 Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
        public static void FIndStudentsWithOneExelentMark()
        {
            var studentsWithExelentMark =
                from student in students
                where student.Marks.Contains(6)
                select new { Fullname = student.FirstName + " " + student.LastName, Marks = student.TakeAllMarks() };

            foreach (var student in studentsWithExelentMark)
            {
                Console.WriteLine(student.Fullname + " : " + student.Marks);
            }
        }
        //task 14 Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
        public static void FindStudentsWithTwoPoorMarks()
        {
            var studentsWithPoorMarks =
                from student in students
                where student.Marks.Count(m => m == 2) == 2
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.TakeAllMarks() };

            foreach (var student in studentsWithPoorMarks)
            {
                Console.WriteLine(student.FullName + " : " + student.Marks);
            }
        }
        //task 15 Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        public static void MarksOfStudentsEnrolledIn2006()
        {
            var studentsFrom2006 = students.Where(st => st.FacNumber.ToString().Substring(4, 2) == "06");

            PrintStudents(studentsFrom2006);
        }
        //task 16 * Create a class Group with properties GroupNumber and DepartmentName. Introduce a property Group in the Student class. Extract all students from "Mathematics" department. Use the Join operator.
        public static void ExtractStudentsWithMathematics()
        {
            Group[] groups = new Group[]
            {
                new Group(2,"Mathematics"),
                new Group(3,"Biology"),
                new Group(4,"Fizics"),
                new Group(5,"Chemistry"),               
            };

            var studentsWithMathematics =
                from student in students
                join gr in groups on student.GroupNumber equals gr.GroupNumber
                where gr.DepartmentName == "Mathematics"
                select student;

            foreach (var item in studentsWithMathematics)
            {
                Console.WriteLine(item);
            }
        }
       

    }
}
