namespace MaximalPath
{
    using System;
    using System.Collections.Generic;

    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }
        private bool hasParent;
        private Node<T> parent;

        public Node<T> Parent
        {
            get
            {
                return this.parent;
            }

            private set
            {
                this.parent = value;
            }
        }

        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T value)
            : this()
        {
            this.Value = value;
        }

        public void AddChild(Node<T> child)
        {
            this.Children.Add(child);
            child.hasParent = true;
            child.Parent = this;
        }

        public bool HasParent
        {
            get
            {
                return this.hasParent;
            }
        }

        public int ChildrenCount
        {
            get
            {
                return this.Children.Count;
            }
        }

        public Node<T> GetNode(int index)
        {
            return this.Children[index];
        }
    }

    public class Program
    {
        static long maxSum = 0;
        static HashSet<Node<int>> usedNodes = new HashSet<Node<int>>();

        static void DFS(Node<int> node, long currentSum)
        {
            currentSum += node.Value;
            usedNodes.Add(node);

            for (int i = 0; i < node.ChildrenCount; i++)
            {
                if (usedNodes.Contains(node.GetNode(i)))
                {
                    continue;
                }

                DFS(node.GetNode(i), currentSum);
            }            

            if (node.ChildrenCount == 1 && currentSum >= maxSum)
            {
                maxSum = currentSum;
            }
        }

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char[] separators = new char[] { '(', ')', '<', '-', ' ' };

            Dictionary<int, Node<int>> nodes = new Dictionary<int, Node<int>>();

            for (int i = 0; i < n-1; i++)
            {
                string command = Console.ReadLine();
                var numbers = command.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                var parent = int.Parse(numbers[0]);
                var child = int.Parse(numbers[1]);

                Node<int> parentNode;                                

                if (nodes.ContainsKey(parent))
                {
                    parentNode = nodes[parent];
                }
                else
                {
                    parentNode = new Node<int>(parent);
                    nodes.Add(parent, parentNode);
                }

                Node<int> childNode;
                if (nodes.ContainsKey(child))
                {
                    childNode = nodes[child];
                }
                else
                {
                    childNode = new Node<int>(child);
                    nodes.Add(child, childNode);
                }

                parentNode.AddChild(childNode);
                childNode.AddChild(parentNode); 
            }

            foreach (var node in nodes)
            {
                if (node.Value.ChildrenCount == 1)
                {
                    usedNodes.Clear();
                    DFS(node.Value, 0);
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
