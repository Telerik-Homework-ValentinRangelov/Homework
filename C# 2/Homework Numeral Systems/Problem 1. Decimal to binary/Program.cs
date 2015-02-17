using System;
//Write a program to convert decimal numbers to their binary representation.

class Program
{
    static string ConvertDecimalToBinary(long decimalNum)
    {
        string binaryNumber = "";
        while (decimalNum > 0)
        {
            binaryNumber += decimalNum % 2;
            decimalNum = decimalNum / 2;
        }
        var numberAsCharArray = binaryNumber.ToCharArray();
        Array.Reverse(numberAsCharArray);
        binaryNumber = new string(numberAsCharArray);

        return binaryNumber;
    }
    static void Main()
    {
        Console.Write("Please enter your decimal number:");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("Binary number: {0}", ConvertDecimalToBinary(number));
    }
}

