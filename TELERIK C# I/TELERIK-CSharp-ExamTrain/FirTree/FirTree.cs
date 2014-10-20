using System;
class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotsOutside = n - 2;
        string lastLine = new string('.', dotsOutside) + "*" + new string('.', dotsOutside);
        int starsInside = 1;
        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string('.', dotsOutside));
            Console.Write(new string('*', starsInside));
            Console.Write(new string('.', dotsOutside));
            Console.WriteLine();
            starsInside += 2;
            dotsOutside--;

        }
        Console.WriteLine(lastLine);
    }
}
