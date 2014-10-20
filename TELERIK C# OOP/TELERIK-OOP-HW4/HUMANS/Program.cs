using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMANS
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aliosha = new Student("Aliosha", "Papazov", 12);
            Console.WriteLine(aliosha.ToString());
            Student[] students = 
            {
                new Student("Aliosha", "Papazov", 12),
                new Student("Bocko", "Papazov", 11),
                new Student("Roko", "Papazov", 10),
                new Student("Koko", "Papazov", 12),
                new Student("Lioko", "Papazov", 2),
                new Student("Kukata", "Papazov", 9),
                new Student("Rukulata", "Papazov", 5),
                new Student("Musketa", "Papazov", 4),
                new Student("Pesho", "Papazov", 3),
                new Student("Vancho", "Papazov", 1),
                new Student("Mishe", "Papazov", 8),
            };
            Worker[] workers = 
            {
                new Worker("Aliosha", "Davidov", 12, 21),
                new Worker("Bocko", "Davidov", 11, 224),
                new Worker("Roko", "Davidov", 10, 211),
                new Worker("Rukulata", "Davidov", 9, 221),
                new Worker("Lioko", "Davidov", 8, 11),
                new Worker("Mishe", "Davidov", 7, 111),
                new Worker("Pesho", "Davidov", 6, 121),
                new Worker("Koko", "Davidov", 8, 421),
                new Worker("Vancho", "Davidov", 11, 221),
                new Worker("Genadi", "Davidov", 4, 9),
            };

            SortStudentsByGrade(students);

            SortWorkersBySelaryPerHour(workers);

            var mergeLists = workers.Concat<Human>(students);
            OrderMergedListsByName(mergeLists);

        }

        private static void OrderMergedListsByName(IEnumerable<Human> mergeLists)
        {
            var orderByName = mergeLists.OrderBy(li => li.FristName).ThenBy(li => li.LastName);
            foreach (var human in orderByName)
            {
                Console.WriteLine(human.FristName + " " + human.LastName);
            }
        }

        private static void SortWorkersBySelaryPerHour(Worker[] workers)
        {
            var workersPayPerHour = workers.OrderByDescending(wr => wr.MoneyPerHour());
            foreach (var worker in workersPayPerHour)
            {
                Console.WriteLine(worker.ToString() +"Money per hour: " + worker.MoneyPerHour());
            }
        }

        private static void SortStudentsByGrade(Student[] students)
        {
            var orderByGrade = students.OrderBy(st => st.Grade);
            foreach (var item in orderByGrade)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
