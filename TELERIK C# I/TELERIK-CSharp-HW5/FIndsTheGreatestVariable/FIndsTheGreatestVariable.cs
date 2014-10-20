using System;
class FIndsTheGreatestVariable
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double biggest = 0;
        if (a == b)
        {
            biggest = a;
        }
        else
        {
            if (a > b)
            {
                biggest = a;
            }
            else
            {
                biggest = b;
            }
        }
        if (biggest == c)
        {
            biggest = c;
        }
        else
        {
            if (biggest > c)
            {
                biggest = biggest;
            }
            else
            {
                biggest = c;
            }
        }
        if (biggest == d)
        {
            biggest = d;
        }
        else
        {
            if (biggest > d)
            {
                biggest = biggest;
            }
            else
            {
                biggest = d;
            }
        }

        if (biggest == e)
        {
            biggest = e;
        }
        else
        {
            if (biggest > e)
            {
                biggest = biggest;
            }
            else
            {
                biggest = e;
            }
        }
        Console.WriteLine("Biggest number is:{0}",biggest);
    }
}
