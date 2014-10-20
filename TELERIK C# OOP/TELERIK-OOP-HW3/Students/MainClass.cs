using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class MainClass
    {
        static Student[] students;
        static void Main()
        {
            students = new Student[]
            {
                new Student("Ivan Gacov", "Papazite"),
                new Student("Ivo Andonov", "Drakonite"),
                new Student("Martin Hristov", "Papazite"),
                new Student("Komisar Popov", "Drakonite"),
                new Student("Ico Hazarta", "Oktopodite"),
                new Student("Bat Venci", "Papazite")
            };
            //18 task
            GroupWithLinq();
            //19 task
            GroupWithLambda();
        }

        private static void GroupWithLambda()
        {
            var gropupedStudents = students.GroupBy(x => x.GroupName).OrderBy(x => x.Key);
            foreach (var group in gropupedStudents)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FullName);
                }
                Console.WriteLine();
            }
        }

        private static void GroupWithLinq()
        {
            var gropupedStudents =
                from student in students
                group student by student.GroupName into newGroup
                orderby newGroup.Key
                select newGroup;
            foreach (var group in gropupedStudents)
            {
                Console.WriteLine(group.Key);              
                foreach (var student  in group)
                {
                    Console.WriteLine(student.FullName);
                }
                Console.WriteLine();
            }
        }
    }
}
