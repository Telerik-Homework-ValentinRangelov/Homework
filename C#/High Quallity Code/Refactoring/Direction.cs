using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixHomework
{
    public class Direction
    {

        private int x;
        private int y;
        public Direction(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }
        public int X
        {
            get { return x; }
            set
            {
                TestIfTheValuesAreValid(value);
                x = value;
                ;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                TestIfTheValuesAreValid(value);
                y = value;
            }
        }

        private void TestIfTheValuesAreValid(int value)
        {
            if (value < -1 || value > 1)
            {
                throw new Exception("Bad values for Direction x and y!");
            }

        }
    }
}
