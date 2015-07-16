using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int rectangleWidth;
            int  rectangleHeight;
            Console.WriteLine("Please enter the height of the rectangle:");
            rectangleHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle:");
            rectangleWidth = int.Parse(Console.ReadLine());
            double rectanglePerimeter = ((rectangleWidth * 2) + (rectangleHeight * 2));
            double rectangleArea = (rectangleHeight * rectangleWidth);
            Console.WriteLine("The rectangle perimeter is :"+rectanglePerimeter);
            Console.WriteLine("The rectangle area is :" + rectangleArea);

        }
    }
}
