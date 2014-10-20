using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Salaries
{
    class Salaries
    {
        static HashSet<int> visited = new HashSet<int>();

        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());

            Dictionary<int, Node> employees = new Dictionary<int, Node>();

            for (int i = 0; i < C; i++)
            {
                if (!employees.ContainsKey(i))
                {
                    employees.Add(i, new Node(i));
                }

                var node = employees[i];

                string row = Console.ReadLine();
                for (int j = 0; j < C; j++)
                {
                    if (row[j] == 'Y')
                    {
                        if (!employees.ContainsKey(j))
                        {
                            employees.Add(j, new Node(j));
                        }

                        var worker = employees[j];

                        node.Nodes.Add(worker);
                    }
                }
            }

            for (int i = 0; i < C; i++)
            {
                Solve(employees[i]);
            }


            long result = 0;

            foreach (var employer in employees.Values)
            {
                result += employer.Salary;
            }

            Console.WriteLine(result);

        }

        private static void Solve(Node node)
        {
            if (visited.Contains(node.Id))
            {
                return;
            }

            visited.Add(node.Id);

            if (node.Nodes.Count == 0)
            {
                node.Salary = 1;
                return;
            }

            foreach (var item in node.Nodes)
            {
                Solve(item);
                node.Salary += item.Salary;
            }
        }
    }


    public class Node : IComparable
    {
        public int Id { get; set; }
        public long Salary { get; set; }
        public List<Node> Nodes;

        public Node(int id)
        {
            this.Nodes = new List<Node>();
            this.Id = id;
        }

        public int CompareTo(object obj)
        {
            return this.Id.CompareTo((obj as Node).Id);
        }
    }
}
