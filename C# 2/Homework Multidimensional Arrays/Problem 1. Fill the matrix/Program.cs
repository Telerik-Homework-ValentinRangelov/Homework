
using System;

namespace Problem01FillTheMatrix
{
    class FillTheMatrix
    {

        static int number = 1;

        static void Spiral(int[,] matrix, int row, int col, int n)
        {
            if (number >= n * n)
            {
                return;
            }
            else
            {
                // down
                while ((row < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row++;
                    number++;
                }
                row--;
                col++;
                // left
                while ((col < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col++;
                    number++;
                }
                col--;
                row--;
                // up
                while ((row >= 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row--;
                    number++;
                }
                row++;
                col--;
                // left
                while ((col > 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col--;
                    number++;
                }

                if (matrix[row, col] != 0)
                {
                    row++;
                    col++;
                    Spiral(matrix, row, col, n);
                }
            }
        }

        static void DisplayArray(int[,] arr, int n)
        {
            for (int i = 0; i < Math.Sqrt(arr.Length); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Math.Sqrt(arr.Length); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
        }
        static void Main()
        {
            // Enter array length
            Console.WriteLine("N = ");
            int n = int.Parse(Console.ReadLine());

            // Declare array
            int[,] array = new int[n, n];

            // Fill in variant a)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[j, i] = j + 1 + (n * i);
                }
            }

            // display variant a)
            DisplayArray(array, n);

            Console.WriteLine();

            // Fill in variant b)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i % 2) == 0)
                    {
                        array[j, i] = j + 1 + (n * i);
                    }
                    else
                    {
                        array[n - j - 1, i] = j + 1 + (n * i);
                    }
                }
            }

            // display variant b)
            DisplayArray(array, n);

            Console.WriteLine();

            int row = n - 1, col = 0, data = 0;
            // Fill in variant c)
            for (int i = 0; i < n; i++)
            {
                do
                {
                    data++;
                    if (row < 0) row = 0;
                    array[row, col] = data;
                    row++;
                    col++;
                } while (row < n);

                row -= col + 1;
                col = 0;
            }

            row = 0;
            col = 1;
            for (int i = 0; i < n - 1; i++)
            {
                do
                {
                    data++;
                    array[row, col] = data;
                    row++;
                    col++;
                } while (col < n);

                col -= row - 1;
                row = 0;
            }

            // display variant c)
            DisplayArray(array, n);

            Console.WriteLine();

            // fill in variant d)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[j, i] = 0;
                }
            }

            Spiral(array, 0, 0, n);

            // display variant d)
            DisplayArray(array, n);

        }
    }
}