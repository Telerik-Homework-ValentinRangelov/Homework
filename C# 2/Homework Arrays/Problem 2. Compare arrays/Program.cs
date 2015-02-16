using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two integer arrays from the console and compares them element by element.*/
            int[] firstArray = new int[4];
            int[] secondArray = new int[4];
            Console.WriteLine("Please enter the 4 values of the first array(each value on new line):");
            for (int i = 0; i < 4; i++)
            {

                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the 4 values of the second array(each value on new line):");

            for (int i = 0; i < 4; i++)
            {

                secondArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Comparing the elements from the arrays:");

            for (int i = 0; i < 4; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("index {0} from the arrays are equal. {1} and {2} . ",i,firstArray[i],secondArray[i]);
                }
                else
                {
                    Console.WriteLine("index {0} from the arrays are not equal. {1} and {2} . ", i,firstArray[i],secondArray[i]);
                }
            }
        }
    }
}
