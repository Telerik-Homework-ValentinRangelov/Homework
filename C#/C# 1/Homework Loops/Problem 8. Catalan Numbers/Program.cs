using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Catalan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            if (num > 0 && num < 31)
            {
                long numerator = 1;
                long denominator = 1;
                long result = 1;

                for (int k = 2; k <= num; k++)
                {
                    numerator *= (num + k);
                    if (numerator % k == 0)
                    {
                        numerator /= k;
                    }
                    else
                    {
                        denominator *= k;
                    }
                }
                result = numerator / denominator;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("out of range");
            }     
        }
    }
}
