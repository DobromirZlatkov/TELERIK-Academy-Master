using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldMethod
{
    class HelloWorldMethod
    {
        static void Main()
        {
            /*Write a method that asks the user for his name and 
             * prints “Hello, <name>” (for example, “Hello, Peter!”).
             * Write a program to test this method.
            */
            Console.WriteLine("Enter your name:");
            Console.WriteLine(printName(Console.ReadLine()));
        }
        public static string printName(string name)
        {
            bool isNameValid = true;
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name,i))
                {
                    isNameValid = false;
                }
            }
            if (isNameValid)
            {
                return "Hello " + name + "!";
            }
            else
            {
                return "Invalid input.";
            }
        }        
    }
}
