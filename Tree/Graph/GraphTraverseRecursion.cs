using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public static class GraphTraverseRecursion
    {
        public static Graph graph = new Graph(new List<int>[] {
            new List<int>() {4},
            new List<int>() {1, 2, 6},
            new List<int>() {1, 6},
            new List<int>() {6},
            new List<int>() {0},
            new List<int>() {},
            new List<int>() {1, 2, 3}
        });

        public static bool[] visited = new bool[graph.Size];

        public static void TraverseDFS(int vertex)
        {
            if (!visited[vertex])
            {
                Console.Write(vertex + " ");
                visited[vertex] = true;
                foreach (int child in graph.GetSuccessors(vertex))
                {
                    TraverseDFS(child);
                }
            }

            
        }

    }
}
