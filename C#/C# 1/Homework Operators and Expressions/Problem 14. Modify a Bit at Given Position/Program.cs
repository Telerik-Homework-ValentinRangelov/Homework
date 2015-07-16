using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Modify_a_Bit_at_Given_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int haystack;
            int position;
            int setTo;

            Console.WriteLine("Please, enter unsigned integer:");
            while (!int.TryParse(Console.ReadLine(), out haystack))
            {
                Console.WriteLine("Please, enter correct integer.");
            }
            Console.WriteLine("Please, set the bit position you are interested in:");
            while (!int.TryParse(Console.ReadLine(), out position))
            {
                Console.WriteLine("Please, enter correct integer.");
            }
            Console.WriteLine("Provide the bit value you like to be set:");
            while (!int.TryParse(Console.ReadLine(), out setTo) && (setTo != 0 || setTo != 1))
            {
                Console.WriteLine("Please, enter correct integer.");
            }
            int mask = 1;

            bool boolResult = (haystack & (1 << position)) != 0;
            //Console.WriteLine(boolResult);

            if ((setTo == 1 && boolResult) || (setTo == 0 && !boolResult))
            {
                Console.WriteLine(haystack);
            }
            else if ((setTo == 1 && !boolResult) || (setTo == 0 && boolResult))
            {
                Console.WriteLine(haystack ^ (mask << position));
            }

            Console.ReadKey();
        }
    }
}
