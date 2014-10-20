using System;
class FirThree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dotsOutside = n / 2 - 1;
        int dotsInside = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', dotsOutside));
            Console.Write("#");
            Console.Write(new string('.', dotsInside));

            Console.Write("#");
            Console.Write(new string('.', dotsOutside));
            Console.WriteLine();
            dotsInside += 2;
            dotsOutside--;
        }
        int secondHalfLenght = n / 4;
        dotsOutside = 0;
        dotsInside = n - 2;
        for (int i = 0; i < secondHalfLenght; i++)
        {
            Console.Write(new string('.', dotsOutside));
            Console.Write("#");
            Console.Write(new string('.', dotsInside));
            Console.Write("#");
            Console.Write(new string('.', dotsOutside));
            Console.WriteLine();
            dotsInside -= 2;
            dotsOutside++;
        }

        Console.WriteLine(new string('-', n));

        dotsOutside = 0;
        int lines1sttHalf = n / 2;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string('.', dotsOutside));
            Console.Write(new string('\\', lines1sttHalf));
            Console.Write(new string('/', lines1sttHalf));
            Console.Write(new string('.', dotsOutside));
            dotsOutside++;
            lines1sttHalf--;
            Console.WriteLine();
        }
    }
}
