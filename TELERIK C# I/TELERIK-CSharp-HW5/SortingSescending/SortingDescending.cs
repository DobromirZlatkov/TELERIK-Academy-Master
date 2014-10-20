using System;
class SortingDescending
{
    static void Main()
    {
        Console.WriteLine("Enter 3 integers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a>b)
        {
            if (a>c)
            {
                if (b > c)
                {
                    Console.WriteLine("Descending order:{0}--{1}--{2}",a,b,c);
                }
                else
                {
                    Console.WriteLine("Descending order:{0}--{1}--{2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("Descending order:{0}--{1}--{2}", c,a,b);
            }
        }
        else
        {
            if (b >c)
            {
                if (a > c)
                {
                    Console.WriteLine("Descending order:{0}--{1}--{2}",b,a,c);
                }
                else
                {
                    Console.WriteLine("Descending order:{0}--{1}--{2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("Descending order:{0}--{1}--{2}", c, b, a);
            }
        }
        if ((b != c) && (b == a))
        {
            Console.WriteLine("The first and the second numbers are equal");
        }
        if ((b != a) && (c == a))
        {
            Console.WriteLine("The first and the third numbers are equal");
        }
        if ((c != a) && (c == b))
        {
            Console.WriteLine("The second and the third numbers are equal");
        }
        if ((a == b) && (c == b))
        {
            Console.WriteLine("Numbers area equal");
        }
    }
}