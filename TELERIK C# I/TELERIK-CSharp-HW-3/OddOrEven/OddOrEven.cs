using System;
class OddOrEven
{
    static void Main()
    {
        while (true)
         {
            Console.WriteLine(new string('-',40));
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is EVEN");
            }
            else
            {
                Console.WriteLine("Number is ODD");
            }
            // bit solution
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            
            if (n == (n | 1))
            {
                Console.WriteLine("Number is ODD");
               
            }
            else
            {
                Console.WriteLine("Number is EVEN");
            }
        }        
    }
}
