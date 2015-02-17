using System;
//Write a program to convert binary numbers to their decimal representation.
class Program
{
    static long BinaryToDecimal(string binaryNumber)
    {
        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int digit = binaryNumber[i] == '1' ? 1 : 0;
            int position = binaryNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(2, position);

        }
        return decimalNumber;
    }
    static void Main()
    {
        Console.Write("Please enter your binary number:");
        string number = Console.ReadLine();
        Console.WriteLine(BinaryToDecimal(number));
    }

}

