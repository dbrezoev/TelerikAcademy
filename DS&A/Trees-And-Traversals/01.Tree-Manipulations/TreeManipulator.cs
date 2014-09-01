using System;
using System.Collections.Generic;

/*You are given a tree of N nodes represented as a set of N-1 pairs of nodes
 * (parent node, child node), each in the range (0..N-1). */

public class TreeManipulator
{
    //used in task d) for printing the result
    private static List<Node<int>> path = new List<Node<int>>();
    private static int maxCount = 0;

    //used in task e)
    private static LinkedList<Node<int>> pathWithSumS = new LinkedList<Node<int>>();

    static Node<int> FindRoot(Node<int>[] nodes)
    {
        for (int i = 0; i < nodes.Length; i++)
        {
            if (!nodes[i].HasParent)
            {
                return nodes[i];
            }            
        }

        throw new KeyNotFoundException("The tree has no root.");       
    }
    static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
    {
        List<Node<int>> result = new List<Node<int>>(nodes.Length);
        for (int i = 0; i < nodes.Length; i++)
        {
            if (nodes[i].Children.Count==0)
            {
                result.Add(nodes[i]);
            }
        }

        return result;
    }
    static List<Node<int>> FindMiddleNodes(Node<int>[] nodes)
    {
        List<Node<int>> middleNodes = new List<Node<int>>(nodes.Length);
        for (int i = 0; i < nodes.Length; i++)
        {
            if (nodes[i].HasParent && nodes[i].Children.Count>0)
            {
                middleNodes.Add(nodes[i]);
            }
        }

        return middleNodes;
    }
    static void Main(string[] args)
    {        
        int N = int.Parse(Console.ReadLine()); 

        var nodes = new Node<int>[N];
        for (int i = 0; i < N; i++)
        {
            nodes[i] = new Node<int>(i);
        }

        for (int i = 0; i < N-1; i++)
        {
            string pairs = Console.ReadLine();

            var pairsSplitted = pairs.Split(' ');
            var root = int.Parse(pairsSplitted[0]);
            var child = int.Parse(pairsSplitted[1]);            
            nodes[root].AddChild(nodes[child]);
        }
      
        //a) Find the root
        Console.WriteLine("---Root---");
        Console.WriteLine(FindRoot(nodes).Value);

        //b)Find all leafs
        Console.WriteLine("---All Leafs---");
        List<Node<int>> leafs = FindAllLeafs(nodes);
        
        foreach (var leaf in leafs)
        {
            Console.Write(leaf.Value+", ");
        }
        Console.WriteLine();
        
        //c) find all middle nodes
        Console.WriteLine("---ALL MIDDLE NODES---");
        var middleNodes = FindMiddleNodes(nodes);

        foreach (var middleNode in middleNodes)
        {
            Console.Write(middleNode.Value + ", ");
        }
        Console.WriteLine();

        //d) Find the longest path in the tree
        Console.WriteLine("---Longest path count---");
        int res = FindLongestPath(FindRoot(nodes));
        Console.WriteLine(res);
       

        Console.WriteLine("---Longest path---");
        PrintLongestPath(FindRoot(nodes));

        foreach (var item in TreeManipulator.path)
        {
            Console.WriteLine(item.Value);
        }

        // I`ll use it in next task too
        //TreeManipulator.path = new List<Node<int>>();

        //e)
        Console.WriteLine("---Find path with sum S ---");
        FindPathSumSDFS(FindRoot(nodes), 14);

        //f)

        //fill dictionary with all connections using BFS
        //BFS(FindRoot(nodes));
        //Console.WriteLine();
        
    }          

    private static int sumOfPathToFind;    
    
    private static void FindPathSumSDFS(Node<int> root, int sum)
    {
        TreeManipulator.sumOfPathToFind += root.Value;
        TreeManipulator.pathWithSumS.AddLast(root);
        if (root.Children.Count <= 0)
        {
            if (TreeManipulator.sumOfPathToFind == sum)
            {
                foreach (var item in TreeManipulator.pathWithSumS)
                {
                    Console.WriteLine(item.Value);
                }                
            }
            
            return;
        }
        
        foreach (var node in root.Children)
        {
            FindPathSumSDFS(node, sum);
            TreeManipulator.sumOfPathToFind -= node.Value;
            TreeManipulator.pathWithSumS.RemoveLast();
        }
    }    

    private static void DFS(Node<int> root)
    {
        //DFS implemented
        if (root.Children.Count<0)
        {
            return;
        }
        Console.WriteLine(root.Value);
        foreach (var node in root.Children)
        {
            DFS(node);
        }
        //Console.WriteLine(root.Value);
    }
    private static Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
    private static void BFS(Node<int> root)
    {
        Queue<Node<int>> q = new Queue<Node<int>>();
        q.Enqueue(root);
        while (q.Count != 0)
        {
            var currentNode = q.Dequeue();
            dict.Add(currentNode.Value,new List<int>());
            Console.WriteLine(currentNode.Value);
            foreach (var child in currentNode.Children)
            {
                dict[currentNode.Value].Add(child.Value);
                q.Enqueue(child);
            }
        }         
    }

    //private static bool IsTree(List<int> nodes)
    //{

    //}

    private static int FindLongestPath(Node<int> root)
    {
        if (root.Children.Count==0)
        {
            return 0;
        }
        int maxPath = 0;

        foreach (var child in root.Children)
        {
            maxPath = Math.Max(maxPath, FindLongestPath(child));            
        }
        
        return maxPath + 1;
    }
    
    private static void PrintLongestPath(Node<int> root)
    {
        if (root.Children.Count==0)
        {            
            List<Node<int>> result = new List<Node<int>>();
            do
            {
                result.Add(root);
                root = root.Parent;

            } while (root!=null);

            if (result.Count >= TreeManipulator.maxCount)
            {
                TreeManipulator.maxCount = result.Count;
                TreeManipulator.path = result;
            }
            
            result = new List<Node<int>>();
            return;
        }

        foreach (var child in root.Children)
        {
            PrintLongestPath(child);
        }
    }
}