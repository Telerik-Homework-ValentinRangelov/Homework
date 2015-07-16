using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
class Program
{
    static void Main()
    {
        StreamReader Text = new StreamReader("FirstText.txt");
        StreamWriter NewText = new StreamWriter("NewText.txt");
        using (Text)
        {
            using (NewText)
            {
                string line = Text.ReadLine();
                int count = 1;
                while (line!=null)
                {
                    NewText.WriteLine("{0}.{1}", count, line);
                    count++;
                    line = Text.ReadLine();
                }
            }

        }
    }
}

