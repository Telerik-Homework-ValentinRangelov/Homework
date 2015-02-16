using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads the radius r of a circle and prints its perimeter and area 
             * formatted with 2 digits after the decimal point.*/
            double circleRadius;
            Console.WriteLine("Please enter the radius of the circle:");
            circleRadius = double.Parse(Console.ReadLine());
            double circlePerimeter = circleRadius * 2 * Math.PI;
            double circleArea = circleRadius * circleRadius * Math.PI;
            Console.WriteLine("The perimeter of the circle is {0} * 2 * 3,14 = {1:0.00}",circleRadius,circlePerimeter);
            Console.WriteLine("The area of the circle is {0} * {0} * 3,14 = {1:0.00}",circleRadius, circleArea);


        }
    }
}
