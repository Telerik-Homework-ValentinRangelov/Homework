using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Third_Digit_is_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Lets check if the third digit from right to left is 7.");
            Console.WriteLine("Please enter the number");
            number = int.Parse(Console.ReadLine());
            int calculation = (number / 100) % 10;
            bool isItSeven = calculation == 7;
            if (isItSeven)
            {
                Console.WriteLine("The third digit from right to left is 7.");
            }
            else
            {
                Console.WriteLine("The third digit from right to left is not 7.");
            }
        }
    }
}
