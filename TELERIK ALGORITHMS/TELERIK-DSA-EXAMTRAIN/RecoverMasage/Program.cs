using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace RecoverMasage
{
    class Node : IComparable
    {
        public char Letter { get; set; }

        public HashSet<Node> Parents = new HashSet<Node>();

        public HashSet<Node> Children = new HashSet<Node>();

        public override bool Equals(object obj)
        {
            var otherCell = obj as Node;
            if (otherCell == null)
            {
                return false;
            }

            return this.Letter == otherCell.Letter;
        }

        public override int GetHashCode()
        {
            return this.Letter.GetHashCode() ^ 13;
        }

        public int CompareTo(object obj)
        {
            var otherCell = obj as Node;

            if (Letter > otherCell.Letter)
            {
                return 1;
            }
            else if (Letter < otherCell.Letter)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static SortedDictionary<char, Node> graph = new SortedDictionary<char, Node>();

        static Node GetNodeByCharFromGraph(char a)
        {
            if (graph.ContainsKey(a))
            {
                return graph[a];
            }

            var newNode = new Node
            {
                Letter = a
            };
            graph[a] = newNode;
            return newNode;
        }

        static void Main(string[] args)
        {
     
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentLEtters = Console.ReadLine();
                var previousNode = GetNodeByCharFromGraph(currentLEtters[0]);

                for (int j = 1; j < currentLEtters.Length ; j++)
                {
                
                    Node currentNode = GetNodeByCharFromGraph(currentLEtters[j]);

                    previousNode.Children.Add(currentNode);
                    currentNode.Parents.Add(previousNode);

                    previousNode = currentNode;
                }
            }

            OrderedSet<Node> allGraphHeads = new OrderedSet<Node>();
            foreach (var node in graph)
            {
                if (node.Value.Parents.Count == 0)
                {
                    allGraphHeads.Add(node.Value);
                }
            }

            List<char> result = new List<char>();

            while (allGraphHeads.Count > 0)
            {
                var nodeN = allGraphHeads.First();
                allGraphHeads.Remove(nodeN);

                result.Add(nodeN.Letter);
                foreach (var childNode in nodeN.Children.ToList())
                {
                    childNode.Parents.Remove(nodeN);
                    nodeN.Children.Remove(childNode);

                    if (childNode.Parents.Count == 0)
                    {
                        allGraphHeads.Add(childNode);
                    }
                }
            }

            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
