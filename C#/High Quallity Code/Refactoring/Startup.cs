using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixHomework
{
    public class Startup
    {
        static void Main(string[] args)
        {
            //Console.WriteLine( "Enter a positive number " );
            //string input = Console.ReadLine(  );
            //int n = 0;
            //while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
            //{
            //    Console.WriteLine( "You haven't entered a correct positive number" );
            //    input = Console.ReadLine(  );
            //}
            int colsPerRows = 5;
            Matrix matrix = new Matrix(colsPerRows);
            Position currentPosition = new Position(0, 0);
            Direction currentDirection = new Direction(1, 1);
            MatrixExtensions.BuildMatrix(matrix,currentPosition,currentDirection);
            MatrixExtensions.PrintResultInConsole(matrix);
            MatrixExtensions.FindCell(matrix, currentPosition);
            
          
        }
    }
}
