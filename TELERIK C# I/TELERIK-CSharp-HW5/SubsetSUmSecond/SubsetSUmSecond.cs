using System;
class SubsetSUmSecond
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter 5 numbers:");
            int[] numbers = new int[5];
            int counter = 0;
            bool subset = false;
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 32; i++)
            {
                int sum = 10;
                for (int j = 0; j < 5; j++)
                {
                    sum += ((i >> j) & 1) * numbers[j];
                }
                if (sum == 10)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            //www.daniweb.com/software-development/csharp/threads/263416/subset-sum-task
        }       
    }
}
