using System;
class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dotsStart = n;
        int sand = 0;

        for (int i = 0; i < n/2 + 1; i++)
        {
            Console.Write(new string('.', sand));
            Console.Write(new string('*', dotsStart));
            Console.Write(new string('.', sand));
            dotsStart -= 2;
            sand++;
            Console.WriteLine();
        }
        int sand1 = sand - 2;
        int dotsStart1 = 3;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string('.', sand1));
            Console.Write(new string('*', dotsStart1));
            Console.Write(new string('.', sand1));
            dotsStart1 += 2;
            sand1--;
            Console.WriteLine();
        }
    }
}
