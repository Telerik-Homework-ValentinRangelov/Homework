using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloStringValue = "Hello";
            string worldStringValue = "World";
            object firstAndSecondStrings = helloStringValue +" "+ worldStringValue;
            string thirdStringValue = (string)firstAndSecondStrings;
            Console.WriteLine("First string is: "+helloStringValue);
            Console.WriteLine("Second string is: "+worldStringValue);
            Console.WriteLine("First + Second string = "+firstAndSecondStrings+"(Object)");
            Console.WriteLine("Third string : "+thirdStringValue+"(String)");
        }

    }
}
