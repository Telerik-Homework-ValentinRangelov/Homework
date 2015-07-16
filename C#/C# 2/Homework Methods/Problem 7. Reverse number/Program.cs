using System;

class Program
{
    //Write a method that reverses the digits of given decimal number.
    static void ReversingNumbers(int num)
    {
        string reversedNum = null;
        string numLenght = num.ToString();
        for (int i = 0; i < numLenght.Length; i++)
        {
            reversedNum += (num % 10);
            num = num / 10;
        }
        Console.WriteLine(reversedNum);
        
    }
    static void Main()
    {
        Console.WriteLine("Enter a intager number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The reversed number is:");
        ReversingNumbers(number);
    }
}

