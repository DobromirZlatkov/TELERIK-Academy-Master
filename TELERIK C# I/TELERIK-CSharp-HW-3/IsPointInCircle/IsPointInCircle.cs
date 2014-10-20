using System;
class IsPointInCircle
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            int y = int.Parse(Console.ReadLine());

            int circleCenter = 0;
            int circleRadius = 5;

            int isInCircle = (x * x) + (y * y);

            if (isInCircle < (circleRadius * circleRadius))
            {
                Console.WriteLine("The point is inside the circle.");
            }
            else
            {
                Console.WriteLine("The point is outside the circle.");
            }  
        }
        
    }
}
