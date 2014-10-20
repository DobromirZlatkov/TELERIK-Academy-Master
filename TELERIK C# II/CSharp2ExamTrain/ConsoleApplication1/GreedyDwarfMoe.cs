using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputValues = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int m = int.Parse(Console.ReadLine());

            List<string[]> list = new List<string[]>();

            for (int i = 0; i < m; i++)
            {
                string[] papaz = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                list.Add(papaz);
            }

            long counter = 0;
            int ii = 0;
            int jj = 0;
            long result = long.MinValue;
            
            for (int k = 0; k < list.Count; k++)
            {
                bool[] isVisited = new bool[inputValues.Length];
                // ii = int.Parse(list[k][0]);
                while (isVisited[ii] != true)
                {
                    counter += int.Parse(inputValues[ii]);
                    isVisited[ii] = true;

                    int patternLenght = list[k].Length;
                    ii += int.Parse(list[k][jj]);
                    if (ii >= inputValues.Length || ii < 0)
                    {
                        break;
                    }
                    if (patternLenght - 1 == jj)
                    {
                        jj = 0;
                    }
                    else
                    {
                        jj++;
                    }
                }
                jj = 0;
                ii = 0;
                if (counter > result)
                {
                    result = counter;
                }
                counter = 0;                
            }
            Console.WriteLine(result);
        }
    }
}