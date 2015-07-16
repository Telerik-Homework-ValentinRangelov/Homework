using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Allocate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.*/
            int[] arrayOfInt = new int[20];
            for (int i = 0; i < arrayOfInt.Length; i++)
            {
                arrayOfInt[i] = i * 5;
                Console.WriteLine(arrayOfInt[i]);
            }
        }
    }
}
