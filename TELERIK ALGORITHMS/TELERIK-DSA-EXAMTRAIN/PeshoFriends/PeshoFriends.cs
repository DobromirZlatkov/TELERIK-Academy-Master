﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeshoFriends
{
    class MainProgram
    {
        static void Main()
        {
            string firstRow = Console.ReadLine();
            var firstRowAsArray = firstRow.Split(' ');
            int N = int.Parse(firstRowAsArray[0]);//number of points
            int M = int.Parse(firstRowAsArray[1]);//number of streets
            int H = int.Parse(firstRowAsArray[2]);//number of hospitals

            string secondRow = Console.ReadLine();
            var allHospitals = secondRow.Split(' ');
            //int[] hospitals = new int[allHospitals.Length];


            //for (int i = 0; i < allHospitals.Length; i++)
            //{
            //    hospitals[i] = int.Parse(allHospitals[i]);
            //}
            Dictionary<Node, List<Connection>> graph = new Dictionary<Node, List<Connection>>();
            Dictionary<int, Node> allNodes = new Dictionary<int, Node>();

            int[,] pathMatrix = new int[N, N];

            for (int i = 0; i < M; i++)
            {
                string mrows = Console.ReadLine();
                string[] rowsAsArr = mrows.Split(' ');

                int firstPoint = int.Parse(rowsAsArr[0]);
                int secondPoint = int.Parse(rowsAsArr[1]);
                int distance = int.Parse(rowsAsArr[2]);

                if (!allNodes.ContainsKey(firstPoint))
                {
                    allNodes[firstPoint] = new Node(firstPoint);
                }


                if (!allNodes.ContainsKey(secondPoint))
                {
                    allNodes[secondPoint] = new Node(secondPoint);
                }

                Node firstNodeObject = allNodes[firstPoint];
                Node secondNodeObject = allNodes[secondPoint];

                if (!graph.ContainsKey(firstNodeObject))
                {
                    graph[firstNodeObject] = new List<Connection>();
                }

                if (!graph.ContainsKey(secondNodeObject))
                {
                    graph[secondNodeObject] = new List<Connection>();
                }

                graph[firstNodeObject].Add(new Connection(secondNodeObject, distance));
                graph[secondNodeObject].Add(new Connection(firstNodeObject, distance));
            }

            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHOspital = int.Parse(allHospitals[i]);

                allNodes[currentHOspital].IsHospital = true;
            }


            long result = long.MaxValue;

            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHospital = int.Parse(allHospitals[i]);

                DijkstraAlgorithm(graph, allNodes[currentHospital]);

                long tempSUm = 0;

                foreach (var node in allNodes)
                {
                    if (!node.Value.IsHospital)
                    {
                        tempSUm += node.Value.DijkstraDistance;
                    }
                }

                if (tempSUm< result)
                {
                    result = tempSUm;
                }
            }
            Console.WriteLine(result);
        }

        static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node sourse)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();

            foreach (var node in graph)
            {
                node.Key.DijkstraDistance = long.MaxValue;
            }
            sourse.DijkstraDistance = 0;

            queue.Enqueue(sourse);

            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();

                if (currentNode.DijkstraDistance == long.MaxValue)
                {
                    break;
                }

                foreach (var connection in graph[currentNode])
                {
                    var potDIstance = currentNode.DijkstraDistance + connection.Distance;

                    if (potDIstance < connection.ToNode.DijkstraDistance)
                    {
                        connection.ToNode.DijkstraDistance = potDIstance;
                        queue.Enqueue(connection.ToNode);
                    }
                }
            }
        }
    }

    public class Node: IComparable
    {
        public int Id { get; set; }

        public long DijkstraDistance { get; set; }

        public bool IsHospital { get; set; }

        public Node(int id)
        {
            this.Id = id;
            this.IsHospital = false;
        }

        public int CompareTo(object obj)
        {
            return this.DijkstraDistance.CompareTo((obj as Node).DijkstraDistance);
        }
    }

    public class Connection
    {
        public Node ToNode { get; set; }

        public long Distance { get; set; }

        public Connection(Node node, long distance)
        {
            this.ToNode = node;
            this.Distance = distance;
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
