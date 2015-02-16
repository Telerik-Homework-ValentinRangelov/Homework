using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a rectangular
              matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/
            Console.Write("N:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M:");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];

            //Getting random numbers to the multidimension array
            Random randomNumber = new Random();
            Console.WriteLine("Getting random numbers.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    int random = randomNumber.Next(10);
                    matrix[i, j] = random;
                }
            }
            // matrix[n - 1, m - 1] = 40;
            //Printing the matrix
            Console.WriteLine("The matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
            

            //Finding the maximum sum of the 3x3 elements in the matrix
            int maxSum = int.MinValue;
            int[,] nums = new int[3,3];
            for (int i = 0; i < n-2; i++)
            {
                for (int j = 0; j < m-2; j++)
                {
                    int sum = 0;
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        nums[0, 0] = matrix[i, j];
                        nums[0, 1] = matrix[i, j+1];
                        nums[0, 2] = matrix[i, j+2];
                        nums[1, 0] = matrix[i+1, j];
                        nums[1, 1] = matrix[i+1, j+1];
                        nums[1, 2] = matrix[i+1, j+2];
                        nums[2, 0] = matrix[i+2, j];
                        nums[2, 1] = matrix[i+2, j+1];
                        nums[2, 2] = matrix[i+2, j+2];
                    }
                }
            }

            //Printing the 3x3 elements with max sum
            Console.WriteLine("The maximum sum of the matrix 3x3 is : {0}",maxSum);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(nums[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
