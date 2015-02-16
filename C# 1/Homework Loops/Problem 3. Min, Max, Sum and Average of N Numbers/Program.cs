using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Min__Max__Sum_and_Average_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/
            int number;
            int minNumber=0;
            int maxNumber=0;
            int sum = 0;
            decimal avarage=0;
            int numberOfDigits = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfDigits ; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (sum == 0)
                {
                    minNumber = number;
                }
                sum = sum + number;
                avarage = sum /(decimal) numberOfDigits;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine("MinNumber = {0}",minNumber);
            Console.WriteLine("MaxNumber = {0}", maxNumber);
            Console.WriteLine("Sum= {0}", sum);
            Console.WriteLine("Avarage= {0: 0.00}", avarage);



        }
    }
}
