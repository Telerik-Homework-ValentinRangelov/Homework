using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/
            Console.WriteLine("Enter an integer a:");
            int a = int.Parse(Console.ReadLine());
            if (a < 0 || a > 500)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Console.WriteLine("Enter a floating-point b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a floating-point c:");
            double c = double.Parse(Console.ReadLine());
            Console.Write("|{0,-10}", Convert.ToString(a, 16).ToUpper());
            Console.Write("|{0,10}|",
            Convert.ToString(a, 2).PadLeft(10, '0'));
            string str = b.ToString();
            int index = str.IndexOf(".");
            if (index == -1)
            {
                Console.Write("{0,10}|", b);
            }
            else
            {
                Console.Write("{0,10:F2}|", b);
            }
            str = c.ToString();
            index = str.IndexOf(".");
            if (index == -1)
            {
                Console.Write("{0,-10}|", c);
            }
            else
            {
                Console.Write("{0,-10:F3}|", c);
            }
            Console.WriteLine();
        

        }
    }
}
