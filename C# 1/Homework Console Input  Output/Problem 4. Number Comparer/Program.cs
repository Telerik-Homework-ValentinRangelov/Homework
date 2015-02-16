using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Number_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that gets two numbers from the console and prints the greater of them.
            Try to implement this without if statements.*/
            double firstNumber;
            double secondNumber;
            double biggerNumber;
            Console.WriteLine("Please enter your first number:");
            firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("First number:{0}",firstNumber);
            Console.WriteLine("Please enter your second number:");
            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Second number:{0}", secondNumber);
            biggerNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The bigger number is:{0}",biggerNumber);

        }
    }
}
