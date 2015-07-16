using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the maximal sequence of equal elements in an array.*/
            Console.Write("Enter number of elements: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int maxCount = 0;
            int currentCount = 1;
            int sequenceStart = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    if (arr[i] == arr[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        sequenceStart = i + 1 - maxCount;
                    }
                }
            }

            Console.WriteLine("The maximal sequence of equal elements is: ");
            for (int i = sequenceStart; i < sequenceStart + maxCount; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
