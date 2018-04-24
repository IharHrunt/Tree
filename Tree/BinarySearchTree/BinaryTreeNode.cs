using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        public T value;
        public BinaryTreeNode<T> parent;
        public BinaryTreeNode<T> leftChild;
        public BinaryTreeNode<T> rightChild;

        public BinaryTreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.value = value;
            parent = null;
            leftChild = null;
            rightChild = null;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;
            return CompareTo(other) == 0;
        }

        public int CompareTo(BinaryTreeNode<T> other)
        {
            return value.CompareTo(other.value);
        }
    }

}
