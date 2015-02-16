using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Numbers_from_1_to_n
{
    /*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.*/
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 1;
            Console.WriteLine("Please enter your integer number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = n;i>=1;i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
