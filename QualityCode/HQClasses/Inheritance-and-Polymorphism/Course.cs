namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class   Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;
        
        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {               
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {                
                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return new List<string>(this.students);
            }

            set
            {                
                this.students = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("{ Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            if (this.Students.Count != 0)
            {
                result.Append("; Students = ");
                result.Append(this.GetStudentsAsString());
            }            

            return result.ToString();
        }

        public void AddStudent(string name)
        {
            this.students.Add(name);
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
