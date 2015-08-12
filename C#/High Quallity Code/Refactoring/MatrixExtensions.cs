using System;

namespace MatrixHomework
{
    public class MatrixExtensions
    {
        public static void ChangeDirection(Direction currentDirection)
        {
            TestIfValueIsNull(currentDirection);
            DirectionsTemplate directions = new DirectionsTemplate();
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


        public static bool TestPassed(Matrix matrix, Position currentPosition)
        {
            TestIfValueIsNull(matrix, currentPosition);
            var arr = matrix.Map;
            
            DirectionsTemplate directions = new DirectionsTemplate();

            for (int i = 0; i < 8; i++)
            {
                if (currentPosition.X + directions.X[i] >= arr.GetLength(0) || currentPosition.X + directions.X[i] < 0)
                {
                    directions.X[i] = 0;
                }

                if (currentPosition.Y + directions.Y[i] >= arr.GetLength(0) || currentPosition.Y + directions.Y[i] < 0)
                {
                    directions.Y[i] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (arr[currentPosition.X + directions.X[i], currentPosition.Y + directions.Y[i]] == 0)
                {
                    return true;
                }

            }
            return false;
        }

        public static void FindCell(Matrix matrix, Position currentPosition)
        {
            TestIfValueIsNull(matrix, currentPosition);
            var arr = matrix.Map;
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
            TestIfValueIsNull(matrix);
            double colsPerRows = Math.Sqrt(matrix.Map.Length);
            for (int p = 0; p < colsPerRows; p++)
            {
                for (int q = 0; q < colsPerRows; q++)
                {
                    Console.Write("{0,3}", matrix.Map[p, q]);
                }

                Console.WriteLine();
            }
        }

        public static void BuildMatrix(Matrix matrix,Position currentPosition,Direction currentDirection)
        {
            TestIfValueIsNull(matrix,currentPosition,currentDirection);
            double colsPerRows = Math.Sqrt(matrix.Map.Length);
            int stepCount = 1;
            while (true)
            {
                matrix.Map[currentPosition.X, currentPosition.Y] = stepCount;
                if (!TestPassed(matrix, currentPosition))
                {
                    break;
                }

                while ((currentPosition.X + currentDirection.X >= colsPerRows || currentPosition.X + currentDirection.X < 0 || currentPosition.Y + currentDirection.Y >= colsPerRows || currentPosition.Y + currentDirection.Y < 0 || matrix.Map[currentPosition.X + currentDirection.X, currentPosition.Y + currentDirection.Y] != 0))
                {
                    ChangeDirection(currentDirection);
                }


                currentPosition.X += currentDirection.X;
                currentPosition.Y += currentDirection.Y;
                stepCount++;
            }
        }

        private static void TestIfValueIsNull(params object[] values)
        {
            foreach (var item in values)
            {
                if (item == null)
                {
                    throw new Exception("Value cannot be null!");
                }
            }
            
        }
    }
}
