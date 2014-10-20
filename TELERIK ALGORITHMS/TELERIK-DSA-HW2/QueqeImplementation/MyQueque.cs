using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLIstImplementation;

namespace QueqeImplementation
{
    class MyQueque<T> : System.Collections.Generic.IEnumerable<T>
    {
        private MyLinkedList<T> nodes = new MyLinkedList<T>();
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
            private set 
            { 
                this.count = this.nodes.Count();
            }
        }

        public void Enqueque(T value)
        {
            this.nodes.AddLast(value);
        }

        public T Dequeque()
        {
            if (this.Count == 0)
            {
                throw new ArgumentOutOfRangeException("Empty queque");
            }

            T result = this.nodes.FirstElement.Value;
            this.nodes.RemoveLast();
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.nodes.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
