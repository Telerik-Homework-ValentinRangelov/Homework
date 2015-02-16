using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Print_a_Deck_of_52_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
             * The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
               The card faces should start from 2 to A.
               Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/
            string clubs = "clubs";
            string spades = "spades";
            string hearts = "hearts";
            string diamonds = "diamonds";
            
            for (int from2toA = 2; from2toA <= 13; from2toA++)
            {
                object JQKA = from2toA;
                if (from2toA == 10)
                {
                    JQKA = 'J';
                }
                if (from2toA == 11)
                {
                    JQKA = 'Q';
                }
                if (from2toA == 12)
                {
                    JQKA = 'K';
                }
                if (from2toA == 13)
                {
                    JQKA = 'A';
                }
                
                
                    Console.WriteLine(JQKA + " of " + clubs + ", " + JQKA + " of " + spades + ", " + JQKA + " of " + hearts + ", " + JQKA + " of " + diamonds);
                
            }

        }
    }
}
