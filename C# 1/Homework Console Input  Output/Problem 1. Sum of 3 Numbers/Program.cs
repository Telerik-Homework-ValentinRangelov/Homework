using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sum_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 real numbers from the console and prints their sum.
            int firstNumber, secondNumber, thirdNumber;
            Console.WriteLine("Enter your first number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number:");
            thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is:{0}",firstNumber);
            Console.WriteLine("Your second number is:{0}", secondNumber);
            Console.WriteLine("Your third number is:{0}", thirdNumber);



        }
    }
}
