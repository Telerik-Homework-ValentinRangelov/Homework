using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Random_Numbers_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/
            int count = int.Parse(Console.ReadLine());
            int minInt = int.Parse(Console.ReadLine());
            int maxInt = int.Parse(Console.ReadLine());
            if (minInt <= maxInt)
            {
                Random random = new Random();
                for (int index = 0; index < count; index++)
                {
                    Console.Write("{0} ", random.Next(minInt, maxInt + 1));
                }
            }
            else
            {
                Console.WriteLine("incorrect input");
            }    
        }
    }
}
