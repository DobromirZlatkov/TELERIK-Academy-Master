using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPriorityQueue
{
    public class PriorityQueue<T> : IEnumerable<T> where T : IComparable<T>
    {
        private List<T> myPriorityQueue;

        public PriorityQueue()
        {
            this.myPriorityQueue = new List<T>();
        }

        public void Enqueue(T value)
        {
            this.myPriorityQueue.Add(value);

            if (myPriorityQueue.Count > 1)
            {
                BubbleUp(this.myPriorityQueue.Count - 1);
            }
        }

        public void BubbleUp(int checkIndex)
        {

            int lastAddedElemntIndex = checkIndex;
            int parentIndex = (lastAddedElemntIndex - 1) / 2;

            if (this.myPriorityQueue[parentIndex].CompareTo(this.myPriorityQueue[lastAddedElemntIndex]) < 0)
            {
                T changeItem = this.myPriorityQueue[parentIndex];
                this.myPriorityQueue[parentIndex] = this.myPriorityQueue[lastAddedElemntIndex];
                this.myPriorityQueue[lastAddedElemntIndex] = changeItem;
                if (parentIndex != 0)
                {
                    BubbleUp(parentIndex);
                }
            }
        }

        public T Dequeue()
        {
            if (this.myPriorityQueue.Count == 0)
            {
                throw new ArgumentException("No elements in the priority queue");
            }

            T element = this.myPriorityQueue[0];
            this.myPriorityQueue[0] = this.myPriorityQueue[this.myPriorityQueue.Count - 1];
            this.myPriorityQueue.RemoveAt(this.myPriorityQueue.Count - 1);
            BubbleDown(0);
            return element;
        }

        public void BubbleDown(int checkIndex)
        {

            int elemntIndexLeft = checkIndex + 1;
            int elemntIndexRight = checkIndex + 2;

            if (this.myPriorityQueue[elemntIndexLeft].CompareTo(this.myPriorityQueue[elemntIndexRight]) > 0)
            {
                if (this.myPriorityQueue[checkIndex].CompareTo(this.myPriorityQueue[elemntIndexLeft]) < 0)
                {
                    T changeItem = this.myPriorityQueue[checkIndex];
                    this.myPriorityQueue[checkIndex] = this.myPriorityQueue[elemntIndexLeft];
                    this.myPriorityQueue[elemntIndexLeft] = changeItem;
                    checkIndex = elemntIndexLeft;
                    if (checkIndex != this.myPriorityQueue.Count)
                    {
                        BubbleUp(checkIndex);
                    }
                }
            }
            else
            {
                if (this.myPriorityQueue[checkIndex].CompareTo(this.myPriorityQueue[elemntIndexRight]) < 0)
                {
                    T changeItem = this.myPriorityQueue[checkIndex];
                    this.myPriorityQueue[checkIndex] = this.myPriorityQueue[elemntIndexRight];
                    this.myPriorityQueue[elemntIndexRight] = changeItem;
                    checkIndex = elemntIndexRight;
                    if (checkIndex != this.myPriorityQueue.Count)
                    {
                        BubbleUp(checkIndex);
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.myPriorityQueue)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}