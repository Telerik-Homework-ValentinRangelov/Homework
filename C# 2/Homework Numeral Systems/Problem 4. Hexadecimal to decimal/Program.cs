using System;

//Write a program to convert hexadecimal numbers to their decimal representation.
class Program
{
    static long HexToDecimal(string hexadecimal)
    {
        long decimalNumber = 0;

        for (int i = 0; i < hexadecimal.Length; i++)
        {
            int digit = 0;
            if (hexadecimal[i] >= '0' && hexadecimal[i] <= '9')
            {
                digit = hexadecimal[i] - '0';
            }
            else if (hexadecimal[i] >= 'A' && hexadecimal[i] <= 'F')
            {
                digit = hexadecimal[i] - 'A' + 10;
            }
            decimalNumber += digit * (long)Math.Pow(16, hexadecimal.Length - i - 1);
            

        }
        return decimalNumber;
    }
    static void Main()
    {
        Console.Write("Please enter your Hexadecimal number:");
        string number = Console.ReadLine();
        Console.WriteLine(HexToDecimal(number));
    }

}


