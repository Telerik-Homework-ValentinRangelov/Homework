namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Start
    {

        static void Main()
        {
            Students[] arrOfStudetns =
            {
                new Students("Ivan", "Petrov", 12),
                new Students("Atanas", "Georgiev", 22),
                new Students("Georgi", "Atanassov", 50),
                new Students("Stamat", "Dimitrov", 19),
                new Students("Pesho", "Todorov", 27),
                new Students("Pesho", "Ivanov", 27),
                new Students("Pesho", "Peshev", 27),
                new Students("Pesho", "Andreev", 27)
            };
            List<Student> listOfStudent = new List<Student>();
            listOfStudent.Add(new Student("Ivan", "Rangelov", 0899343898, 2));
            listOfStudent.Add(new Student("Pesho", "Veselinov", 0874564899, 1));
            listOfStudent.Add(new Student("Vasko", "Mushov", 0899745632, 2));
            listOfStudent.Add(new Student("Gosho", "Yordanov", 0321654987, 1));
            listOfStudent.Add(new Student("Mosho", "Milanov", 0852369741, 2));
            listOfStudent.Add(new Student("Milko", "Qnkov", 0125478963, 1));
            listOfStudent.Add(new Student("Viktor", "Dqnkov", 0123987456, 2));

            Student.GroupTwo(listOfStudent);
            LongestString.FindLongestString();
           
        }


        public static int FirstBeforeLastName(Students[] stud)
        {
            var result = stud.Where(s => s.FirstName.CompareTo(s.LastName) == -1).ToArray();


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            return 0;
        }
        public static int AllStudentsWithAgeRange(Students[] stud)
        {
           var result = stud.Where(s => s.Age >= 18 && s.Age <= 24);
           foreach (var item in result)
           {
               Console.WriteLine(item);
           }
           return 0;

            
        }
        public static int OrderStudents(Students[] stud)
        {
            var result = stud.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            return 0;
        }
    }
    
}
