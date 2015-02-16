using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	Write a program that creates an array containing all letters from the alphabet (A-Z).
•	Read a word from the console and print the index of each of its letters in the array.

            */
            char[] alphabetArr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string enterWord = Console.ReadLine();
            char[] wordToCharArray = enterWord.ToCharArray();
            foreach (var theChar in wordToCharArray)
            {
                int index = Array.BinarySearch(alphabetArr, theChar);
                Console.WriteLine("{0} -----> Index:{1}",theChar,index);
            }


        }
    }
}
