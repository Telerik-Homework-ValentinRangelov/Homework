using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.*/
            Console.WriteLine("You have got an array with those elemetns:");
            Console.WriteLine(" 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 ");
            Console.WriteLine("Enter which element's index you wanna find:");
            bool noSuchElement = false;
            int n = int.Parse(Console.ReadLine());
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };



        start:
            for (int i = 0; i < arr.Length; i++)
            {
                noSuchElement = false;
                if (i == arr.Length - 1 && n != arr[i])
                {
                    Console.WriteLine("Theres no such a element, please eneter your element again:");
                    n = int.Parse(Console.ReadLine());
                    noSuchElement = true;
                    break;
                }
                if (n == arr[i])
                {
                    break;
                }

            }
            if (noSuchElement == true)
            {
                goto start;
            }

            int index = Array.BinarySearch(arr, n);
            Console.WriteLine("The index is {0}.", index);
        }
    }
}
