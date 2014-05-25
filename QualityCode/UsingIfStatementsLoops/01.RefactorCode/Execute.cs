using System;

public class Execute
{
    public static void Main()
    {
        var chef = new Chef();
        var result = chef.Cook();
        result.Serve();
    }
}
