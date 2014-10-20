using System;
class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string firstLine = new string('.', n);
        string firstLine2 = new string('*', n);
        string lastLine = new string('*', 2 * n);

        Console.WriteLine(firstLine + firstLine2);

        int dotsOutside = n - 1;
        int dotsInside = n - 1;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', dotsOutside));
            Console.Write("*");
            Console.Write(new string('.', dotsInside));
            Console.Write("*");
            Console.WriteLine();
            dotsInside++;
            dotsOutside--;
        }

        Console.WriteLine(lastLine);
    }
}

