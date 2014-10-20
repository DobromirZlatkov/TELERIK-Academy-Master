using System;
class BatGoikoTower
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotsOutside = n - 1;
        char lines = '-';
        int lineStart = 2;
        int temp = -2;
        int linesOrder = -2;
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', dotsOutside) + "/");
          
            if (lines == '-')
            {
                linesOrder = temp;
                linesOrder++;
                temp = linesOrder;              
            }
            if (linesOrder > 0)
            {
                lines = '.';
                linesOrder--;
            }
            else
            {
                lines = '-';
            }
            if (i > 0)
            {
                Console.Write(new string(lines, lineStart));
                lineStart += 2;
                
            }
            
          
          

            Console.Write("\\" + new string('.', dotsOutside));
            Console.WriteLine();
            dotsOutside--;
            
        }

    }
}
