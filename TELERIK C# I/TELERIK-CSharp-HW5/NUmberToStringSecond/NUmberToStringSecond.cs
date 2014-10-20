using System;
class NUmberToStringSecond
{
    static void Main()
    {
        while (true)
	    {	         
            int n = int.Parse(Console.ReadLine());
                           
            int firstDigit = n % 10;
            int secondDigit = (n / 10) % 10;
            int thirdDigit = (n / 100) % 10;

       
            string[] firstDigits = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] eleven = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };
            string[] secondDigits = new string[] { "twenty ", "thirty ", "fourty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninty " };

            if (thirdDigit > 0)
            {
                Console.Write(firstDigits[thirdDigit]);
                Console.Write(" hundred ");
            }
            if (thirdDigit > 0)
            {
                if ((secondDigit == 0) || (secondDigit == 1))
                {
                    Console.Write("and ");
                }
            }
            
            if (secondDigit == 1)
            {
                Console.WriteLine(eleven[firstDigit]);
            }
            if (secondDigit != 1 && secondDigit > 0)
            {
                Console.Write(secondDigits[secondDigit - 2]);
            
            }
            if (secondDigit != 1)
            {
                if (secondDigit > 0 && firstDigit == 0)
                {
                    firstDigits[firstDigit] = " ";
                }
                Console.WriteLine(firstDigits[firstDigit]);
            }
            
        }
    }
}
