using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Size
    {
        public double width, height;
        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angelForRotating)
        {
            var rotatedSize = new Size(
                Math.Abs(Math.Cos(angelForRotating)) * size.width +
                    Math.Abs(Math.Sin(angelForRotating)) * size.height,
                Math.Abs(Math.Sin(angelForRotating)) * size.width +
                    Math.Abs(Math.Cos(angelForRotating)) * size.height);

            return rotatedSize;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var firstSize = new Size(5, 6);
            var rotatedFirstSize =Size.GetRotatedSize(firstSize, 90);

            Console.WriteLine("Before rotating");
            Console.WriteLine("---------------------------");
            Console.WriteLine(firstSize.height);
            Console.WriteLine(firstSize.width);
            Console.WriteLine("                     ");
            Console.WriteLine("After rotating");
            Console.WriteLine("---------------------------");
            Console.WriteLine(rotatedFirstSize.height);
            Console.WriteLine(rotatedFirstSize.width);
            Console.WriteLine("                     ");

        }
    }
}
