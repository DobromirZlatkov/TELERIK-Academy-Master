using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities1 dataBase = new TelerikAcademyEntities1();
            Stopwatch stopWatch = new Stopwatch();


            //Task1
            //stopWatch.Start();
            //PrintAllStudentsDepartmentAndTown(dataBase);
            //stopWatch.Stop();
            //Console.WriteLine(stopWatch.Elapsed);
            //stopWatch.Reset();

            //stopWatch.Start();
            //PrintAllStudentsDepartmentAndTownWithInclude(dataBase);
            //stopWatch.Stop();
            //Console.WriteLine(stopWatch.Elapsed);
            //stopWatch.Reset();


            //Task2
            stopWatch.Start();
            var employees = dataBase.Employees.ToList().Select(e => e.Address).ToList().Select(a => a.Town).ToList().Where(t => t.Name == "Sofia");
            stopWatch.Stop();   
            Console.WriteLine("Slow Query "  + stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            var employeesFast = dataBase.Employees.Select(e => e.Address).Select(a => a.Town).Where(t => t.Name == "Sofia");
            stopWatch.Stop();
            Console.WriteLine("Fast Query " +stopWatch.Elapsed);
        }

        private static void PrintAllStudentsDepartmentAndTownWithInclude(TelerikAcademyEntities1 dataBase)
        {
            foreach (var employee in dataBase.Employees.Include("Address.Town").Include("Department"))
            {
                Console.WriteLine(employee.FirstName + " " + employee.Department.Name + " " + employee.Address.Town.Name);
            }
        }

        private static void PrintAllStudentsDepartmentAndTown(TelerikAcademyEntities1 dataBase)
        {
            foreach (var employee in dataBase.Employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.Department.Name + " " + employee.Address.Town.Name);
            }
        }


    }
}
