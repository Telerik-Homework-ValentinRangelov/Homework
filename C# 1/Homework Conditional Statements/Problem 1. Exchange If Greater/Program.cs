using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater 
             * than the second one. As a result print the values a and b, separated by a space.*/
            double a;
            double b;
            double thirdInt;
            Console.WriteLine("Please enter your first digit:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second digit:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("First digit:{0}, Second digit:{1}",a,b);
            if (a > b) ;
            {
                thirdInt = b;
                b = a;
                a = thirdInt;

            }
            Console.WriteLine(a+" "+b);

        }
    }
}
