using System;
class SubsetSUm
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter 5 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if (a + b == 0)
            {
                Console.WriteLine(true);
            }
            else if (a + c == 0)
            {
                Console.WriteLine(true);
            }
            else if (a + d == 0)
            {
                Console.WriteLine(true);
            }
            else if (a + e == 0)
            {
                Console.WriteLine(true);
            }
            else if (a + b + c == 0)
            {
                Console.WriteLine(true);
            }
            else if (a + d + e == 0)
            {
                Console.WriteLine(true);
            }
            else if (a + b + e == 0)
            {
                Console.WriteLine(true);
            }
            else if (a + c + e == 0)
            {
                Console.WriteLine(true);
            }
                
            else if (a + b + c + d == 0)
            {
                Console.WriteLine(true);
            }
            else if (a + b + c + d + e == 0)
            {
                Console.WriteLine(true);
            }
            else if (b + c + d + e == 0)
            {
                Console.WriteLine(true);
            }
            else if (b + c + d == 0)
            {
                Console.WriteLine(true);
            }
            else if (b + c + e == 0)
            {
                Console.WriteLine(true);
            }
            else if (b + c == 0)
            {
                Console.WriteLine(true);
            }
            else if (c + d + e == 0)
            {
                Console.WriteLine(true);
            }
            else if (c + d == 0)
            {
                Console.WriteLine(true);
            }
            else if (d + b == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}

    