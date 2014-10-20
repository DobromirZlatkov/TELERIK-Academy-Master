using System;
class Program
{
    static void Main()
    {
        while (true)
        {            
            Console.WriteLine("Entter number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit possition:");
            int bitPossition = int.Parse(Console.ReadLine());
            int bit = (n >> bitPossition) & 1;
            bool result = bit != 0;
            Console.WriteLine(result);
        }
    }
}
