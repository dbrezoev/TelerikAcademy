using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyStack<T>
{
    private const int CAPACITY = 1;
    private List<T> list;
    private int count = 0 ;


    public int Count
    {
        get
        {
            return this.count;
        }
        private set
        {
            if (value<0)
            {
                throw new ArgumentException("Count cannot be less than zero!");
            }
            this.count = value;
        }

    }
    public List<T> List
    {
        get
        {
            return new List<T>(this.list);
        }        
    }

    public MyStack(int capacity = CAPACITY)
    {
        this.list = new List<T>(capacity);
    }

    public void Push(T item)
    {        
        this.list.Add(item);
        count++;
    }

    public T Pop()
    {
        var result =  this.list[this.list.Count - 1];
        this.Count--;
        var copied = new List<T>(this.list.Count-1);
        for (int i = 0; i < copied.Count; i++)
        {
            copied[i] = this.list[i];
        }

        this.list = new List<T>(copied);

        return result;
    }

    public T Peek()
    {
        return this.list[this.list.Count - 1];
    }

    public bool Contains(T item)
    {
        bool result = false;
        for (int i = 0; i < this.list.Count; i++)
        {
            if (Object.Equals(this.list[i], item))
            {
                result = true;
                break;
            }
        }

        return result;
    }

    public void Clear()
    {
        this.list = new List<T>(CAPACITY);
    }


    //private void AutoResize()
    //{
    //    var copied = new List<T>(this.list.Count * 2);
    //    for (int i = 0; i < this.list.Count; i++)
    //    {
    //        copied[i] = this.list[i];
    //    }
    //}
}