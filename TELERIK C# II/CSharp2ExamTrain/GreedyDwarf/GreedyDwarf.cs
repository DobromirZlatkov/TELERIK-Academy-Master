using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        private static long ProccessPatter(int[] vally)
        {

            string[] rawNumbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[rawNumbers.Length];

            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(rawNumbers[i]);
            }
            bool[] visited = new bool[vally.Length];
            long coinSum = 0;
            coinSum += vally[0];
            visited[0] = true;
            int currentPossition = 0;
            while (true)
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    int nextMove = currentPossition + pattern[i];
                    if (nextMove >= 0
                        && nextMove < vally.Length 
                        && !visited[nextMove])
                    {
                        coinSum += vally[nextMove];
                        visited[nextMove] = true;
                        currentPossition = nextMove;
                    }
                    else
                    {
                        return coinSum;
                    }
                }
            }           
        }

        static void Main(string[] args)
        {
            string[] rawNumbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] validNubmers = new int[rawNumbers.Length];

            for (int i = 0; i < validNubmers.Length; i++)
            {
                validNubmers[i] = int.Parse(rawNumbers[i]);
            }


            int numberOfPatterns = int.Parse(Console.ReadLine());
            long bestSum = int.MaxValue;
            for (int i = 0; i < numberOfPatterns; i++)
            {
                long sum = (ProccessPatter(validNubmers));
                if (sum > bestSum)
                {
                    bestSum = sum;                  
                }
            }
        }
    }
}
