using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiDictionary
{
    class BiDictionary<TKey1, TKey2, TValue>
    {
        private SortedDictionary<TKey1, List<TValue>> firstKeyTable;
        private SortedDictionary<TKey2, List<TValue>> secondKeyTable;
        private SortedDictionary<string, List<TValue>> bothKeysTable;

        public BiDictionary()
        {
            this.firstKeyTable = new SortedDictionary<TKey1, List<TValue>>();
            this.secondKeyTable = new SortedDictionary<TKey2, List<TValue>>();
            this.bothKeysTable = new SortedDictionary<string, List<TValue>>();
        }

        public void Add(TKey1 firstKey, TKey2 secondKey, TValue value)
        {
            if (this.firstKeyTable.ContainsKey(firstKey))
            {
                this.firstKeyTable[firstKey].Add(value);
            }
            else
            {
                this.firstKeyTable.Add(firstKey, new List<TValue> { value });
            }

            if (this.secondKeyTable.ContainsKey(secondKey))
            {
                this.secondKeyTable[secondKey].Add(value);
            }
            else
            {
                this.secondKeyTable.Add(secondKey, new List<TValue> { value });
            }

            if (this.bothKeysTable.ContainsKey(firstKey.ToString() + secondKey.ToString()))
            {
                this.bothKeysTable[firstKey.ToString() + secondKey.ToString()].Add(value);
            }
            else
            {
                this.bothKeysTable.Add(firstKey.ToString() + secondKey.ToString(), new List<TValue> { value });
            }
        }

        public IEnumerable FindByFistKey(TKey1 key)
        {
            return this.firstKeyTable[key];
        }

        public IEnumerable FindBySecondKey(TKey2 key)
        {
            return this.secondKeyTable[key];
        }

        public IEnumerable FindByBothKeys(TKey1 firstKey, TKey2 secondKey)
        {
            return this.bothKeysTable[firstKey.ToString() + secondKey.ToString()];
        }

        
    }
}
