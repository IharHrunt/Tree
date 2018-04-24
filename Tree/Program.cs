using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 10,  30, 40, 25, 50, 60, 70, 80, 90, 100, 110,
                          120, 130, 140, 150, 160, 171, 180, 200, 190 };
            var bs = new BinarySearch();
            var found1 = bs.Search(-5, arr);
            var found2 = bs.Search(205, arr);
            var found3 = bs.Search(181, arr);
            var found4 = bs.Search(25, arr);
            var found5 = bs.Search(200, arr);
            Console.WriteLine("-------------------------------------");


            var tree =
              new Tree<int>(7,
                  new Tree<int>(19,
                      new Tree<int>(1),
                      new Tree<int>(12),
                      new Tree<int>(31)),
                  new Tree<int>(21),
                  new Tree<int>(14,
                      new Tree<int>(23),
                      new Tree<int>(6))
            );
            tree.TraverseDFS();
            Console.WriteLine("-------------------------------------");
            

            var bst = new BinarySearchTree<string>();
            bst.Insert("5");
            bst.Insert("2");
            bst.Insert("3");
            bst.Insert("7");
            bst.Insert("1");
            bst.Insert("6");
            bst.Insert("4");
            bst.Insert("9");
            bst.Insert("8");
            bst.Insert("10");
            bst.Insert("22");
            bst.PrintTreeDFS();
            Console.WriteLine("5 exists = {0}", bst.Contains("5"));
            bst.Remove("5");
            Console.WriteLine("5 exists = {0}", bst.Contains("5"));
            bst.PrintTreeDFS();
            Console.WriteLine("-------------------------------------");


            string path = "D:\\Install";
            DirectoryTraverserDFSRecursion.TraverseDir(new DirectoryInfo(path));
            Console.WriteLine("-------------------------------------");

            DirectoryTraverserDFS.TraverseDir(path);
            Console.WriteLine("-------------------------------------");

            DirectoryTraverserBFS.TraverseDir(path);
            Console.WriteLine("-------------------------------------");
            

            for (int v = 0; v < GraphTraverseRecursion.graph.Size; v++)
            {
                if (!GraphTraverseRecursion.visited[v])
                {
                    GraphTraverseRecursion.TraverseDFS(v);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("-------------------------------------");


            var comparer = new Point3DEqualityComparer();
            var dict = new Dictionary<Point3D, int>(comparer);
            dict[new Point3D(4, 2, 5)] = 5;
            dict[new Point3D(1, 2, 3)] = 11;
            dict[new Point3D(3, 1, -1)] = 3;
            dict[new Point3D(1, 2, 3)] = 100;

            foreach (var entry in dict)
            {
                Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
            }

            Console.ReadLine();
        }
    }
}
