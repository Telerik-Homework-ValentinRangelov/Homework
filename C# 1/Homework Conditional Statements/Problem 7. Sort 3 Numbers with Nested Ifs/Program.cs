using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sort_3_Numbers_with_Nested_Ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.*/
            int a, b, c;
            Console.WriteLine("Enter your first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number:");
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("{0} {1} {2}",a,b,c);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);

                    }
                }
                else
                {
                
                     Console.WriteLine("{0} {1} {2}",c ,a ,b);

                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine("{0} {1} {2}", b, a, c);

                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", b, c, a);

                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);

                }
            }

        }
    }
}
