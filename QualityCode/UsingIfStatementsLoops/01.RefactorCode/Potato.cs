using _01.RefactorCode;

public class Potato : Vegetable
{
    public static Vegetable GetPotato()
    {
        return new Potato();
    }
}