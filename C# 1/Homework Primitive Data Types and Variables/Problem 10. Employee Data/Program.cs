using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            char gender;
            long personal_ID_Number;
            int uniqueEmployeeNumber;
            firstName = "Valentin";
            lastName = "Rangelov";
            age = 18;
            gender = 'm';
            personal_ID_Number = 8306112507;
            uniqueEmployeeNumber = 27560000;
            Console.WriteLine("First name: "+firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender (m/f): " + gender);
            Console.WriteLine("Personal ID number: " + personal_ID_Number);
            Console.WriteLine("Unique employee number: " + uniqueEmployeeNumber);


            

        }
    }
}
