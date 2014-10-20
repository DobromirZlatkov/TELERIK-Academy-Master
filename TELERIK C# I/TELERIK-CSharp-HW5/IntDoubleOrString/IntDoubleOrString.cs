using System;
class IntDoubleOrString
{
    static void Main()
    {
        Console.Write("Write variable you want to use (int , double or string)");
        string variable = Console.ReadLine();
        switch (variable)
        {
            case "int":
                Console.WriteLine("Enter integer");
                int intVariable = int.Parse(Console.ReadLine());
                Console.WriteLine(intVariable + 1);
                break;
            case "double":
                Console.WriteLine("Enter double");
                double doubleVariable = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleVariable + 1);
                break;
            case "string":
                Console.WriteLine("Enter string");
                string stringVariable = Console.ReadLine();
                Console.WriteLine(stringVariable + "*");
                break;
            default:
                Console.WriteLine("Unknown variable");
                break;
        }
    }
}
