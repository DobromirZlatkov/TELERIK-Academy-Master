using System;
using System.Numerics;
class NandXAndCalculateSum
{
    static void Main()
    {
        Console.WriteLine("Enter N and K to see S = 1 + 1!/X + 2!/X2 + … + N!/XN");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());        
        double XN = 1;
        double S = 0;
        double factorielI = 1;
        for (int i = 0; i <= n; i++)
        {           
            if (i >= 1)
            {             
                for (int j = 0; j <= i; j++)
                {
                    factorielI *= i;
                }
            }
                        
            XN = Math.Pow(x, i);
            S += factorielI / XN;
            
            factorielI = 1;
        }
        Console.WriteLine("S = 1 + 1!/X + 2!/X2 + … + N!/XN = {0}",S);
    }
}
