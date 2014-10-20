using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapSackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> allPossibleProducts = new List<Product>();
            allPossibleProducts.Add(new Product("beer", 3, 2));
            allPossibleProducts.Add(new Product("vodka", 8, 12));
            allPossibleProducts.Add(new Product("cheese", 4, 5));
            allPossibleProducts.Add(new Product("nuts", 1, 4));
            allPossibleProducts.Add(new Product("ham", 2, 3));
            allPossibleProducts.Add(new Product("testo", 2, 3));
            allPossibleProducts.Add(new Product("whiskey", 8, 13));

            int M = 10;

            SolveKnapsackProblemNoDuplicatesAllowed(allPossibleProducts, M);

        }

        private static void SolveKnapsackProblemNoDuplicatesAllowed(/*int[] costs, int[] weigth*/List<Product> allPossibleProducts, int bagCapacity)
        {
            // Assume the array V[i] 
            // contains the values of the items
            // Assume the array S[i] 
            // contains the sizes of the items

            int costsCout = allPossibleProducts.Count;

            bool[,] used = new bool[bagCapacity + 1, costsCout];
            int[] M = new int[bagCapacity + 1];

            // Trivial case when (j=0) 
            // the value we get is also zero
            M[0] = 0;

            // For each slot (j) in the knapsack do
            for (int j = 1; j <= bagCapacity; j++)
            {
                // M[j] will be max1 (or M[j-1]) 
                // if the jth slot is empty
                int max1 = M[j - 1];

                // M[j] will be max2 if the jth 
                // slot is occupied by some item
                // Initialize max2 to some small number
                int max2 = -999999;

                // This is used to mark the previous (j) 
                // slot if the jth slot is occupied
                int mark = 0;

                // This is used to keep the index
                // of the last candidate which can be put
                // in the knapsack
                int candidateUsed = 0;

                // Search for an item to occupy the jth 
                // slot such that it gives us maximum value
                for (int i = 0; i < costsCout; i++)
                {
                    // For each item (i) calculate (V[i] + M[j - S[i]]) 
                    // then compare it to the current max. If it is greater 
                    // then update the current max. Only those items satisfying 
                    // the condition (j - S[i] >= 0) are checked because capacity 
                    // should not be negative
                    if (j - allPossibleProducts[i].Weigth >= 0 && !used[j - allPossibleProducts[i].Weigth, i] && allPossibleProducts[i].Cost + M[j - allPossibleProducts[i].Weigth] > max2)
                    {
                        // Update the max
                        max2 = allPossibleProducts[i].Cost + M[j - allPossibleProducts[i].Weigth];
                        // Save the previous (j) position 
                        // that gives us the maximum value
                        mark = j - allPossibleProducts[i].Weigth;
                        // Update the candidate item which
                        // might be put in the knapsack
                        candidateUsed = i;
                    }
                }

                //Case1: jth slot is empty
                if (max1 > max2)
                {
                    M[j] = max1;

                    for (int k = 0; k < costsCout; k++)
                    {
                        used[j, k] = used[j - 1, k];
                    }
                }
                //Case 2: jth slot is occupied
                else
                {
                    M[j] = max2;

                    for (int k = 0; k < costsCout; k++)
                    {
                        used[j, k] = used[mark, k];
                    }

                    // mark the candidate as used, which will prevent us
                    // from putting it again in the knapsack
                    used[j, candidateUsed] = true;
                }
            }

            Console.WriteLine(
                "The maximum value we can get by filling\r\n" +
                "the knapsack with capacity {0} is {1}.",
                bagCapacity,
                M[bagCapacity]);

            for (int i = 0; i < costsCout; i++)
            {
                if (used[bagCapacity, i])
                {
                    Console.WriteLine("Product: {2} Size: {0}, Value: {1}", allPossibleProducts[i].Weigth, allPossibleProducts[i].Cost, allPossibleProducts[i].Name);
                }
            }
        }

    }
}
