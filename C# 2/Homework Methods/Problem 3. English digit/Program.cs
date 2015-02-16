using System;


class Program
{

    //Write a method that returns the last digit of given integer as an English word.
    static void PrintLastDigitAsWord(int theNumber)
    {
        theNumber = theNumber % 10;
        if (theNumber == 0)
        {
            Console.WriteLine("Last digit is : Zero");
        }
        else if (theNumber == 1)
        {
            Console.WriteLine("Last digit is : One");
        }
        else if (theNumber == 2)
        {
            Console.WriteLine("Last digit is : Two");
        }
        else if (theNumber == 3)
        {
            Console.WriteLine("Last digit is : Three");
        }
        else if (theNumber == 4)
        {
            Console.WriteLine("Last digit is : Four");
        }
        else if (theNumber == 5)
        {
            Console.WriteLine("Last digit is : Five");
        }
        else if (theNumber == 6)
        {
            Console.WriteLine("Last digit is : Six");
        }
        else if (theNumber == 7)
        {
            Console.WriteLine("Last digit is : Seven");
        }
        else if (theNumber == 8)
        {
            Console.WriteLine("Last digit is : Eight");
        }
        else 
        {
            Console.WriteLine("Last digit is : Nine");
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter your digit:");
        int number = int.Parse(Console.ReadLine());
        PrintLastDigitAsWord(number);
    }
}

