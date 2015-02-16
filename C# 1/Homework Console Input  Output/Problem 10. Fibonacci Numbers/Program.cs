using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Problem_10.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
             * (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
              Note: You may need to learn how to use loops.*/
            Console.WriteLine("Please enter a number:");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) Console.WriteLine(0);
            else
            {
                BigInteger first = 0;
                BigInteger second = 1;
                Console.WriteLine(first);
                Console.WriteLine(second);
                BigInteger third = 0;
                for (int i = 2; i < n; i++)
                {
                    third = first + second;
                    Console.WriteLine(third + " ");
                    first = second;
                    second = third;
                }
            }
        }
    }
}
