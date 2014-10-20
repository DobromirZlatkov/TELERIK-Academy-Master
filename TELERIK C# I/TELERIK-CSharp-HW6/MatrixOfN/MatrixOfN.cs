using System;

class MatrixOfN
{
    static void Main()
    {
        Console.WriteLine("Enter N < 20:");
        
        int n = int.Parse(Console.ReadLine());
        if (n<20)
        {
            int counter = 0;
            int start = 1;
            int finish = n;
            for (int i = 1; i <= n; i++)
            {            
                counter++; 
                for (int j = start; j <= finish; j++)
                {
                    Console.Write("{0, 3}",j);
                }
                Console.WriteLine();
                start++;
                finish++;
            }
        }
        else
        {
            Console.WriteLine("N must be < 20:");
        }
        
    }
}
