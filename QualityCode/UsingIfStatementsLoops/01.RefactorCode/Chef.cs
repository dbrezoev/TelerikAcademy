using System.Collections.Generic;
using _01.RefactorCode;

public class Chef : ICook
{
    private Bowl bowl;
    private List<Vegetable> vegetables;

    public Chef()
    {
        this.bowl = new Bowl();
        this.vegetables = new List<Vegetable>();
    }    

    public Bowl Cook()
    {
        var resultBowl = new Bowl();
        var vegetables = new List<Vegetable>();

        vegetables.Add(Potato.GetPotato());
        vegetables.Add(Carrot.GetCarrot());

        foreach (var vegetable in vegetables)
        {
            this.Peel(vegetable);
            this.Cut(vegetable);
            resultBowl.AddContent(vegetable);
        }

        return resultBowl;
    }

    private void Peel(Vegetable vegetable)
    {
        vegetable.IsPeeled = true;
    }

    private void Cut(Vegetable vegetable)
    {
        vegetable.IsCut = true;
    }
}