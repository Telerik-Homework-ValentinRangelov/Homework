using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11._starred_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Problem 11.* Numbers in Interval Dividable by Given Number
             * 
             Write a program that reads two positive integer numbers and prints
             * how many numbers p exist between them such that the reminder of the division by 5 is 0.*/
            Console.WriteLine("Please enter your first positive number: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second positive number: ");            
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            for (long i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} existing numbers that are devided by 5 with reminder 0.",count);
        }
    }
}
