namespace LinkedLIstImplementation
{
    public class MyLinkedList<T> : System.Collections.Generic.IEnumerable<T>
    {
        public ListNode<T> FirstElement { get; set; }

        public MyLinkedList()
        {
            this.FirstElement = null;
        }

        public void AddFirst(T value) 
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListNode<T>(value);
            }
            else
            {
                ListNode<T> newListItem = new ListNode<T>(value);
                newListItem.NextItem = this.FirstElement;
                this.FirstElement = newListItem;
            }
        }

        public void AddLast(T value) 
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListNode<T>(value);
            }
            else
            {
                ListNode<T> next = this.FirstElement;

                while (next.NextItem != null)
                {
                    next = next.NextItem;
                }

                next.NextItem = new ListNode<T>(value);
            }
        }

        public void RemoveItem(T elementToRemove)
        {
            if (this.FirstElement == null)
            {
                return;
            }

            ListNode<T> currentItem = this.FirstElement;

            if (currentItem.Value.Equals(elementToRemove))
            {
                this.FirstElement = currentItem.NextItem;
                return;
            }

            while (currentItem.NextItem != null)
            {
                if (currentItem.NextItem.Value.Equals(elementToRemove))
                {
                    currentItem.NextItem = currentItem.NextItem.NextItem;
                    return;
                }
                currentItem = currentItem.NextItem;
            }
        }

        public void RemoveFirst()
        {
            this.FirstElement = this.FirstElement.NextItem;
        }

        public void RemoveLast()
        {
            ListNode<T> next = this.FirstElement;

            while (next.NextItem != null)
            {
                next = next.NextItem;
            }

            ListNode<T> newNode = this.FirstElement;

            while (newNode.NextItem != next)
            {
                newNode = newNode.NextItem;
            }

            newNode.NextItem = null;
        }

        public int Count()
        {
            int count = 1;
            ListNode<T> next = this.FirstElement;
            while (next.NextItem != null)
            {
                next = next.NextItem;
                count++;
            }

            return count;
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var node = this.FirstElement;
            while (node != null)
            {
                yield return node.Value;
                node = node.NextItem;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
