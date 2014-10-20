using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class ShortestPath
    {
        static void Main(string[] args)
        {
            int n = 2;
            int m = 31;
            Tuple<int, List<int>> element = new Tuple<int, List<int>>(n, new List<int>());
            Queue<Tuple<int, List<int>>> list = new Queue<Tuple<int, List<int>>>();

            list.Enqueue(element);

            while (true)
            {
                var current = list.Dequeue();
                List<int> currentPath = current.Item2.ToList();
                currentPath.Add(current.Item1);
                list.Enqueue(new Tuple<int, List<int>>(current.Item1 + 1, currentPath));
                list.Enqueue(new Tuple<int, List<int>>(current.Item1 + 2, currentPath));
                list.Enqueue(new Tuple<int, List<int>>(current.Item1 * 2, currentPath));

                if (current.Item1 == m)
                {
                    foreach (var item in current.Item2)
                    {
                        Console.Write(item + " -> ");
                    }
                    Console.WriteLine(current.Item1);
                    break;
                }
            }
        }
    }
}
