using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixHomework
{
    public class Position
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                TestIfTheValuesAreValid(value);
                x = value;
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
        
        public Position(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }
        private void TestIfTheValuesAreValid(int value)
        {
            if (value < 0)
            {
                throw new Exception("Bad values for Position x and y!");
            }

        }

    }
}
