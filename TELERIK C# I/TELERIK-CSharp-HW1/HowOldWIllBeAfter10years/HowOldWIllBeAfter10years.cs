using System;
class HowOldWIllBeAfter10years
{
    static void Main()
    {
        Console.Write("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        int after = age + 10;
        Console.WriteLine("After 10 years you will be:{0} years old", after);
    }
}
