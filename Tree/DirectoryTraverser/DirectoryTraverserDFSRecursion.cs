using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tree
{
    public static class DirectoryTraverserDFSRecursion
    {
        public static void TraverseDir(DirectoryInfo currentDir)
        {
            Console.WriteLine(currentDir.FullName);
            DirectoryInfo[] children = currentDir.GetDirectories();
            foreach (var child in children)
            {
                TraverseDir(child);
            }
        }      
    }
}
