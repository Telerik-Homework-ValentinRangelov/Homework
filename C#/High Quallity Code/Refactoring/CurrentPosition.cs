using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixHomework
{
    public class CurrentPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CurrentPosition(int startX,int startY)
        {
            X = startX;
            Y = startY;
        }
    }
}
