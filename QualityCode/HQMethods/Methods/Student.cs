namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string secondName, int age)
        {
            this.FirstName = firstName;
            this.LastName = secondName;
            this.Age = age;
        }
        
        public string FirstName
        {
            get
            {
                return this.FirstName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First Name cannot be null.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null.");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Wrong age.");
                }

                this.age = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            if (this.Age < other.Age)
            {
                return false;
            }
            else
            {
                return true;
            }
        }        
    }
}
