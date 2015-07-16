using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Check_for_a_Play_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
             * Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. */
            string card;
            Console.WriteLine("Enter card sign:(Please make difference between ex.:(J and j, A and a, etc..))");
            card = Console.ReadLine();
            Console.WriteLine("Valid card sign:");
            switch (card)
            {
                case "2": Console.WriteLine("Yes");break;
                case "3": Console.WriteLine("Yes"); break;
                case "4": Console.WriteLine("Yes"); break;
                case "5": Console.WriteLine("Yes"); break;
                case "6": Console.WriteLine("Yes"); break;
                case "7": Console.WriteLine("Yes"); break;
                case "8": Console.WriteLine("Yes"); break;
                case "9": Console.WriteLine("Yes"); break;
                case "10": Console.WriteLine("Yes"); break;
                case "J": Console.WriteLine("Yes"); break;
                case "Q": Console.WriteLine("Yes"); break;
                case "K": Console.WriteLine("Yes"); break;
                case "A": Console.WriteLine("Yes"); break;
                default: Console.WriteLine("No,there is not such a sign for the classical playing cards."); break;



            }

        }
    }
}
