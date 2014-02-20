using System;
class Program
{
    static void Main(string[] args)
    {
        BitArray64 bits = new BitArray64(8);        
        foreach (var bit in bits)
        {
            Console.Write(bit);
        }
        Console.WriteLine();


        //checking equals
        Console.WriteLine(bits.Equals(new BitArray64(9))); //False 
        Console.WriteLine(bits.Equals(8)); //False (not the same type)

        //checking operators == and !=
        Console.WriteLine(bits==new BitArray64(8));     //true
        Console.WriteLine(bits== new BitArray64(9));    //false
        Console.WriteLine(bits!= new BitArray64(10));   //true
        
    }
}