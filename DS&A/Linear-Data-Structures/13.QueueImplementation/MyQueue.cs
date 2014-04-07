using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyQueue<T>
{
    private LinkedList<T> list;

    public MyQueue()
    {
        this.list = new LinkedList<T>();
    }


    public LinkedList<T> List
    {
        get
        {
            return new LinkedList<T>(this.list);
        }        
    }
    public void Enqueue(T item)
    {
        if (this.List.First == null)
        {
            this.list.AddFirst(item);
        }
        else
        {
            this.list.AddLast(item);
        }
    }

    public void Dequeue()
    {
        this.list.RemoveFirst();
    }

    public void Clear()
    {
        this.list = new LinkedList<T>();
    }

    public bool Contains(T item)
    {
        bool result = false;
        if (this.List.First == null)
        {
            return false;
        }

        LinkedListNode<T> next = this.list.First;

        while (next.Next!= null)
        {
            if (Object.Equals(next.Value,item))
            {
                result = true;
                break;
            }
            next = next.Next;
        }

        //check last item
        if (Object.Equals(next.Value, item))
        {
            result = true;
        }
        next = next.Next;

        return result;
    }
}