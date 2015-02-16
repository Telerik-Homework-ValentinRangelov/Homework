using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/
            Console.WriteLine("Please enter your n integer number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your x integer number:");
            int x = int.Parse(Console.ReadLine());
            decimal resultX = 1;
            decimal factorialN = 1;
            decimal s = 0;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                resultX *= x;
                s += (factorialN / resultX);
            }
            Console.WriteLine(1 + s);
           
            
            
            

        }
    }
}
