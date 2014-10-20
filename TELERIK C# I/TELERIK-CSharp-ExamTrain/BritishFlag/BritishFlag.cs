using System;
class BritishFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dotsOutside = 0;
        int dotsIside = n / 2 - 1;
        string middle = new string('-', n / 2) + "*" + new string('-', n / 2);
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', dotsOutside));
            Console.Write("\\");
            Console.Write(new string('.', dotsIside));
            Console.Write("|");
            Console.Write(new string('.', dotsIside));
            Console.Write("/");
            Console.Write(new string('.', dotsOutside));
            Console.WriteLine();
            dotsOutside++;
            dotsIside--;
        }
        Console.WriteLine(middle);

        dotsOutside = n / 2 - 1;
        dotsIside = 0;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', dotsOutside));
            Console.Write("/");
            Console.Write(new string('.', dotsIside));
            Console.Write("|");
            Console.Write(new string('.', dotsIside));
            Console.Write("\\");
            Console.Write(new string('.', dotsOutside));
            Console.WriteLine();
            dotsOutside--;
            dotsIside++;
        }
    }
}
