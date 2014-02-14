using System.Collections.Generic;
class Teacher:Person
{
    private List<Discipline> disciplines = new List<Discipline>();

    public List<Discipline> Disciplines
    {
        get
        {
            return new List<Discipline>(this.disciplines);
        }
        set
        {
            this.disciplines = value;
        }
    }
}