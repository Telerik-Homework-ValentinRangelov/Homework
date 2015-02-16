using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Binary_search
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Write a program, that reads from the console an array of N integers and an integer K, 
			 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/
			Console.Write("K:");
			int k = int.Parse(Console.ReadLine());
            while (k > 100)
            {
                Console.WriteLine("Please enter number less or equal to 100.");
                Console.Write("New number:");
                k = int.Parse(Console.ReadLine());
            }
			Console.Write("N:");
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];

			//Get random value at every index
			Random randomNum = new Random();
			for (int i = 0; i < n; i++)
			{
				int random = randomNum.Next(100);
				arr[i] = random; 
			}
			
			//Print the unsorted array
			Console.WriteLine("The elements of the unsorted array:");
			for (int i = 0; i < n; i++)
			{
				Console.Write(arr[i] + " ");                
			}
			Console.WriteLine();
            Console.WriteLine();

			//Print the sorted array
			Console.WriteLine("The elements of the sorted array:");
			Array.Sort(arr);
			for (int i = 0; i < n; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
            Console.WriteLine();

            //Check for the number
			Console.WriteLine("The biggest number less or equal to {0} is:",k);
            while (Array.BinarySearch(arr, k) < 0)
            {
                k--;
                if (k < 0)
                {
                    Console.WriteLine("There is no number equal or less.Try again(The numbers are random) :)");
                    break;
                }
            }
            if (k > -1) 
            { 
            Console.Write(k);
            }
            Console.WriteLine();
		}
	}
}
