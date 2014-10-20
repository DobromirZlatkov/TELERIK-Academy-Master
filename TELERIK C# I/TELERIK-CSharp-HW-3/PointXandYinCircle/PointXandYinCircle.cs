using System;
class PointXandYinCircle
{
    static void Main()
    {
        while (true)
        {
         
            Console.WriteLine("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y: ");
            int y = int.Parse(Console.ReadLine());

            int CenterX = 1;
            int CenterY = 1;
       
            int isInCircle = ((x - CenterX) * (x - CenterX)) +
                ((y - CenterY) * (y - CenterY));
            //check if the point is in the circle
            if (isInCircle < 9)
            {
                Console.WriteLine("Point is in the circle.");
                //check if point is in rectangle
                if (((x < -1) || (x > 5)))
                {
                    Console.WriteLine("Point is outside the rectangle");
                }
                else if (((y > 1) || (y < -1)))
                {
                    Console.WriteLine("Point is outside the rectangle");
                }
                else if (((x > -1) || (x < 5)) && ((y < 1) || (y > -1)))
                {
                    Console.WriteLine("Point is in the rectangle");
                }

            }
            else
            {
                Console.WriteLine("Point is outside the circle.");
            }
            //check if point is in rectangle and outside circle
            if (((x < -1) || (x > 5)))
            {
                Console.WriteLine("Point is outside the rectangle");
            }
            else if (((y > 1) || (y < -1)))
            {
                Console.WriteLine("Point is outside the rectangle");
            }
            else if (((x > -1) || (x < 5)) && ((y < 1) || (y > -1)))
            {
                Console.WriteLine("Point is in the rectangle");
            }   
        }
      
    }
}
