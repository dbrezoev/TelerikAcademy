using System;
using System.Collections.Generic;
public class TreeNode
{
    private int value;
    private TreeNode parent;
    private bool hasParent;
    private List<TreeNode> children;

    public TreeNode(int value, TreeNode parent)
    {
        if (value==null)
        {
            throw new ArgumentNullException("Cannot insert null!");
        }
        this.value = value;
        this.parent = parent;
        this.children = new List<TreeNode>();
    }

    public int Value
    {
        get
        {
            return this.value;
        }
        set
        {
            this.value = value;
        }
    }
    public List<TreeNode> Children
    {
        get
        {
            return this.children;
        }
        private set
        {
            this.children = value;
        }
    }
    public TreeNode Parent
    {
        get
        {
            return this.parent;
        }
    }
}
class ShortestCountOfOperations
{
    public static Func<int, int> operation1 = (x) => (x + 1);
    public static Func<int, int> operation2 = (x) => (x + 2);
    public static Func<int, int> operation3 = (x) => (x * 2);
    public static Func<int, int>[] array = new Func<int, int>[] { operation1, operation2, operation3 };

    static void Main(string[] args)
    {
        int n = 5;
        int m = 16;        
        TreeNode root = new TreeNode(n,null);
        FillTree(root, m);
        Console.WriteLine();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int count = 0;

        var result = new List<int>();
        result.Add(m);
        while (q.Count>0)
        {
            count++;
            TreeNode current = q.Dequeue();

            foreach (var child in current.Children)
            {
                q.Enqueue(child);
            }
                       
            if (current.Value==m)
            {
                //answer found printing path:                
                do
                {
                    result.Add(current.Parent.Value);                    
                    current = current.Parent;
                } while (current.Parent.Value!=n);
                result.Add(n);
                break;
            }
            else if (current.Value > 16)
            {
                continue;
            }
        }

        for (int i = result.Count-1; i >= 0; i--)
        {
            Console.Write(result[i] + ", ");
        }
        Console.WriteLine();
    }

    public static void FillTree(TreeNode root, int end)
    {        
        int currentValue = root.Value;
        int childValue;
        TreeNode childNode;

        if (currentValue>=end)
        {
            return;
        }

        foreach (var operation in array)
        {
            childValue = operation(currentValue);
            childNode = new TreeNode(childValue, root);
            root.Children.Add(childNode);
            FillTree(childNode, end);
        }
    }
}