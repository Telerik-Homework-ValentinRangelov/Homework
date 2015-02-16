using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Odd_or_Even_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueTwo = 2;
            int A = 5;
            int B = 9;
            int C = 11;
            int D = 20;
            //Purvoto chislo
            bool EvenA = (A % valueTwo == 0);
            if (EvenA)
            {
                Console.WriteLine("First integer = 5 = Even");
            }
            else
            {

                Console.WriteLine("First integer = 5 = Odd");
            }
            //Vtoroto chislo



            bool EvenB = (B % valueTwo == 0);
            if (EvenB)
            {
                Console.WriteLine("Second integer = 9 = Even");
            }
            else
            {

                Console.WriteLine("Second integer = 9 = Odd");
            }

            //Tretoto chislo



            bool EvenC = (C % valueTwo == 0);
            if (EvenC)
            {
                Console.WriteLine("Third integer = 11 = Even");
            }
            else
            {

                Console.WriteLine("Third integer = 11 = Odd");
            }
            //Chetvurtoto chislo



            bool EvenD = (D % valueTwo == 0);
            if (EvenD)
            {
                Console.WriteLine("Fourth integer = 20 = Even");
            }
            else
            {

                Console.WriteLine("Fourth integer = 20 = Odd");
            }

        }
        }

}
