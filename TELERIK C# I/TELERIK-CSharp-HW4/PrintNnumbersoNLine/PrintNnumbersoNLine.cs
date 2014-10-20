using System;
class PrintNnumbersoNLine
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
