using System;
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
class Program
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine("We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.");
        Console.WriteLine();
        string subString = "in";
        int index = text.IndexOf(subString);
        int count = 0;
        while (index != -1)
        {
            Console.WriteLine("{0} found at index {1}", subString, index);
            index = text.IndexOf(subString, index + 1);
            count++;
        }
        Console.WriteLine("Found {0} times",count);
    }
}

