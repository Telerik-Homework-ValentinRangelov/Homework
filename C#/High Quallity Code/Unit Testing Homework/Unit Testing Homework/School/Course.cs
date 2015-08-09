using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private IList<Student> students;
        public Course()
        {
            students = new List<Student>(30);
        }

        public void AddStudent(Student student)
        {
            if (students.Count == 30)
            {
                throw new Exception("There cannot be more than 30 students in a course");
            }
            if(student == null)
            {
                throw new Exception("Student to be added cannot be null!");
            }
            students.Add(student);
            student.AddCourse(this);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new Exception("Student to be removed cannot be null!");
            }
            students.Remove(student);
            student.RemoveCourse(this);
        }

    }

}
