namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        private ICollection<Student> students;

        public Course()
        {
            this.students = new HashSet<Student>();                 
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(20)]
        public string Description { get; set; }
        
        public string Material { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return this.students;  }
            set { this.students = value; }
        }
    }
}
