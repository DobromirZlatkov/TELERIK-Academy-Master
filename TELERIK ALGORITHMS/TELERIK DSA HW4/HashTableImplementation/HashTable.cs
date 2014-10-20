namespace HashTableImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        private LinkedList<KeyValuePair<K, V>>[] values;

        public HashTable()
        {
            this.values = new LinkedList<KeyValuePair<K, V>>[4];
        }

        public int Count
        {
            get;
            private set;
        }

        public int Capacity
        {
            get
            {
                return this.values.Length;
            }
        }

        public object KeyValuePair { get; set; }

        public V this[K key]
        {
            get
            {
                return this.Find(key).Value;
            }

            set
            {
                this.SetValue(key, value);
            }
        }

        public void Add(K key, V value)
        {
            var hash = this.HashKey(key);

            if (this.values[hash] == null)
            {
                this.values[hash] = new LinkedList<KeyValuePair<K, V>>();
            }

            var alreadyHasKey = this.values[hash].Any(p => p.Key.Equals(key));

            if (alreadyHasKey)
            {
                throw new ArgumentException("Key already Exists");
            }

            var pair = new KeyValuePair<K, V>(key, value);
            this.values[hash].AddLast(pair);
            this.Count++;

            if (this.Count >= 0.75 * this.Capacity)
            {
                this.ResizeAndReadValues();
            }
        }

        public bool ContainsKey(K key)
        {
            var hash = this.HashKey(key);
            if (this.values[hash] == null)
            {
                return false;
            }

            var pairs = this.values[hash];
            return pairs.Any(pair => pair.Key.Equals(key));
        }

        public KeyValuePair<K, V> Find(K key)
        {
            foreach (var valueCollection in this.values)
            {
                if (valueCollection != null)
                {
                    foreach (var item in valueCollection)
                    {
                        if (item.Key.Equals(key))
                        {
                            return item;
                        }
                    }
                }                
            }

            throw new ArgumentNullException("Key doesn't exists");
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            foreach (var valueCollection in this.values)
            {
                if (valueCollection != null)
                {
                    foreach (var value in valueCollection)
                    {
                        yield return value;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Delete(K key)
        {
            var keyValuePairToRemove = this.Find(key);
            foreach (var listOfKeyValuepairs in this.values)
            {
                if (listOfKeyValuepairs != null)
                {
                    if (listOfKeyValuepairs.Contains(keyValuePairToRemove))
                    {
                        listOfKeyValuepairs.Remove(keyValuePairToRemove);
                    }
                }
            }
        }

        public void Print()
        {
            foreach (var listOfKeyValues in this.values)
            {
                if (listOfKeyValues != null)
                {
                    foreach (var keyValuePair in listOfKeyValues)
                    {
                        Console.WriteLine(keyValuePair.Key + "-->" + keyValuePair.Value);
                    }
                }
            }
        }

        private void SetValue(K key, V value)
        {
            var keyValuePair = this.Find(key);
            keyValuePair.Value = value;
        }

        private int HashKey(K key)
        {
            var hash = Math.Abs(key.GetHashCode()) % this.Capacity;
            return hash;
        }

        private void ResizeAndReadValues()
        {
            ///cache old values
            var cachedValues = this.values;
            ///resize
            this.values = new LinkedList<KeyValuePair<K, V>>[2 * this.Capacity];

            ///add values
            this.Count = 0;

            foreach (var valueCollection in cachedValues)
            {
                if (valueCollection != null)
                {
                    foreach (var value in valueCollection)
                    {
                        this.Add(value.Key, value.Value);
                    }
                }
            }
        }
    }
}
