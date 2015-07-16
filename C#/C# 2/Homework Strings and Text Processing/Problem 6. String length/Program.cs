using System;
    //Write a program that reads from the console a string of maximum 20 characters. 
    //If the length of the string is less than 20, the rest of the characters should be filled with *.
    //Print the result string into the console.

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            while (text.Length > 20)
            {
                Console.WriteLine("The string cannot be more than 20 characters, please enter your text again:");
                text = Console.ReadLine();
            }
            if (text.Length<20)
            {
                int starsLenght = 20 - text.Length;
                string stars = new string('*', starsLenght);
                text += stars;
            }
            Console.WriteLine(text);
        }
    }
