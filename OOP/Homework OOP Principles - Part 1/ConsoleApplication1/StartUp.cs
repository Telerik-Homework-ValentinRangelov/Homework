using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students_and_workers;

namespace ConsoleApplication1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { FirstName = "Ivcho", LastName = "Ivanov", Grade = 5 });
            students.Add(new Student { FirstName = "Valcho", LastName = "Stoqnov", Grade = 3 });
            students.Add(new Student { FirstName = "Gancho", LastName = "Ganchev", Grade = 2 });
            students.Add(new Student { FirstName = "Petkan", LastName = "Petkanov", Grade = 6 });
            students.Add(new Student { FirstName = "Boqn", LastName = "Biserov", Grade = 4 });
            students.Add(new Student { FirstName = "Gosho", LastName = "Ivanov", Grade = 4 });
            students.Add(new Student { FirstName = "Gosho", LastName = "Ivanov", Grade = 4 });
            students.Add(new Student { FirstName = "Georgi", LastName = "Bogoev", Grade = 6 });
            students.Add(new Student { FirstName = "Gopeto", LastName = "Metodiev", Grade = 3 });
            students.Add(new Student { FirstName = "Ilian", LastName = "Iliev", Grade = 3 });
            students.Add(new Student { FirstName = "Joe", LastName = "Prodanov", Grade = 2 });

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker { FirstName = "Samet", LastName = "Mikroskop", WorkHoursPerDay = 10, WeekSalary = 1200 });
            workers.Add(new Worker { FirstName = "Mohamet", LastName = "Cvete", WorkHoursPerDay = 4, WeekSalary = 400 });
            workers.Add(new Worker { FirstName = "Samolet", LastName = "Jultuk", WorkHoursPerDay = 8, WeekSalary = 600 });
            workers.Add(new Worker { FirstName = "Vurtolet", LastName = "Helikopter", WorkHoursPerDay = 3, WeekSalary = 700 });
            workers.Add(new Worker { FirstName = "Banan", LastName = "Dinq", WorkHoursPerDay = 5, WeekSalary = 1500 });
            workers.Add(new Worker { FirstName = "Qbulka", LastName = "Shtora", WorkHoursPerDay = 11, WeekSalary = 150 });
            workers.Add(new Worker { FirstName = "Sladoled", LastName = "Hladilnik", WorkHoursPerDay = 9, WeekSalary = 1000 });
            workers.Add(new Worker { FirstName = "Shokolad", LastName = "Jaba", WorkHoursPerDay = 7, WeekSalary = 450 });
            workers.Add(new Worker { FirstName = "Tavan", LastName = "Slon", WorkHoursPerDay = 7, WeekSalary = 500 });
            workers.Add(new Worker { FirstName = "Tapet", LastName = "Nar", WorkHoursPerDay = 6, WeekSalary = 350 });
            Console.WriteLine("Order Students by grades:");
            
            var orderedStudentsByGrades = students.OrderBy(s => s.Grade);
            foreach (var grade in orderedStudentsByGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("\n\n\nOrder Workers by salary:");

            var orderedStudentsBySalary = workers.OrderByDescending(w => w.MoneyPerHour());
            foreach (var money in orderedStudentsBySalary)
            {
                Console.WriteLine(money);
            }
            var listOfStudentsAndWorkers = students.Concat<Human>(workers)
                                                   .OrderBy(x => x.FirstName)
                                                   .ThenBy(x => x.LastName);
            Console.WriteLine("\n\n\nOrder Students and Workers by First Name and Last Name:");
            foreach (var man in listOfStudentsAndWorkers)
            {
                Console.WriteLine(man);
            }
        }
    }
}
