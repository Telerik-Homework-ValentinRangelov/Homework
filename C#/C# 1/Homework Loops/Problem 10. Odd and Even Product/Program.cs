using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;

            for (int index = 0; index < array.Length; index++)
            {
                int number = int.Parse(array[index]);
                if (index % 2 == 0 || index == 0)
                {
                    oddProduct *= number;
                }
                else
                {
                    evenProduct *= number;
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd procuct = {0}", oddProduct);
                Console.WriteLine("even procuct = {0}", evenProduct);
            }         
        }
    }
}
