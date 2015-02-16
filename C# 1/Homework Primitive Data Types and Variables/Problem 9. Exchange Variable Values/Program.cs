using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("After exchangeing A with B");
            b = a;
            a = b * 2;
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            
        }
    }
}
