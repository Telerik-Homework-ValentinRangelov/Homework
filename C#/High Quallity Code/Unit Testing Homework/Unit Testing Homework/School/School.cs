using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private static int uniqueNumber = 10000;

        public static int UniqueNumber
        {
            get { return uniqueNumber; }
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new Exception("Unique number must be between 10000 and 99999!");
                }
                uniqueNumber = value;
            }
        }


    }
}
