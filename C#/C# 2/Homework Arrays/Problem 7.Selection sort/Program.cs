using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
            Use the Selection sort algorithm: Find the smallest element, move it at the first position,
             * find the smallest from the rest, move it at the second position, etc.*/
            int element = int.MinValue;
            int index = int.MinValue;
            Console.WriteLine("Enter how much elements do you want to have in the array:");
            int numberOfElementsInArray = int.Parse(Console.ReadLine());
            int[] array = new int[numberOfElementsInArray];
            Console.WriteLine("Enter your elements:");
            for (int i = 0; i < numberOfElementsInArray; i++)
            {
                Console.Write("Index[{0}]:", i);
                array[i] = int.Parse(Console.ReadLine());

            }

            int minValue = int.MaxValue;

            for (int i = 0; i < numberOfElementsInArray; i++)
            {
                 minValue = int.MaxValue;
                for (int j = i + 1; j < numberOfElementsInArray; j++)
                {
                    if (minValue > array[j])
                    {
                        minValue = array[j];
                        index = j;
                    }
                }
                element = array[i];
                array[i] = minValue;
                array[index] = element;
                
            }
            for (int ConsoleWrite = 0; ConsoleWrite < numberOfElementsInArray; ConsoleWrite++)
            {
                Console.WriteLine("Index[{0}]:{1}", ConsoleWrite, array[ConsoleWrite]);
            }





        }
    }
}
