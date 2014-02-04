using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GenericList<T> where T : IComparable<T>
{    
    public T[] array;
    private int usedPlace;
    private int length;
    //constructor
    public GenericList(int capacity)
    {
        this.array = new T[capacity];
    }
    
    public int Length
    {
        get
        {
            return this.array.Length;
        }
    }

    
    public void AddElement(T element)
    {
        if (this.usedPlace == this.array.Length)
        {
            AutoGrow();
        }        
        this.array[this.usedPlace] = element;
        this.usedPlace++;
    }

    private bool IsIndexValid(int index)
    {
        if (index < 0 || index >= this.array.Length)
        {
            return false;
        }
        return true;
    }
    public T GetElement(int index)
    {
        if (!IsIndexValid(index))
        {
            throw new IndexOutOfRangeException("Trying to get element outside the array");
        }        
        return this.array[index];
    }


    public void RemoveAtIndex(int index)
    {
        if (index<0 || index>= this.usedPlace)
        {
            throw new IndexOutOfRangeException("Invalid index");
        }
        for (int i = index; i < this.usedPlace-1; i++)
        {
            this.array[i] = this.array[i + 1];
        }
        this.array[this.usedPlace - 1] = default(T);
        this.usedPlace--;
    }


    public void InsertAtIndex(T element, int index)
    {        
        if (this.array.Length == this.usedPlace)
        {            
            AutoGrow();
        }
        if (!IsIndexValid(index))
        {
            throw new IndexOutOfRangeException("Trying to insert at wrong index");
        }
        for (int i = this.array.Length-1; i >= index+1; i--)
        {
            this.array[i] = this.array[i - 1];
        }
        this.array[index] = element;        
        this.usedPlace++;
    }


    public void ClearArray()
    {
        for (int i = 0; i < this.array.Length; i++)
        {
            this.array[i] = default(T);
        }
        this.usedPlace = 0;
    }


    public int FindElement(T element)//return index of the element or -1 if not found
    {
        for (int i = 0; i < this.usedPlace; i++)
        {
            if (this.array[i].Equals(element))
            {
                return i;
            }
        }
        return -1; //!
    }


    private void AutoGrow()
    {
        T[] cloned = (T[])this.array.Clone();
        this.array = new T[this.array.Length * 2];
        for (int i = 0; i < cloned.Length; i++)
        {
            this.array[i] = cloned[i];
        }        
    }
    public T Max()
    {
        T max = this.array[0];
        for (int i = 0; i < this.usedPlace; i++)
        {
            if (this.array[i].CompareTo(max)>=0)
            {
                max = this.array[i];
            }
        }
        return max;
    }

    public T Min()
    {
        T min = this.array[0];
        for (int i = 0; i < this.array.Length; i++)
        {
            if (this.array[i].CompareTo(min) <= 0)
            {
                min = this.array[i];
            }
        }
        return min;
    }
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        for (int i = 0; i < this.array.Length; i++)
        {
            if (this.array[i] == null)
            {
                sb.Append("(null)");
            }
            else
            {
                sb.Append(this.array[i]);
            }
            if (i != this.array.Length - 1)
            {
                sb.Append(", ");
            }           
        }
        sb.Append("]");
        return sb.ToString();
    }

    public T this[int index]
    {
        get
        {
            if (!IsIndexValid(index))
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return this.array[index];
        }       
    }
    
}