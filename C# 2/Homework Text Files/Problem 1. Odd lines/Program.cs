using System;
using System.IO;
//Write a program that reads a text file and prints on the console its odd lines.

class Program
{
    static void Main()
    {
        StreamReader sw = new StreamReader(@"C:\Users\Valentin\Desktop\C#\Homework Text Files\Problem 1. Odd lines\bin\Debug\New Text Document.txt");

        using (sw)
        {
            int linenumber = 0;
            string line = sw.ReadLine();
            while (line != null)
            {
                linenumber++;
                if (linenumber % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                line = sw.ReadLine();
            }
        }
            
            

        



    }
}

