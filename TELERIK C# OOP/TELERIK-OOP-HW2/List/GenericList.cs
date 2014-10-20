using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class GenericList<T> where T : IComparable
    {       
        private T[] array;
        private int capacity = 1;
        private int index = 0;
               
        private T[] IncreaseArray()
        {
            capacity *= 2;
            T[] tempArray = new T[capacity];
            for (int i = 0; i < this.array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            return tempArray;
        }

        public GenericList()
        {
            this.capacity = capacity;
            this.array = new T[this.capacity];            
        }

        public void Add(T element)
        {
            if (index == capacity)
            {
                this.array = IncreaseArray();
            }
            array[this.index] = element;
            this.index++;
        }

        public T ElementAt(int index)
        {
            return array[index];
        }

        public int ElementByValue(T element)
        {
            return Array.IndexOf(this.array, element);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.array.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            this.index--;
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }

        public void InsertAt(int index, T element)
        {
            Array.Resize(ref array, array.Length + 1);
            if (index < 0 || index > this.array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = array.Length - 1; i >= index + 1; i--)
            {
                this.array[i] = this.array[i - 1];
            }
            this.index++;
            this.array[index] = element;       
        }

        public void Clear()
        {
            T[] temp = new T[capacity];
            array = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < index; i++)
			{
			    sb.Append(array[i] + " ");
			}

            return sb.ToString();
        }

        public T Min()
        {
            T min = this.array[0];
            for (int i = 1; i < index; i++)
            {
                if (min.CompareTo(this.array[i]) > 0)
                {
                    min = this.array[i];
                }
            }
            return min;   
        }
      
        public T Max()
        {
            T max = this.array[0];
            for (int i = 1; i < index; i++)
            {
                if (max.CompareTo(array[i]) < 0)
                {
                    max = this.array[i];
                }
            }
            return max;
        }

    }
}
