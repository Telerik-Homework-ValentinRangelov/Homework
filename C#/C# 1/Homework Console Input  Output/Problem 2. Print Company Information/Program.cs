using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Print_Company_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
             * last name, age and a phone number.
             Write a program that reads the information about a company and its manager and prints it back on the console.*/
            string companyName;
            string companyAddress;
            long phoneNumber;
            long faxNumber;
            string webSite;
            string managerFirstName;
            string managerLastName;
            int managerAge;
            long managerPhoneNumber;
            Console.WriteLine("Please enter");
            Console.WriteLine("Company name:");
            companyName = Console.ReadLine();
            Console.WriteLine("Company address:");
            companyAddress = Console.ReadLine();
            Console.WriteLine("Phone number:");
            phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Fax number:");
            faxNumber  = long.Parse(Console.ReadLine());
            Console.WriteLine("Website:");
            webSite = Console.ReadLine();
            Console.WriteLine("Manager first name:");
            managerFirstName = Console.ReadLine();
            Console.WriteLine("Manager last name:");
            managerLastName = Console.ReadLine();
            Console.WriteLine("Manager age:");
            managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Manager phone number:");
            managerPhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("\n\nCompany name:"+companyName);
            Console.WriteLine("Company address:"+companyAddress);
            Console.WriteLine("Phone number:"+phoneNumber);
            Console.WriteLine("Fax number:"+faxNumber);
            Console.WriteLine("Website:"+webSite);
            Console.WriteLine("Manager first name:"+managerFirstName);
            Console.WriteLine("Manager last name:"+managerLastName);
            Console.WriteLine("Manager age:"+managerAge);
            Console.WriteLine("\n\nManager phone number:"+managerPhoneNumber);

        }
    }
}
