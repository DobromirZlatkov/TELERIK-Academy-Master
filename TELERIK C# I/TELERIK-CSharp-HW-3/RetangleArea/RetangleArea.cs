using System;
class RetangleArea
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter rectangle width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter rectangle height: ");
            int height = int.Parse(Console.ReadLine());

            int area = width * height;

            Console.WriteLine("Rectangle area is: {0}",area);
            Console.WriteLine(new string('-', 40));
        }
    }
}
