using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Null_Values_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? intNull = null;
            double? doubleNull = null;
            Console.WriteLine("The int value is: "+intNull);
            Console.WriteLine("The double value is: "+doubleNull);
            Console.WriteLine("After adding numbers to the variables:");
            intNull = 10;
            doubleNull = 20;
            Console.WriteLine("Now the value of the variables are:");
            Console.WriteLine("The int value is:" + intNull);
            Console.WriteLine("The double value is:" + doubleNull);

        }
    }
}
