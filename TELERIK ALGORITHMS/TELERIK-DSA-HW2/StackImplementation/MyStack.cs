using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class MyStack<T> : System.Collections.Generic.IEnumerable<T>
    {
        private T[] stackContainer;
        private int count;

        public MyStack()
        {
            this.stackContainer = new T[4];
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }            
        }

        public void Push(T value)
        {
            if (this.Count == this.stackContainer.Length)
            {
                ResizeStackContainer();
            }

            this.stackContainer[this.Count] = value;
            this.count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new ArgumentNullException("Stack is empty");
            }

            T result = this.stackContainer[this.Count - 1];
            this.count--;

            return result;
        }

        public void TrimExcess()
        {
            T[] newArray = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.stackContainer[i];
            }

            this.stackContainer = newArray;
        }

        public bool Contains(T value)
        {
            bool doExists = false;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.stackContainer[i].Equals(value))
                {
                    doExists = true;
                    break;
                }
            }

            return doExists;
        }

        private void ResizeStackContainer()
        {
            T[] newContainer = new T[this.stackContainer.Length * 2];
            for (int i = 0; i < this.stackContainer.Length; i++)
            {
                newContainer[i] = this.stackContainer[i];
            }

            this.stackContainer = newContainer;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return stackContainer[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
