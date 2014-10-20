using System;
class DeclareTwoIntegerVariables
{
    static void Main()
    {
       
        int firstVariable = 5;
        Console.WriteLine("First variable:{0}",firstVariable);
        int secondVariable = 10;
        Console.WriteLine("Second variable:{0}", secondVariable);

        int middle = firstVariable;
        firstVariable = secondVariable;
        secondVariable = middle;

        Console.WriteLine("First variable after exchange:{0}", firstVariable);
        Console.WriteLine("Second variable after exchange:{0}", secondVariable);
    }
}
