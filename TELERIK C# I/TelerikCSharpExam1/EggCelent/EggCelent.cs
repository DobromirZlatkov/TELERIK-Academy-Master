using System;
class EggCelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int eggHeight = 2 * n;
        int eggWidth = 3 * n - 3;
        int eggDrawnArea = 3 * n + 1;
        int eggSizeTop = n - 2;

        string top = new string('.', n + 1) + new string('*', n - 1) + new string('.', n + 1);
        char start = '.';

        int dotsoutside = n - 2;
        int couter = 0;

        Console.WriteLine(top);
        int temp = eggWidth;

        //print top
        for (int i = 0; i < eggSizeTop ; i++)
        {
            int dotsInside = eggWidth - (dotsoutside + dotsoutside);
            Console.Write(".");
          
            Console.Write(new string('.', dotsoutside));
            Console.Write("*");
            Console.Write(new string('.', dotsInside));

            Console.Write("*");
            Console.Write(new string('.', dotsoutside));





            Console.Write(".");
            Console.WriteLine();
            dotsoutside -= 2;
            if (dotsoutside < 0)
            {
                couter++;
                dotsoutside = 0;
            }
        }


        /// middle
        /// 
        int eggGuts = eggWidth - 1;
        int eggguts2 = eggWidth - 1;
        char stars = '@';
        for (int i = 0; i < 2; i++)
        {
            Console.Write(".");
            Console.Write("*");
            if (i == 0)
            {
                while (eggGuts >=0)
                {

                    if (eggGuts % 2 == 0)
                    {
                        stars = '@';
                    }
                    else
                    {
                        stars = '.';
                    }
                    Console.Write(stars);
                    eggGuts--;
                }
            }
            else
            {
                while (eggguts2 >= 0)
                {

                    if (eggguts2 % 2 == 0)
                    {
                        stars = '.';
                    }
                    else
                    {
                        stars = '@';
                    }
                    Console.Write(stars);
                    eggguts2--;
                }
            }

            Console.Write("*");
            Console.Write(".");
            Console.WriteLine();
        }
        //bottom
        int dotsInsideBottom = eggWidth;
        int dotsOutsideBottom = 0;
        for (int i = 0; i < eggSizeTop; i++)
        {
            Console.Write(".");
            Console.Write(new string('.',dotsOutsideBottom));
            Console.Write("*");

            Console.Write(new string('.', dotsInsideBottom));
            couter--;
           


            Console.Write("*");
            Console.Write(new string('.', dotsOutsideBottom));
            Console.Write(".");

            if (couter <= 0)
            {
                dotsInsideBottom -= 4;
                dotsOutsideBottom += 2;
            }
            Console.WriteLine();
        }

        Console.WriteLine(top);
    }
}
