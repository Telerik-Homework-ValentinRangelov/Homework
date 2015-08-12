using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixHomework
{
    public class Matrix
    {
        private int[,] map;
        public Matrix(int colsPerRows)
        {
            if (colsPerRows < 1)
            {
                throw new Exception("Cols and Rows cannot be under 1!");
            }
            Map = new int[colsPerRows, colsPerRows];
        }
        
        public int[,] Map
        {
            get { return map; }
            set
            {
                map = value;
            }
        }

    }
}
