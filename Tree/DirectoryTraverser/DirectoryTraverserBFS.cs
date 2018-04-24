using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tree
{
    public static class DirectoryTraverserBFS
    {        
        public static void TraverseDir(string directoryPath)
        {

            var visitedDirsQueue = new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));

            while (visitedDirsQueue.Count > 0)
            {
                var currentDir =  visitedDirsQueue.Dequeue();
                Console.WriteLine(currentDir.FullName);
                DirectoryInfo[] children = currentDir.GetDirectories();
                foreach (var child in children)
                {
                    visitedDirsQueue.Enqueue(child);
                }
            }
        }
    }
}
