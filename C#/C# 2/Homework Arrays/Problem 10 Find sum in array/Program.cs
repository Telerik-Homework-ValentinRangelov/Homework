using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10_Find_sum_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds in given array of integers a sequence of given sum S (if present).*/
            Console.WriteLine("How much elements in the array do you want to have:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter your {0} values:", n + " (Each on new line)");
            for (int k = 0; k < n; k++)
            {
                Console.Write("Index[{0}]:", k);
                array[k] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("What sum do u want to find?");
            int sum = int.Parse(Console.ReadLine());
            for (int i = 1; i < n-1; i++)
            {
                if (sum - array[i - 1] - array[i] - array[i + 1] == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}",array[i-1],array[i],array[i+1],sum);
                }
                else
                {
                    Console.WriteLine("Theres no such a sum");
                }
            }
        }
    }
}
