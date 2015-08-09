using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
namespace School.Tests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestStudentWithEmptyFirstName()
        {
            Student student = new Student("", "LastName");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestStudentWithEmptyLastName()
        {
            Student student = new Student("FirstName","");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestStudentWithNullFirstName()
        {
            Student student = new Student(null, "LastName");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestStudentWithNullLastName()
        {
            Student student = new Student("FirstName", null);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestToAddNullCourseToStudentCourses()
        {
            Student student = new Student("FirstName", "LastName");
            student.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestToRemoveNullCourseToStudentCourses()
        {
            Student student = new Student("FirstName", "LastName");
            student.RemoveCourse(null);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddingNullStudentToCourse()
        {
            Course course = new Course();
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemovingNullStudentToCourse()
        {
            Course course = new Course();
            course.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddingMoreThan30StudentsInCourse()
        {
            Course course = new Course();
            Student student;
            for (int i = 0; i < 31; i++)
            {
                student = new Student("firstName" + i, "lastName" + i);
                course.AddStudent(student);
            }
        }

        

        [TestMethod]
        public void GettingFirstNameOfStudent()
        {
            Student student = new Student("FirstName", "LastName");

            var firstname = student.FirstName;

            Assert.AreEqual("FirstName", firstname, "First name is not the same as expected!");
        }
        [TestMethod]
        public void GettingLastNameOfStudent()
        {
            Student student = new Student("FirstName", "LastName");

            var lasttname = student.LastName;

            Assert.AreEqual("LastName", lasttname, "Last name is not the same as expected!");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddingUniqueNumberOver99999()
        {
            while (School.UniqueNumber < 99999)
            {
                School.UniqueNumber++;
            }
            Student student = new Student("firstname", "lastname");
        }
    }


}
