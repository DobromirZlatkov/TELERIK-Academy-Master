using System;
class AsignNullValues
{
    static void Main()
    {
        int? nullNumber = null;
        double? nullDouble = null;
        Console.WriteLine(nullNumber);
        Console.WriteLine(nullDouble);
        Console.WriteLine(new string('-', 40));
        nullNumber = 10;       
        nullDouble = 11.11;
        Console.WriteLine(nullNumber);
        Console.WriteLine(nullDouble);
        
    }
}
