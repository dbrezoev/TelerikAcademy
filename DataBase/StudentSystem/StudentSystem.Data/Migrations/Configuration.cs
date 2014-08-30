namespace StudentSystem.Data.Migrations
{
    using StudentSystem.Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed= true;
            this.ContextKey = "StudentSystem.Data.StudentSystemContext";
        }

        protected override void Seed(StudentSystemContext context)
        {
            var dataBaseCourse = new Course()
            {
                Name = "Databases",
                Description = "This course teach students how to work with databases. CRUD operations and so on.",
                Material = "Many themes including Entity Framework (Database First and Code First)",                
            };

            var dsaCourse = new Course()
            {
                Name = "DS&A",
                Description = "This course teach students how to work data structure and their efficiency.",
                Material = "Many themes including diferent data structures, algorythms and good practices.",
            };

            context.Courses.Add(dataBaseCourse);
            context.Courses.Add(dsaCourse);            
        }
    }
}
