using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Remover
{
    static int[] RemoveNegative(int[] arr)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]>=0)
            {
                list.Add(arr[i]);
            }
        }

        int[] result = list.ToArray();
        return result;
    }

    static void Remove(List<int> list)
    {
        
        for (int i = list.Count-1; i >= 0; i--)
        {
            if (list[i]<0)
            {
                for (int pos = i; pos < list.Count-1; pos++)
                {
                    list[pos] = list[pos + 1];
                }
                list.RemoveAt(list.Count - 1);
                
            }
        }
    }
    static void Main(string[] args)
    {
        int[] input = new int[] {1,5,3,-1,0,5,-19,87,0,-5,10 };
        var r = new List<int>(input);
        //var result = Remover.RemoveNegative(input);
        //Console.WriteLine(string.Join(", ",result));

        //Remover.Remove(r);
        //Console.WriteLine(string.Join(", ", r));
        r.RemoveAll(x => x < 0);
        Console.WriteLine(111111111111);
        Console.WriteLine(string.Join(", ",r));
    }
}
