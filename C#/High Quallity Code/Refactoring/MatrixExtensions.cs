using System;

namespace MatrixHomework
{
    public class MatrixExtensions
    {
        public static void ChangeDirection(CurrentDirection currentDirection)
        {
            Directions directions = new Directions();
            int currentCount = 0;
            for (int count = 0; count < 8; count++)
            {
                if (directions.X[count] == currentDirection.X && directions.Y[count] == currentDirection.Y)
                {
                    currentCount = count;
                    break;
                }
            }

            if (currentCount == 7)
            {
                currentDirection.X = directions.X[0];
                currentDirection.Y = directions.Y[0];
                return;
            }
            currentDirection.X = directions.X[currentCount + 1];
            currentDirection.Y = directions.Y[currentCount + 1];
        }


        public static bool TestPassed(int[,] arr, int x, int y)
        {
            Directions directions = new Directions();

            for (int i = 0; i < 8; i++)
            {
                if (x + directions.X[i] >= arr.GetLength(0) || x + directions.X[i] < 0)
                {
                    directions.X[i] = 0;
                }

                if (y + directions.Y[i] >= arr.GetLength(0) || y + directions.Y[i] < 0)
                {
                    directions.Y[i] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (arr[x + directions.X[i], y + directions.Y[i]] == 0)
                {
                    return true;
                }

            }
            return false;
        }

        public static void FindCell(int[,] arr, CurrentPosition currentPosition)
        {
            currentPosition.X = 0;
            currentPosition.Y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        currentPosition.X = i;
                        currentPosition.Y = j;
                        return;
                    }
                }
            }
        }

        public static void PrintResultInConsole(Matrix matrix)
        {
            double colsPerRows = Math.Sqrt(matrix.map.Length);
            for (int p = 0; p < colsPerRows; p++)
            {
                for (int q = 0; q < colsPerRows; q++)
                {
                    Console.Write("{0,3}", matrix.map[p, q]);
                }

                Console.WriteLine();
            }
        }

        public static void BuildMatrix(Matrix matrix,CurrentPosition currentPosition,CurrentDirection currentDirection)
        {
            double colsPerRows = Math.Sqrt(matrix.map.Length);
            int stepCount = 1;
            while (true)
            {
                matrix.map[currentPosition.X, currentPosition.Y] = stepCount;
                if (!TestPassed(matrix.map, currentPosition.X, currentPosition.Y))
                {
                    break;
                }

                while ((currentPosition.X + currentDirection.X >= colsPerRows || currentPosition.X + currentDirection.X < 0 || currentPosition.Y + currentDirection.Y >= colsPerRows || currentPosition.Y + currentDirection.Y < 0 || matrix.map[currentPosition.X + currentDirection.X, currentPosition.Y + currentDirection.Y] != 0))
                {
                    ChangeDirection(currentDirection);
                }


                currentPosition.X += currentDirection.X;
                currentPosition.Y += currentDirection.Y;
                stepCount++;
            }
        }
    }
}
