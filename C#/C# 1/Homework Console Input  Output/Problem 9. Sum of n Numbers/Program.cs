using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Sum_of_n_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that enters a number n and after that enters more 
             * n numbers and calculates and prints their sum. Note: You may need to use a for-loop.*/
            long n = long.Parse(Console.ReadLine());
            decimal sum = 0.00m;
            decimal number = decimal.MinValue;
            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum =sum+ number;
            }
            Console.WriteLine(sum);
        }
    }
}
