using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that compares two char arrays lexicographically (letter by letter).*/
            char[] charArrayOne = new char[5];
            char[] charArrayTwo = new char[5];
            Console.WriteLine("Write the 5 letters from the first char array(Each letter on new line)");
            for (int i = 0; i < charArrayOne.Length; i++)
            {
                charArrayOne[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Write the 5 letters from the second char array(Each letter on new line)");
            for (int i = 0; i < charArrayTwo.Length; i++)
            {
                charArrayTwo[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Comparing arrays letter by letter:");
            for (int i = 0; i < 5; i++)
            {
                if (charArrayOne[i] == charArrayTwo[i])
                {
                    Console.WriteLine( "The index {0} from the both arrays are the same: {1} and {2}. ",i,charArrayOne[i],charArrayTwo[i]);
                }
                else
                {
                    Console.WriteLine("The index {0} from the both arrays are not the same: {1} and {2}. ", i, charArrayOne[i], charArrayTwo[i]);
                }
            }

        }
    }
}
