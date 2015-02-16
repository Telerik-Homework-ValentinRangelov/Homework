using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Numbers_Not_Divisible_by_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that enters from the console a positive integer n
             * and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.*/
            Console.WriteLine("Enter your number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if ((i % 7 == 0) || (i % 3 == 0))
                {
                    continue;
                }   
                Console.Write(i+" ");
            }
        }
    }
}
