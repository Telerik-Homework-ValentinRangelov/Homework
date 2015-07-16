using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Print_the_ASCII__Starred_
{
    class Program
    {
        static void Main(string[] args)
        {
 
        Console.OutputEncoding = System.Text.Encoding.UTF8;
 
       
        for (char c = (char)033; c <= (char)255; c++)
        {
            Console.WriteLine(c);
        }
 

        }
    }
}
