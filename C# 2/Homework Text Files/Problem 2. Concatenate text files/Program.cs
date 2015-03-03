using System;
using System.IO;
//Write a program that concatenates two text files into another text file.
class Program
{
    static void Main()
    {
        StreamReader first = new StreamReader(@"first.txt");
        StreamReader second = new StreamReader(@"second.txt");
        StreamWriter both = new StreamWriter(@"both.txt");
        string firstString;
        string secondString;
        using (first)
        {
            firstString = first.ReadToEnd();
        }
        using (second)
        {
            secondString = second.ReadToEnd();
        }
        using (both)
        {
            both.WriteLine(firstString);
            both.WriteLine(secondString);
        }








    }
}
