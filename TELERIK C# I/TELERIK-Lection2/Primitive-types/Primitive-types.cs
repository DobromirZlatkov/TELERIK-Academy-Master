using System;
class Primitiv
{
    static void Main()
    {
        byte centuries = 20;
        ushort years = 2000;
        uint days = 234238749;
        ulong hours = 8490230413042;

        Console.WriteLine("{0} centuries, {1} years, {2} days, {3} hours",
            centuries,years,days,hours);


        // zapazvane na apostrofff
        
        char symbol = 'a';
        Console.WriteLine("the code of {0} is {1}",symbol, (int)symbol);

    }
}

