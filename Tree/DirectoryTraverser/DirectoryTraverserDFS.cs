using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tree
{
    public static class DirectoryTraverserDFS
    {
        public static void TraverseDir(string directoryPath)
        {
            var visitedDirsQueue = new Stack<DirectoryInfo>();
            visitedDirsQueue.Push(new DirectoryInfo(directoryPath));

            while (visitedDirsQueue.Count > 0)
            {
                var currentDir = visitedDirsQueue.Pop();
                Console.WriteLine(currentDir.FullName);

                DirectoryInfo [] children = currentDir.GetDirectories();
                foreach (var child in children)
                {
                    visitedDirsQueue.Push(child);
                }
            }
        }
    }
}
