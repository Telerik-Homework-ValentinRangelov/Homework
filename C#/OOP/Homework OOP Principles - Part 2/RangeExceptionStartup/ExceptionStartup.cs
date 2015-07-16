using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Range_Exceptions;
namespace RangeExceptionStartup
{
    class ExceptionStartup
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0 || input > 100)
            {
                throw new InvalidRangeException<int>("Input out of range", 0, 100);
            }
        }
    }
}
