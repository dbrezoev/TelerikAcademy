namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name)
            : this(name, null)
        {
        }

        public LocalCourse(string name, string teacherName)
            : this(name, teacherName, null)
        {
            this.Students = new List<string>();
        }

        public LocalCourse(string name, string teacherName, IList<string> students) 
            : this(name, teacherName, students, null)
        {            
        }

        public LocalCourse(string name, string teacherName, IList<string> students, string lab) 
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab 
        {
            get
            {
                return this.lab;
            }

            set
            {               
                this.lab = value;
            }
        }                

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse ");
            result.Append(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
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
