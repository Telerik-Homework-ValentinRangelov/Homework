using System;
//Write a program to convert decimal numbers to their hexadecimal representation.

class Program
{
    static string DecimalToHexadecimal(long decimalNumber)
    {
        string hexaDecimal = "";
        string decimalNumberLenght = decimalNumber.ToString();
        for (int i = 0; i < decimalNumberLenght.Length; i++)
        {
            long digit = decimalNumber % 16;
            if (digit >= 1 && digit <= 9)
            {
                digit = decimalNumber % 16;
            }
            else if (digit >= 10 && digit <= 15)
            {
                if (digit == 10)
                {
                    hexaDecimal += 'A';
                    decimalNumber /= 16;
                    continue;
                }
                if (digit == 11)
                {
                    hexaDecimal += 'B';
                    decimalNumber /= 16;
                    continue;
                }
                if (digit == 12)
                {
                    hexaDecimal += 'C';
                    decimalNumber /= 16;
                    continue;
                }
                if (digit == 13)
                {
                    hexaDecimal += 'D';
                    decimalNumber /= 16;
                    continue;
                }
                if (digit == 14)
                {
                    hexaDecimal += 'E';
                    decimalNumber /= 16;
                    continue;
                }
                if (digit == 15)
                {
                    hexaDecimal += 'F';
                    decimalNumber /= 16;
                    continue;
                }
            }
            hexaDecimal += digit;
            decimalNumber /= 16;
        }
        var hexDecimalAsCharArray = hexaDecimal.ToCharArray();
        Array.Reverse(hexDecimalAsCharArray);
        hexaDecimal = new string(hexDecimalAsCharArray);
        return hexaDecimal;
    }
    static void Main()
    {
        Console.Write("Please enter your decimal number:");
        long decimalNumber = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToHexadecimal(decimalNumber));
    }
}

