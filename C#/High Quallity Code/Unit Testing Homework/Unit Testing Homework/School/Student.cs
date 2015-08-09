using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private readonly int uniqueNumber;
        private ICollection<Course> courses;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            uniqueNumber = School.UniqueNumber++;
            courses = new List<Course>();
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new Exception("First name cannot be empty or null");
                }
                this.firstName = value;
            }
        }



        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new Exception("Last name cannot be empty or null");
                }
                this.lastName = value;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new Exception("Course to be added cannot be null!");
            }
            this.courses.Add(course);
        }
        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new Exception("Course to be removed cannot be null!");
            }
            this.courses.Remove(course);
        }

    }
}
