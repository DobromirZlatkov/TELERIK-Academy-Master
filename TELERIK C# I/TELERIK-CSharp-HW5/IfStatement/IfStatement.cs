using System;
class IfStatement
{
    static void Main()
    {
        Console.Write("First number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            int temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
            Console.WriteLine("First number is greather than second. Their values will be exchanged.");
        }
        Console.WriteLine("First number:{0}", firstNumber);
        Console.WriteLine("Second number:{0}", secondNumber);
    }
}
