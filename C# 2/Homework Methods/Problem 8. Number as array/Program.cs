using System;


class Program
{
    //      Write a method that adds two positive longeger numbers represented as arrays of digits 
    //      (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    //      Each of the numbers that will be added could have up to 10 000 digits.
    static void NumbersAsArray(long firstNum, long secondNum)
    {
        string firstNumString = firstNum.ToString();
        string secondNumString = secondNum.ToString();
        long[] firstNumberArray = new long[firstNumString.Length];
        long[] secondNumberArray = new long[secondNumString.Length];
        //First number as array with last digit at zero position.
        bool lastDigitAtZeroPosition = true;
        for (long i = firstNumString.Length; i > 0; i--)
        {
            if (lastDigitAtZeroPosition)
            {
                firstNumberArray[0] = firstNum % 10;
                firstNum = firstNum / 10;
                lastDigitAtZeroPosition = false;
                continue;
            }
            firstNumberArray[i] = firstNum % 10;
            firstNum = firstNum / 10;
        }
        //Prlonging the array of first num
        Console.WriteLine("First array:");
        for (long k = 0; k < firstNumString.Length; k++)
        {
            Console.Write(firstNumberArray[k] + " ");
        }
        Console.WriteLine();
        //Second number as array with last digit at zero position.
        lastDigitAtZeroPosition = true;
        for (long i = secondNumString.Length; i > 0; i--)
        {
            if (lastDigitAtZeroPosition)
            {
                secondNumberArray[0] = secondNum % 10;
                secondNum = secondNum / 10;
                lastDigitAtZeroPosition = false;
                continue;
            }
            secondNumberArray[i] = secondNum % 10;
            secondNum = secondNum / 10;
        }
        //Prlonging the array of second num
        Console.WriteLine("Second array:");
        for (long k = 0; k < secondNumString.Length; k++)
        {
            Console.Write(secondNumberArray[k] + " ");
        }
        Console.WriteLine();

    }
    static void Main()
    {
        Console.Write("First number:");
        long firstNumber = long.Parse(Console.ReadLine());
        Console.Write("Second number:");
        long secondNumber = long.Parse(Console.ReadLine());
        NumbersAsArray(firstNumber, secondNumber);
    }
}

