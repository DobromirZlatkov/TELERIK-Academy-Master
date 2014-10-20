using System;
class QuanticEquation
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int b = int.Parse(Console.ReadLine());

        int c = int.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4.0 * a * c);

        if (discriminant < 0)
        {
            Console.WriteLine("Equation doesn't have real roots.");
        }
        else if (discriminant == 0 )
        {
            double x = (-b) / (2 * a);
            Console.WriteLine("Equation has only one real root: {0}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Equation has two real roots X1:{0} and X2:{1}", x1, x2);
        }
        // www.rapidtables.com/math/algebra/Quadratic_equation.htm
    }
}
