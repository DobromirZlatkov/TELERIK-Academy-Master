using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_SoftUNI
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            bool answerFOund = false;
            for (int a = 5; a < 10; a++)
            {
                for (int b = 5; b < 10; b++)
                {
                    for (int c = 5; c < 10; c++)
                    {
                        string firstNumber = a.ToString() + b.ToString() + c.ToString();
                        if (a + b + c > sum)
                        {
                            continue;
                        }
                        for (int d = 5; d < 10; d++)
                        {         
                            for (int e = 5; e < 10; e++)
                            {
                                for (int f = 5; f < 10; f++)
                                {  
                                    string secondNumber = d.ToString() + e.ToString() + f.ToString();
                                    if (long.Parse(secondNumber) - long.Parse(firstNumber) != diff || ((a + b + c + d + e + f) > sum))
                                    {
                                        continue;
                                    }
                                    for (int g = 5; g < 10; g++)
                                    {
                                        for (int h = 5; h < 10; h++)
                                        {
                                           
                                            for (int i = 5; i < 10; i++)
                                            {
                                                int currenTsum = a + b + c + d + e + f + g + h + i;
                                                                           
                                                string thirdNumber = g.ToString() + h.ToString() + i.ToString();
                                               
                                                if (int.Parse(thirdNumber) - int.Parse(secondNumber) == diff)
                                                {
                                                    if (currenTsum == sum)
                                                    {
                                                        result.Append(a.ToString());
                                                        result.Append(b.ToString());
                                                        result.Append(c.ToString());
                                                        result.Append(d.ToString());
                                                        result.Append(e.ToString());
                                                        result.Append(f.ToString());
                                                        result.Append(g.ToString());
                                                        result.Append(h.ToString());
                                                        result.Append(i.ToString());
                                                        Console.WriteLine(long.Parse(result.ToString()));
                                                        result.Clear();
                                                        answerFOund = true;
                                                    }
                                                }   
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!answerFOund)
            {
                Console.WriteLine("No");
            }
        }
    }
}
