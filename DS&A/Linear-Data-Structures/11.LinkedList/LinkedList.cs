using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyLinkedList<T>
{
    private ListItem<T> firstElement;

    public ListItem<T> FirstElement
    {
        get
        {
            return this.firstElement;
        }
        private set
        {            
            this.firstElement = value;
        }
    }

    public MyLinkedList()
    {
        this.FirstElement = null;
    }

    public void AddFirst(T element)
    {
        if (this.FirstElement == null)
        {
            this.FirstElement = new ListItem<T>(element);
        }
        else
        {
            ListItem<T> newItem = new ListItem<T>(element);
            newItem.NextItem = this.FirstElement;
            this.FirstElement = newItem;
        }
    }

    public void AddLast(T element)
    {        
        if (this.FirstElement == null)
        {
            this.FirstElement = new ListItem<T>(element);
        }
        else
        {
            ListItem<T> next = this.FirstElement;
            while (next.NextItem!=null)
            {
                next = next.NextItem;
            }

            next.NextItem = new ListItem<T>(element);
        }
    }

    public void AddBefore(ListItem<T> item, T element)
    {
        if (this.FirstElement == null)
        {
            this.FirstElement = item;
        }
        else
        {
            ListItem<T> forward = item;
            ListItem<T> next = this.FirstElement;
            while (next.NextItem != item)
            {
                next = next.NextItem;
            }

            next.NextItem = new ListItem<T>(element);
            next.NextItem.NextItem = forward;
            
        }
    }

    public void AddAfter(ListItem<T> item, T element)
    {
        if (this.FirstElement == null)
        {
            this.FirstElement = new ListItem<T>(element);
        }
        else
        {
            ListItem<T> temp = item.NextItem;
            item.NextItem = new ListItem<T>(element);
            item.NextItem.NextItem = temp;
        }        
    }

    public void Remove(T element) // removes the first occurence
    {
        ListItem<T> next = this.FirstElement;
        ListItem<T> previous = null;
        int count = 0;
        while (next.NextItem !=null)
        {
            count++;
            if (Object.Equals(next.Value,element))
            {
                // remove element
                previous.NextItem = next.NextItem;
                break;
            }

            next = next.NextItem;
            if (count == 1)
            {
                previous = this.FirstElement;
            }
            else
            {
                previous = previous.NextItem;
            }
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        if (this.FirstElement == null)
        {
            sb.AppendLine("[null]");
        }
        else
        {
            sb.Append("[");
            sb.Append(string.Format("{0}", this.FirstElement.Value));
            ListItem<T> next = this.FirstElement;

            while (next.NextItem != null)
            {
                next = next.NextItem;
                sb.Append(string.Format("-> {0}", next.Value));               
            }
            sb.AppendLine("]");
        }

        return sb.ToString();
    }
}