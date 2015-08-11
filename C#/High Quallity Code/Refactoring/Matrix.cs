using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixHomework
{
    public class Matrix
    {
        public int[,] map;
        public Matrix(int colsPerRows)
        {
            map = new int[colsPerRows, colsPerRows];
        }
    }
}
