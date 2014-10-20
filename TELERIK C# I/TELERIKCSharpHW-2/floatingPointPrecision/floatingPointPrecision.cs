using System;
class floatingPointPrecision
{
    static void Main()
    {
        while (true)
        {
            
            Console.WriteLine("Enter first number:");
            double numberOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double numberTwo = double.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine("{0} is bigger", numberOne);
            }
            else
            {
                Console.WriteLine("{0} is bigger", numberTwo);
            }
        }
    }
}
