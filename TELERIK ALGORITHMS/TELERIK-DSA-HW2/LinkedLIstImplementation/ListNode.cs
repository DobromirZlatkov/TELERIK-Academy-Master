namespace LinkedLIstImplementation
{
    public class ListNode<T>
    {
        private T value;
        public ListNode<T> NextItem = null;

        public T Value 
        {
            get 
            { 
                return this.value;
            }

            set
            {
                this.value = value; 
            }
        }

        public ListNode(T value)
        {
            this.Value = value;
        }
    }
}
