using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Quadratic_Equation
{
    class Program
    {
        /*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
         * (prints its real roots).*/
        static void Main(string[] args)
        {
            
            Console.WriteLine("Quadratic equation ( ax^2+bx+c=0 )");
            Console.WriteLine("Please enter the value of 'a':");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of 'b':");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of 'c':");
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - 4 * a * c;
            double xOneRealRoot = -b / 2 * a;
            double x1 = (-b + (Math.Sqrt(discriminant))) / (2 * a);
            double x2 = (-b - (Math.Sqrt(discriminant))) / (2 * a);

            Console.WriteLine("The discriminant ( (b^2)-4*a*c ) = {0}",discriminant);

            if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots.");

            }
            else
            {
                if(discriminant==0)
                {
                    Console.WriteLine("There is one real root:");
                    Console.WriteLine("x={0}",xOneRealRoot);
                }
                else
                {
                    Console.WriteLine("There are two real roots:");
                    Console.WriteLine("x1 ={0} ",x1);
                    Console.WriteLine("x2 ={0} ",x2);

                }

            }
           
        }
    }
}
