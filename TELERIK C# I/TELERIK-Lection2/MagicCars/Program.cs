using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<int> Papazi = new List<int>();

            Papazi.Add(10);
            Papazi.Add(20);
            Papazi.Add(30);
            Papazi.Add(50);
            Papazi.Add(80);
            Papazi.Add(110);
            Papazi.Add(130);
            Papazi.Add(160);
            Papazi.Add(200);
            Papazi.Add(240);

            int counter = 0;
            int currentNum = 40;

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        for (int z = 0; z <= 9; z++)
                        {
                            foreach (var item in Papazi)
                            {
                                foreach (var secondItem in Papazi)
                                {
                                    currentNum += (i + j + k + z + item + secondItem);
                                    if (currentNum == n)
                                    {
                                        if (i == j && i == k && i == z)
                                        {
                                            counter++;
                                        }
                                        else if (i != j && j == k && k == z)
                                        {
                                            counter++;
                                        }
                                        else if (i == j && i == k && i != z)
                                        {
                                            counter++;
                                        }
                                        else if (i == j && j != k && k == z)
                                        {
                                            counter++;
                                        }
                                        else if (i == k && j == z && i != j)
                                        {
                                            counter++;
                                        }
                                        else if (i == z && j == k && i != j)
                                        {
                                            counter++;
                                        }
                                        
                                    }
                                    currentNum = 40;
                                    
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
