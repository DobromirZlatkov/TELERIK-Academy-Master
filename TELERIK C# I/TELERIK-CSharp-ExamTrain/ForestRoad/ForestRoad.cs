using System;
class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mapHeight = 2 * n - 1;
        int dotsInside = 0;
        int dotsOutside = n - 1;
        for (int i = 0; i < mapHeight / 2 ; i++)
        {
            Console.Write(new string('.', dotsInside));
            Console.Write('*');
            Console.Write(new string('.', dotsOutside));
            Console.WriteLine();
            dotsInside++;
            dotsOutside--;
        }
        int dotsOutsideSecond = 0;
        int dotsInsideSecond = n - 1;
        for (int i = 0; i < mapHeight / 2 + 1; i++)
        {
            Console.Write(new string('.', dotsInside));
            Console.Write('*');
            Console.Write(new string('.', dotsOutside));
            Console.WriteLine();
            dotsInside--;
            dotsOutside++;
        }
    }
}
