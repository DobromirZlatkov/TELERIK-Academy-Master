using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREE_LIKE_DATA
{
    class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode<T> Root
        {
            get { return this.root; }
        }

        private void TraverseDFS(TreeNode<T> root, string spaces)
        {
           
            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                TraverseDFS(child, spaces + "  ");
            }
        }

        public void TraverseDFS()
        {
            if (this.root == null)
            {
                return;
            }

            this.TraverseDFS(this.root, string.Empty);
        }

        public void TraverseBFS()
        {
            Queue<TreeNode<T>> queque = new Queue<TreeNode<T>>();
            queque.Enqueue(this.root);
            while (queque.Count > 0)
            {
                TreeNode<T> currentNode = queque.Dequeue();
                Console.WriteLine("{0} ", currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    TreeNode<T> childNode = currentNode.GetChild(i);
                    queque.Enqueue(childNode);
                }
            }
        }
    }
}
