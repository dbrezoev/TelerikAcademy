using System;

public class InvalidRangeException<T>:ApplicationException
{
    private T min;
    private T max;

    public InvalidRangeException(string name,T min, T max)
        :base(name)
    {
        this.min = min;
        this.max = max;
    }
}
