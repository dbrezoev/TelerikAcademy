namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        public int Id { get; set; }

        [Required]
        [MinLength(20)]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
