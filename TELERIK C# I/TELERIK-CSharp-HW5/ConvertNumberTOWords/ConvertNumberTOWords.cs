using System;
class ConvertNumberTOWords
{
    static void Main()
    {
        while (true)
        {

            Console.WriteLine("Enter number in range [0...999]:");
            int n = int.Parse(Console.ReadLine());

			 
			
            int firstDigit = n % 10;
            int secondDigit = (n / 10) % 10;
            int thirdDigit = (n / 100) % 10;

            switch (thirdDigit)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;               
            }


            if (thirdDigit > 0 && secondDigit == 1)
            {
                Console.Write(" and ");
            }

            switch (secondDigit)
            {
                case 1:
                    switch (firstDigit)
                    {
                        case 0:
                            Console.WriteLine("ten");
                            break;
                        case 1:
                            Console.WriteLine("eleven");
                            break;
                        case 2:
                            Console.WriteLine("twelve");
                            break;
                        case 3:
                            Console.WriteLine("thirteen");
                            break;
                        case 4:
                            Console.WriteLine("fourteen");
                            break;
                        case 5:
                            Console.WriteLine("fifteen");
                            break;
                        case 6:
                            Console.WriteLine("sixteen");
                            break;
                        case 7:
                            Console.WriteLine("seventeen");
                            break;
                        case 8:
                            Console.WriteLine("eighteen");
                            break;
                        case 9:
                            Console.WriteLine("nineteen");
                            break;
                    }
                    break;
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("fourty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninty ");
                    break;
            }
            if (thirdDigit > 0 && secondDigit == 0)
            {
                Console.Write(" and ");
            }

            if (secondDigit != 1)
            {
                switch (firstDigit)
                {
                    case 1:
                        Console.WriteLine("one ");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six ");
                        break;
                    case 7:
                        Console.WriteLine("seven ");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            }
            if (thirdDigit == 0 && secondDigit == 0)
            {
                switch (firstDigit)
                {
                    case 0:
                        Console.WriteLine("Zero ");
                        break;
                }
            }
        }       
    }
}
