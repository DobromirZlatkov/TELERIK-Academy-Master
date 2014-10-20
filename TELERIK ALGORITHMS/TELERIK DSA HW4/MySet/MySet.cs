namespace MySet
{
   
    using System;
    using System.Collections.Generic;

    using HashTableImplementation;
    using System.Collections;

    public class MySet<T> : IEnumerable<T>
    {

        private HashTable<T, T> container;

        public MySet()
        {
            this.container = new HashTable<T, T>();
        }

        public int Count
        {
            get
            {
                return this.container.Count;
            }
            private set { }
        }

        public void Add(T value)
        {
            this.container.Add(value, value);
        }

        public void Remove(T value)
        {
            this.container.Delete(value);
        }

        public T Find(T value)
        {
            T lookedValue = container.Find(value).Value;

            return lookedValue;
        }

        public void Clear()
        {
            this.container = new HashTable<T, T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.container)
            {
                if (item != null)
                {
                    yield return item.Value;
                }  
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Union(MySet<T> otherSet)
        {
            foreach (var item in otherSet)
            {
                if (!this.container.ContainsKey(item))
                {
                    this.container.Add(item, item);
                }
            }
        }

        public void IntersectWith(MySet<T> otherSet)
        {
            HashTable<T, T> otherTable = new HashTable<T, T>();
            foreach (var item in otherSet)
            {
                if (this.container.ContainsKey(item))
                {
                    otherTable.Add(item, item);
                }
            }

            this.container = otherTable;
        }
    }
}
