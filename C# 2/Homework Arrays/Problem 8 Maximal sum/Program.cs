using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the sequence of maximal sum in given array.*/
            Console.WriteLine("How much elements in the array do you want to have:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n]; //{ 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            Console.WriteLine("Enter your {0} values:",n+" (Each on new line)");
            for (int k = 0; k < n; k++)
            {
                Console.Write("Index[{0}]:", k);
                arr[k] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int maxSum = int.MinValue;
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;
            int fourthNum = 0;

            for (int i = 0; i < arr.Length-3; i++)
            {
                sum = arr[i] + arr[i + 1] + arr[i +2] + arr[i + 3];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    firstNum = arr[i];
                    secondNum = arr[i+1];
                    thirdNum = arr[i+2];
                    fourthNum = arr[i+3];

                }
                
            }
            Console.WriteLine("The max sum is: {0} + {1} + {2} + {3} = {4}",firstNum,secondNum,thirdNum,fourthNum,sum);

        }
    }
}
