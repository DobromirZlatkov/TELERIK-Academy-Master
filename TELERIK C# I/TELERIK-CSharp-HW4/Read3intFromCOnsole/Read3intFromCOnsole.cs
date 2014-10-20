using System;
class Read3intFromCOnsole
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        int sum = firstNum + secondNum + thirdNum;

        Console.WriteLine("Ther sum is : {0}",sum);
    }
}
