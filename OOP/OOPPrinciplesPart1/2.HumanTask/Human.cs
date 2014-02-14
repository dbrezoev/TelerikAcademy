using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Human
{
    private string firstName;
    private string lastName;

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        private set
        {
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        private set
        {
            this.lastName = value;
        }
    }

    protected Human(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.LastName = lastName;
    }
}