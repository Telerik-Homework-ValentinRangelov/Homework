using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Numbers_from_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that enters from the console 
             * a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. */
            Console.WriteLine("Enter your number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
