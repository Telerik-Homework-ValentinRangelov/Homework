using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Play_with_Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/
            string userChoice;
            int a;
            double b;
            string c;
            Console.WriteLine("Please select int , double or string.");
            Console.WriteLine("1 for int");
            Console.WriteLine("2 for double");
            Console.WriteLine("3 for string");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Please enter an integer number:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your integer number + 1 is:"+(a+1));
                    break;
                
                    case "2":
                    Console.WriteLine("Please enter an double number:");
                     b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Your double number + 1 is:"+(b+1.0));
                        break;
                
                    case "3":
                    Console.WriteLine("Please enter a string:");
                     c = Console.ReadLine();
                    Console.WriteLine("Your string is:"+c+"*");
                        break;
            }
                
            
        }
    }
}
