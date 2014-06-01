namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MAX_STUDENTS = 30;
        private IList<Student> students;
        private int count;

        public Course() 
        {
            this.students = new List<Student>();
        }
        public Course(List<Student> students)
        {
            this.Students = students;
        }

        public int Count
        {
            get
            {
                return this.Students.Count;
            }
        }
        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot set null students.");
                }

                if (value.Count > MAX_STUDENTS)
                {
                    throw new ArgumentOutOfRangeException("Students in a course should be less than " + MAX_STUDENTS);
                }

                this.students = value;
            }
        }

        public static int GetMaxStudents()
        {
            return Course.MAX_STUDENTS;
        }

        public void Join(Student student)
        {                  
            this.students.Add(student);

            if (this.students.Count > MAX_STUDENTS)
            {
                throw new ArgumentOutOfRangeException("Course is already full.");
            }
        }

        public void Leave(Student student)
        {            
            this.students.Remove(student);
        }
    }
}
