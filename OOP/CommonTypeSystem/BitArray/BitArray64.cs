using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
public class BitArray64:IEnumerable<int>
{
    private ulong value;

    public BitArray64(ulong value = 0)
    {
        this.Value = value;
    }

    public IEnumerator<int> GetEnumerator()
    {
        //BitArray64 currentNode = this;
        for (int i = 63; i > 0; i--)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public ulong Value
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

    public int this[int i]
    {
        get
        {
            if (i<0 || i>63)
            {
                throw new IndexOutOfRangeException();
            }
            return (int)((this.value>>i)&1);
        }        
    }

    public override bool Equals(object obj)
    {
        if (!(obj is BitArray64))
        {
            return false;
        }
        BitArray64 otherNum = obj as BitArray64;
        for (int i = 0; i < 63; i++)
        {
            if (!this[i].Equals(otherNum[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static bool operator ==(BitArray64 first, BitArray64 second)
    {
        return Object.Equals(first, second);
    }
    public static bool operator !=(BitArray64 first, BitArray64 second)
    {
        return !(Object.Equals(first, second));
    }

    
}