using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Check_a_Bit_at_Given_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                byte mask = 1 << 3;
                uint haystack;
                Console.WriteLine("Please, enter unsigned integer:");
                while (!uint.TryParse(Console.ReadLine(), out haystack))
                {
                    Console.WriteLine("Please, enter correct integer.");
                }
                uint result = mask & haystack;
                Console.WriteLine("\n#3 bit is {0}", result >> 3);
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
