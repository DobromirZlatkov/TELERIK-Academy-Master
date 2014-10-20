using System;
using System.Collections.Generic;
namespace ColorBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> bunnieAnswers = new Dictionary<int, int>();
            int numberOfBunnies = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBunnies; i++)
            {
                int bunnieAnswer = int.Parse(Console.ReadLine());
                if (!bunnieAnswers.ContainsKey(bunnieAnswer))
                {
                    bunnieAnswers[bunnieAnswer] = 0;
                }

                bunnieAnswers[bunnieAnswer] += 1;
            }

            int bunnieCounter = 0;
            foreach (var item in bunnieAnswers)
            {
                int smth = item.Value;
                while (smth > 0)
                {
                    bunnieCounter += item.Key + 1;
                    smth -= item.Key + 1;
                }
            }

            Console.WriteLine(bunnieCounter);
        }
    }
}