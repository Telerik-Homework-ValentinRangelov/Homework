using System;

//Write a program that reads a string, reverses it and prints the result at the console.
    class Program
    {
        static string ReverseString(string givenString)
        {
            string reversedString = string.Empty;
            for (int i = givenString.Length-1; i >= 0; i--)
            {
                reversedString += givenString[i];
            }
            return reversedString;
        }
        static void Main()
        {
            Console.WriteLine("Please enter your string which is going to be reversed:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Your reversed string:");
            Console.WriteLine(ReverseString(inputString));
            
        }
    }

