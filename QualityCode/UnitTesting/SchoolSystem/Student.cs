namespace SchoolSystem
{
    using System;

    public class Student
    {
        private static int id = 10000;
        private string name;
        private int number;

        public Student(string name)
        {
            this.Name = name;
            this.Number = id++;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name of student cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            private set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("Number of the student has to be in the interval [10000 - 99999].");
                }

                this.number = value;    
            }
        }        
    }
}
