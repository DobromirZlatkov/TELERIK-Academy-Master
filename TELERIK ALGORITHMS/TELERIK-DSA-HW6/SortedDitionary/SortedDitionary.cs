using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDitionary
{
    class SortedDitionary
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Dictionary<string, string>> sortedCourses = new SortedDictionary<string, Dictionary<string, string>>();
            try
            {
                using (StreamReader sr = new StreamReader("students.txt"))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        var words = line.Split(new Char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        var firstName = words[0].Trim();
                        var lastName = words[1].Trim();
                        var course = words[2].Trim();
                        line = sr.ReadLine();

                        if (!sortedCourses.ContainsKey(course))
                        {
                            sortedCourses[course] = new Dictionary<string, string>();
                        }

                        sortedCourses[course].Add(firstName, lastName);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            foreach (var courseStudentObject in sortedCourses)
            {
                Console.Write(courseStudentObject.Key + ": ");
                var sortedNamesByFirstAndLastName = courseStudentObject.Value.OrderBy(val => val.Key).ThenBy(val => val.Value);

                foreach (var person in sortedNamesByFirstAndLastName)
                {
                    Console.Write(person.Key + " " + person.Value + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
