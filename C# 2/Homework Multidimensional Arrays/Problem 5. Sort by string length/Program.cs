using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Sort_by_string_length
{
    class Program
    {
        
        static void Main(string[] args)
        {
        //    You are given an array of strings.
        //   Write a method that sorts the array by the length of its elements (the number of characters composing them).
            Console.Write("How much elements you want in the array of strings:");
            int elementsInArray = int.Parse(Console.ReadLine());
            string[] arr = new string[elementsInArray];
            //Enter the values of the strings
            for (int i = 0; i < elementsInArray; i++)
            {
                Console.Write("Index[{0}]:",i);
                arr[i] = Console.ReadLine();
            }
            //Write all the elements you have enetered
            for (int i = 0; i < elementsInArray; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //Sorting the strings
            Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
            //Printing
            for (int i = 0; i < elementsInArray; i++)
            {
                Console.WriteLine("Array[{0}] = {1}",i,arr[i]);
            }

        }
    }
}
