using System;
class PerimeterAndAreaOFCircle
{
    static void Main()
    {
        Console.Write("Enter radius of circle:");
        double radius = double.Parse(Console.ReadLine());
        double PI = Math.PI;

        double area = PI * (radius * radius);
        double perimeter = 2 * PI * radius;

        Console.WriteLine("Circle area is: {0}", area);
        Console.WriteLine("Circle peremeter is: {0}", perimeter);
    }
}
