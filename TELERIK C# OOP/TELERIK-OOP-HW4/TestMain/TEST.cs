using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPROGRAM
{
    class TEST
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Lioko", 12, new List<string>());

            Student secondStudent = new Student("Koko", 22, new List<string>());

            Student thirdStudent = new Student("Smoko", 32, new List<string>());

            Teacher firstTeacher = new Teacher("Pesho", new List<Discipline>());

            Teacher secondTeacher = new Teacher("Pepi", new List<Discipline>());

            SchoolClass firstClass = new SchoolClass("First A Class", new List<Teacher>() { firstTeacher, secondTeacher }, new List<Student> { firstStudent, secondStudent });
          
            firstStudent.AddComment("Smart guy");
           
            firstStudent.AddComment("Bad in Mathematics");
           
            Discipline mathematics = new Discipline("Mathematics", 4, 8);
            
            Discipline biology = new Discipline("Biology", 2, 4);
            
            firstTeacher.AddDiscipline(mathematics);

            firstTeacher.AddDiscipline(biology);
            
            foreach (var item in firstStudent.Comment)
            {
                Console.WriteLine(item);
            }

            foreach (var item in firstTeacher.Disciplines)
            {
                Console.WriteLine(item);
            }
        }
    }
}
