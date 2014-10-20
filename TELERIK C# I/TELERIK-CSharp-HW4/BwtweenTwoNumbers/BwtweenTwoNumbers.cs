using System;
class BwtweenTwoNumbers
{
    static void Main()
    {
        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int isDevidedBy5 = 0;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                isDevidedBy5++;
            }
        }
        Console.WriteLine(isDevidedBy5);
    }
}
