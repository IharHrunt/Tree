using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Tree<T>
    {        
        public TreeNode<T> Root { get; private set; }

        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }            
            Root = new TreeNode<T>(value);
        }
        
        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (Tree<T> child in children)
            {
                Root.AddChild(child.Root);     
            }
        }

        private void PrintDFS(TreeNode<T> node, string spaces)
        {
            if (Root == null)
            {
                return;
            }
            Console.WriteLine(spaces + node.Value);
            
            TreeNode<T> child = null;

            for (int i = 0; i < node.ChildrenCount; i++)
            {
                child = node.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }
        
        public void TraverseDFS()
        {
            this.PrintDFS(Root, string.Empty);
        }
    }
}
