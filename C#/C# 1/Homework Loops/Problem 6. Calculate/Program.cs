using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.*/
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (1 < k && k < n && n < 100)
            {
                ulong resuult = 1;
                for (int index = k + 1; index <= n; index++)
                {
                    resuult *= (ulong)index;
                }
                Console.WriteLine(resuult);
            }
            else
            {
                Console.WriteLine("out of range");
            }
        }
    }
}
