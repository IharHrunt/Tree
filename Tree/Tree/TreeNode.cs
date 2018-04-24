using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class TreeNode<T>
    {
        private bool hasParent;
        private List<TreeNode<T>> children;
        public T Value { get; set; }

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            Value = value;
            children = new List<TreeNode<T>>();
        }

        public int ChildrenCount
        {
            get
            {
                return children.Count;
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }
            child.hasParent = true;
            children.Add(child);
        }
        
        public TreeNode<T> GetChild(int index)
        {
            return children[index];
        }
    }
}
