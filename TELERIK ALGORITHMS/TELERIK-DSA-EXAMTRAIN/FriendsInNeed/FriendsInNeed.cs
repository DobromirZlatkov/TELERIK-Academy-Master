using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsInNeed
{
    class Node : IComparable
    {
        public Node(int id)
        {
            this.Id = id;
        }

        public long DjikstraDistance = long.MaxValue;
        public int Id { get; set; }
        public List<Connection> Connections = new List<Connection>();
        public bool IsHospital = false;

        public int CompareTo(object obj)
        {
            var papaz = obj as Node;
            return this.DjikstraDistance.CompareTo(papaz.DjikstraDistance);
        }
    }

    class Connection
    {
        public Node Node { get; set; }
        public long Distance { get; set; }
        public Connection(Node node, long distance)
        {
            this.Node = node;
            this.Distance = distance;
        }
    }

    class FriendsInNeed
    {
        static void Main(string[] args)
        {
            Dictionary<int, Node> graph = new Dictionary<int, Node>();
           

            string firstRow = Console.ReadLine();
            string[] firstRowAsArr = firstRow.Split(' ');
            int numberOfPoints = int.Parse(firstRowAsArr[0]);
            int numberOfStreets = int.Parse(firstRowAsArr[1]);
            int numberOfHospitals = int.Parse(firstRowAsArr[2]);

            string seccondLine = Console.ReadLine();
            string[] seccondRowAsArr = seccondLine.Split(' ');

            //add all hospitals
            for (int i = 0; i < numberOfHospitals; i++)
            {
                int hospitalId = int.Parse(seccondRowAsArr[i]);
                var hospital = new Node(hospitalId);
                hospital.IsHospital = true;
                graph.Add(hospitalId, hospital);

            }
           // add all houses
            for (int i = 1; i <= numberOfPoints; i++)
            {
                if (!graph.ContainsKey(i))
                {
                    graph.Add(i, new Node(i));
                }
            }
          
            for (int i = 0; i < numberOfStreets; i++)
            {
                string connection = Console.ReadLine();
                var connectionAsArr = connection.Split(' ');
                var firstBuildingId = int.Parse(connectionAsArr[0]);
                var secondBuildingId = int.Parse(connectionAsArr[1]);
                var distance = int.Parse(connectionAsArr[2]);

                graph[firstBuildingId].Connections.Add(new Connection(graph[secondBuildingId], distance));
                graph[secondBuildingId].Connections.Add(new Connection(graph[firstBuildingId], distance));
            }

            Solve(graph);
        }

        private static void Solve(Dictionary<int, Node> graph)
        {
            var allHospitals = graph.Where(n => n.Value.IsHospital == true).Select(n => n.Value);

            long result = long.MaxValue;

            foreach (var hospital in allHospitals)
            {
                foreach (var item in graph)
                {
                    item.Value.DjikstraDistance = long.MaxValue;
                }

                Dijkstra(hospital);

                long tempSUm = 0;

                foreach (var node in graph)
                {
                    if (!node.Value.IsHospital)
                    {
                        tempSUm += node.Value.DjikstraDistance;
                    }
                }
                if (tempSUm < result)
                {
                    result = tempSUm;
                }
            }

            Console.WriteLine(result);
          
        }

        public static void Dijkstra(Node hospital)
        {

            PriorityQueue<Node> allOrderedNodes = new PriorityQueue<Node>();

            hospital.DjikstraDistance = 0;

            allOrderedNodes.Enqueue(hospital);

            while (allOrderedNodes.Count > 0)
            {
                var currentNode = allOrderedNodes.Dequeue();
                if (currentNode.DjikstraDistance == long.MaxValue)
                {
                    break;
                }
                foreach (var conenction  in currentNode.Connections)
                {         
                    var potentialDistance = currentNode.DjikstraDistance + conenction.Distance;

                    if (potentialDistance < conenction.Node.DjikstraDistance)
                    {
                        conenction.Node.DjikstraDistance = potentialDistance;
                        allOrderedNodes.Enqueue(conenction.Node);
                    }
                }
            }
        }

        public class PriorityQueue<T> where T : IComparable
        {
            private T[] heap;
            private int index;

            public PriorityQueue()
            {
                this.heap = new T[16];
                this.index = 1;
            }

            public int Count
            {
                get
                {
                    return this.index - 1;
                }
            }

            public void Enqueue(T element)
            {
                if (this.index >= this.heap.Length)
                {
                    this.IncreaseArray();
                }

                this.heap[this.index] = element;

                int childIndex = this.index;
                int parentIndex = childIndex / 2;
                this.index++;

                while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
                {
                    T swapValue = this.heap[parentIndex];
                    this.heap[parentIndex] = this.heap[childIndex];
                    this.heap[childIndex] = swapValue;

                    childIndex = parentIndex;
                    parentIndex = childIndex / 2;
                }
            }

            public T Dequeue()
            {
                T result = this.heap[1];

                this.heap[1] = this.heap[this.Count];
                this.index--;

                int rootIndex = 1;

                while (true)
                {
                    int leftChildIndex = rootIndex * 2;
                    int rightChildIndex = (rootIndex * 2) + 1;

                    if (leftChildIndex > this.index)
                    {
                        break;
                    }

                    int minChild;
                    if (rightChildIndex > this.index)
                    {
                        minChild = leftChildIndex;
                    }
                    else
                    {
                        if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                        {
                            minChild = leftChildIndex;
                        }
                        else
                        {
                            minChild = rightChildIndex;
                        }
                    }

                    if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
                    {
                        T swapValue = this.heap[rootIndex];
                        this.heap[rootIndex] = this.heap[minChild];
                        this.heap[minChild] = swapValue;

                        rootIndex = minChild;
                    }
                    else
                    {
                        break;
                    }
                }

                return result;
            }

            public T Peek()
            {
                return this.heap[1];
            }

            private void IncreaseArray()
            {
                var copiedHeap = new T[this.heap.Length * 2];

                for (int i = 0; i < this.heap.Length; i++)
                {
                    copiedHeap[i] = this.heap[i];
                }

                this.heap = copiedHeap;
            }
        }
    }
}
