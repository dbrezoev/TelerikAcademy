
class Discipline
{
    private string name;
    private int numberOfLectures;
    private int numberOfExercises;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public int NumberOfLectures
    {
        get
        {
            return this.numberOfLectures;
        }
        set
        {
            this.numberOfLectures = value;
        }
    }

    public int NumberOfExercises
    {
        get
        {
            return this.numberOfExercises;
        }
        set
        {
            this.numberOfExercises = value;
        }
    }
}