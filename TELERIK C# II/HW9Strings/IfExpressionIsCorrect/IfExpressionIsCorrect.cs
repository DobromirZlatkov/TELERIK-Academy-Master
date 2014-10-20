using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfExpressionIsCorrect
{
    class IfExpressionIsCorrect
    {
        /*Write a program to check if in a given expression the brackets
         * are put correctly.
        Example of correct expression: ((a+b)/5-d).
        Example of incorrect expression: )(a+b)).
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression with brackets like :((a+b)/5-d)");
            string expression = Console.ReadLine();
            IsExpressionCOrrect(expression);
           
        }

        private static void IsExpressionCOrrect(string expression)
        {
            char[] expressionAsChars = expression.ToCharArray();
            int brackets = 0;
            for (int i = 0; i < expressionAsChars.Length; i++)
            {
                if (expressionAsChars[i] == '(')
                {
                    brackets++;
                }
                else if (expressionAsChars[i] == ')')
                {
                    brackets--;
                }
                if (brackets < 0)
                {
                    Console.WriteLine("Incorrect expression");
                    return;
                }
            }
            if (brackets == 0)
            {
                Console.WriteLine("Correct expression.");
            }
            else
            {
                Console.WriteLine("Incorrect expression");
            }
        }
    }
}
