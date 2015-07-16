using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the most frequent number in an array.*/
            Console.WriteLine("How much elements in the array do you want to have:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter your {0} values:", n + " (Each on new line)");
            for (int k = 0; k < n; k++)
            {
                Console.Write("Index[{0}]:", k);
                array[k] = int.Parse(Console.ReadLine());
            }
            //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int[] count = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case 0: count[0]++; break;
                    case 1: count[1]++; break;
                    case 2: count[2]++; break;
                    case 3: count[3]++; break;
                    case 4: count[4]++; break;
                    case 5: count[5]++; break;
                    case 6: count[6]++; break;
                    case 7: count[7]++; break;
                    case 8: count[8]++; break;
                    case 9: count[9]++; break;

                }
            }
            int mostRequentNum = int.MinValue;
            int theNumber = int.MinValue;
            for (int j = 0; j < 10; j++)
            {
                if (mostRequentNum < count[j])
                {
                    mostRequentNum = count[j];
                    theNumber = j;
                }
            }
            Console.WriteLine("{0}({1} times)",theNumber,mostRequentNum);


        }
    }
}
