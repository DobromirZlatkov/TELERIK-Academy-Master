using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberItsSquareRoots
{
    class PrintNumberItsSquareRoots
    {
        /*Write a program that reads an integer number and calculates
         * and prints its square root. If the number is invalid or
         * negative, print "Invalid number". In all cases finally 
         * print "Good bye". Use try-catch-finally.
        */
        static void Main(string[] args)
        {
            try
            {
                uint n = uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(n));
            }

            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
