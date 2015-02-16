using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            bool isInside = (x * x) + (y * y) <= (2 * 2);

            Console.WriteLine("These coordinates are inside the circle = " + isInside);

        }
    }
}
