using System;
class GetTheBiggerNumber
{
    static void Main()
    {
        Console.Write("First number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Second number:");
        int secondNum = int.Parse(Console.ReadLine());

        int result = firstNum >= secondNum ? firstNum : secondNum;
        Console.WriteLine(result);
    }
}
