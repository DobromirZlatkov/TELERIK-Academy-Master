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
            int mask = 1 << bitPossition;

            int nAndMask = n & mask;
            int bit = nAndMask >> bitPossition;

           // int bit = (n >> bitPossition) & 1;            
            Console.WriteLine(bit);
        }
    }
}
