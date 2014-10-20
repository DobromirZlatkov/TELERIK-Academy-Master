using System;
class trapezoidArea
{
    static void Main()
    {
        Console.Write("Enter side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter height H: ");
        double heightH = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) / 2) * heightH;
        Console.WriteLine("Area is :{0}",area);
    }
}
