using System;


class Program
{
    //       Write a method GetMax() with two parameters that returns the larger of two integers.
    //       Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
    static int GetMax(int firstNumber, int secondNumer)
    {
        int biggestInt = firstNumber;
        if (firstNumber < secondNumer)
        {
            biggestInt = secondNumer;
        }
        return biggestInt;
    }
    static void Main()
    {
        Console.Write("First intager:");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Second intager:");
        int secondInt = int.Parse(Console.ReadLine());
        Console.Write("Third intager:");
        int thirdInt = int.Parse(Console.ReadLine());
        Console.WriteLine("Biggest number is:{0}", GetMax(GetMax(firstInt, secondInt), thirdInt));


    }
}

