using System;
class TelerikLogo
{
    static void Main()
    {

        int X = int.Parse(Console.ReadLine());

        int width = (X + X) + ((X / 2) + 1) + ((X / 2) + 1) - 3;
        int hornsLenght = X / 2;
        int middleDots = width - 2 * (X / 2 + 1);

        Console.Write(new string('.', hornsLenght));
        Console.Write("*");
        Console.Write(new string('.', middleDots));
        Console.Write("*");
        Console.Write(new string('.', hornsLenght));
        Console.WriteLine();
        middleDots -= 2;

        int firstHornDots = X / 2 - 1;
        int dotsAfterGorn = 0;
        for (int i = 1; i < X - 1; i++)
        {
            if (i <= X / 2)
            {
                Console.Write(new string('.', firstHornDots));
                Console.Write("*");
                Console.Write(new string('.', dotsAfterGorn));
               
            }
            else
            {
                Console.Write(new string('.', hornsLenght));
            }
            
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', i));
            middleDots -= 2;
            if (i <= X / 2)
            {
                Console.Write(new string('.', dotsAfterGorn));               
                Console.Write("*");
                Console.Write(new string('.', firstHornDots));
                firstHornDots--;
                dotsAfterGorn++;
            }
            else
            {
                Console.Write(new string('.', hornsLenght));
            }
            Console.WriteLine();
        }
        Console.WriteLine(new string('.', width / 2) + "*" + new string('.', width / 2));
        int leftRightDOts = X - 2;
        middleDots = 1;
        for (int i = 0; i < X-1; i++)
        {
            Console.Write(new string('.',hornsLenght));
            Console.Write(new string('.', leftRightDOts));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', leftRightDOts));
            Console.Write(new string('.', hornsLenght));
            middleDots += 2;
            leftRightDOts--;          
            Console.WriteLine();
        }
        middleDots -= 4;
        for (int i = 1; i < X-1; i++)
        {
           
            Console.Write(new string('.',hornsLenght));
            Console.Write(new string('.', i));
            Console.Write("*");
           
            Console.Write(new string('.', middleDots));            
            Console.Write("*");
            Console.Write(new string('.', i));
            Console.Write(new string('.', hornsLenght));
            middleDots -= 2;        
            Console.WriteLine();
        }
        Console.WriteLine(new string('.', width / 2) + "*" + new string('.', width / 2));
    }
}
