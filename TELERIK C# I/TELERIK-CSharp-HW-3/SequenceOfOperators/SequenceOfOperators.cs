using System;
class SequenceOfOperators
{
    static void Main()
    {
        while (true)
        {
                Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter value 1 or 0: ");
            int value = int.Parse(Console.ReadLine());

            Console.Write("Enter possition: ");
            int possition = int.Parse(Console.ReadLine());

            if (value == 0)
            {
                int mask = ~(1 << possition);
                int result = n & mask;
                Console.WriteLine(result);
            }
            else if (value == 1)
            {
                int mask = 1 << possition;
                int result = n | mask;
                Console.WriteLine(result);
            } 
        }

    }
}
