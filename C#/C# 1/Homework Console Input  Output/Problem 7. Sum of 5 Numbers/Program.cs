using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sum_of_5_Numbers
{      /* Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, write 5 numbers separated by a space: ");
            var numbers = Console.ReadLine().Split().Take(5);
            Double[] digits = numbers.Select(d => Convert.ToDouble(d)).ToArray();
            double sum = digits.Sum();

            Console.WriteLine("The sum is: " + sum);

        }
    }
}
