using System;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(DateTime.IsLeapYear(year));

    }
}
