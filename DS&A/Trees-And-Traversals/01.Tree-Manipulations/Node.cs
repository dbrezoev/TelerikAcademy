using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        :this()
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
}
