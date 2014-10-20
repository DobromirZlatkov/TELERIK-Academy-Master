using System;
class UnicodeOF72
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            string hexVaue = number.ToString("X");
            char result2 = (char)number;
            char result = '\u0048';
            Console.WriteLine("Unicode of the number:{0}",result2);
            Console.WriteLine("Unicode of 72:{0}",result);
        }
    }
}
