using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixHomework
{
    public class CurrentDirection
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CurrentDirection(int startX,int startY)
        {
            X = startX;
            Y = startY;
        }
    }
}
