using System;
class GetNumberN
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Number {0} = ", i);
            int numb = int.Parse(Console.ReadLine());
            sum = sum + numb;
        }
        Console.WriteLine(sum);
    }
}
