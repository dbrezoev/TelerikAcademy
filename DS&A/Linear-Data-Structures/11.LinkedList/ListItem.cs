using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListItem<T>
{
    private T value;
    private ListItem<T> nextItem;

    public T Value
    {
        get
        {
            return this.value;
        }
        private set
        {
            if (value==null)
            {
                throw new ArgumentNullException("Value cannot be null!!");
            }

            this.value = value;
        }
    }

    public ListItem<T> NextItem
    {
        get
        {
            return this.nextItem;
        }
        set
        {
            this.nextItem = value;
        }
    }

    public ListItem(T value,ListItem<T> nextItem=null)
    {
        this.value = value;
        this.nextItem = nextItem;
    }
}