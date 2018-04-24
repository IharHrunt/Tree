using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Graph
    {
        private List<int>[] childNodes;
        
        public Graph(int size)
        {
            childNodes = new List<int>[size];

            for (int i = 0; i < size; i++)
            {
                childNodes[i] = new List<int>();
            }
        }
        
        public Graph(List<int>[] childNodes)
        {
            this.childNodes = childNodes;
        }

        public int Size
        {
            get { return childNodes.Length; }
        }
        
        public void AddEdge(int first, int last)
        {
            childNodes[first].Add(last);
        }
        
        public void RemoveEdge(int first, int last)
        {
            childNodes[first].Remove(last);
        }
        
        public bool HasEdge(int first, int last)
        {
            bool hasEdge = childNodes[first].Contains(last);
            return hasEdge;
        }
                
        public IList<int> GetSuccessors(int v)
        {
            return childNodes[v];
        }

    }
}
