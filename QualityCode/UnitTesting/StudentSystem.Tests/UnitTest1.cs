using System;
using SchoolSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void CheckName()
        {
            Student st = new Student("Pesho");
            Assert.AreEqual("Pesho", st.Name);
        }

        [TestMethod]
        public void CheckNumberID()
        {
            Student st = new Student("Pesho");
            Assert.IsTrue(st.Number > 10000 && st.Number < 99999);
        }

        [TestMethod]
        public void CheckLeaveMethod()
        {
            List<Student> students = new List<Student>();
            var student = new Student("Pesho");
            students.Add(student);
            Course course = new Course(students);
            course.Leave(student);
            Assert.AreEqual(0, course.Count);
        }     

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckCreateFilledCourse()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                students.Add(new Student("Pesho"));
            }

            Course course = new Course(students);
        }      

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckFullCourse()
        {
            int count = Course.GetMaxStudents();

            Course course = new Course();
            for (int i = 0; i < count + 1; i++)
            {
                Student student = new Student("Pesho");
                course.Join(student);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckInvalidID()
        {
            for (int i = 10000; i <= 99999 + 1; i++)
            {
                Student student = new Student("Pesho");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckRealName()
        {
            Student student = new Student("");
        }       

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckCourseInstanceCreation()
        {
            Course course = new Course(null);
        }

        
             
        
    }
}
