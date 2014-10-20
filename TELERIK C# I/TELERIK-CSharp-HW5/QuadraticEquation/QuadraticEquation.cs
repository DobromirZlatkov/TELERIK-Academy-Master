using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter A:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter B:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter C:");
        int c = int.Parse(Console.ReadLine());

        double D = (b * b) - (4 * a * c);

        double x1 = 0;
        double x2 = 0;

        if (D > 0)
        {
            x1 = (-b + Math.Sqrt(D)) / (2*a);
            x2 = (-b - Math.Sqrt(D)) / (2*a);
            Console.WriteLine("There is two real roots: x1 = {0} and x2 = {1}",x1,x2);
        }
        else if (D == 0)
        {
            x1 = -b / (2 * a);
            x2 = x1;
            Console.WriteLine("THere is one real root: x1=x2={0}",x1);
        }
        else
        {
            Console.WriteLine("There are no real roots");
        }

        
    }
}
