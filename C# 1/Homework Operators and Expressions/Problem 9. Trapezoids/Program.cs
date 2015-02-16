using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sideA;
            decimal sideB;
            decimal height;
            Console.WriteLine("Lets calculate  trapezoid's area.");
            Console.WriteLine("Enter the first side.");
            sideA = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side.");
            sideB = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Well done.Now enter the height:");
            height = decimal.Parse(Console.ReadLine());
            decimal trapezoidArea = ((sideA + sideB) / 2) * height;
            Console.WriteLine("The area of the trapezoid is "+ trapezoidArea);






        }
    }
}
