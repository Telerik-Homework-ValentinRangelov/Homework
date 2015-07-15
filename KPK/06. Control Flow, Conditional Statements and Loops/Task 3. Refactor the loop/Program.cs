using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_the_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var valueFound = false;
            for (int i = 0; i < 100;i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        valueFound = true;
                        break;
                    }
                }
                Console.WriteLine(array[i]);
                i++;
            }
            // More code here
            if (valueFound)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}
