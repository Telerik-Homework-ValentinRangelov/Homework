using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6_Maximal_K_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/
            int sum=0;
            Console.WriteLine("How much elements do you want to have the array:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("How much elements do you want to sum:");
            int k = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];
            Console.WriteLine("Enter your {0} elements (each on new line):");
            for (int i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(intArray);
            Console.WriteLine("The maximum sum from {0} elements is :",k);
            for (int i = n-1; i > n-1-k; i--)
            {
                sum += intArray[i];
                if (i == n - k)
                {
                 Console.Write(intArray[i] + " = "+ sum);
                
                }
                else
                {
                Console.Write(intArray[i]+" + ");
                }
            }
            Console.WriteLine();
        }
    }
}
