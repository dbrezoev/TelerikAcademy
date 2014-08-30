namespace StudentSystem.Data
{
    using StudentSystem.Models;
    using System.Data.Entity;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
            : base("StudentSystemConnection")
        {

        }
        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }
    }
}
