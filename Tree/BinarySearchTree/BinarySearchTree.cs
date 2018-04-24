using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> root = null;

        public void Insert(T value)
        {
            root = Insert(value, null, root);
        }

        private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)
                {
                    node.leftChild = Insert(value, node, node.leftChild);
                }
                else if (compareTo > 0)
                {
                    node.rightChild = Insert(value, node, node.rightChild);
                }
            }
            return node;
        }

        public void Remove(T value)
        {
            BinaryTreeNode<T> nodeToDelete = Find(value);
            if (nodeToDelete != null)
            {
                Remove(nodeToDelete);
            }
        }

        private void Remove(BinaryTreeNode<T> node)
        {
            if (node.leftChild != null && node.rightChild != null)
            {
                BinaryTreeNode<T> replacement = node.rightChild;
                while (replacement.leftChild != null)
                {
                    replacement = replacement.leftChild;
                }
                node.value = replacement.value;
                node = replacement;
            }

            BinaryTreeNode<T> theChild = node.leftChild != null ? node.leftChild : node.rightChild;

            if (theChild != null)
            {
                theChild.parent = node.parent;

                if (node.parent == null)
                {
                    root = theChild;
                }
                else
                {
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = theChild;
                    }
                    else
                    {
                        node.parent.rightChild = theChild;
                    }
                }
            }
            else
            {
                if (node.parent == null)
                {
                    root = null;
                }
                else
                {
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = null;
                    }
                    else
                    {
                        node.parent.rightChild = null;
                    }
                }
            }
        }        

        private BinaryTreeNode<T> Find(T value)
        {
            BinaryTreeNode<T> node = root;
            while (node != null)
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)
                {
                    node = node.leftChild;
                }
                else if (compareTo > 0)
                {
                    node = node.rightChild;
                }
                else
                {
                    break;
                }
            }
            return node;
        }
        
        public bool Contains(T value)
        {
            bool found = Find(value) != null;
            return found;
        }

        private void PrintTreeDFS(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PrintTreeDFS(node.leftChild);
                Console.Write(node.value + " ");
                PrintTreeDFS(node.rightChild);
            }
        }

        public void PrintTreeDFS()
        {
            PrintTreeDFS(root);
            Console.WriteLine();
        }

    }
}
