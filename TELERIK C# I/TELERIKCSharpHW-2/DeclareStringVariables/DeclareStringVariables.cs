using System;
class DeclareStringVariables
{
    static void Main()
    {
        string firstVariable = "Hello";
        string secondVariable = "World";
        object helloWorld = firstVariable + ' ' + secondVariable;
       // Console.WriteLine(helloWorld);
        string rezult = (string)helloWorld;
        Console.WriteLine(rezult);

    }
}

