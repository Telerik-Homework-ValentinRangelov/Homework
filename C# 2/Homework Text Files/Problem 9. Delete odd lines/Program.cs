using System;
using System.IO;

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

class Program
{
    static void Main()
    {
        StreamReader text = new StreamReader("text.txt");
        int count = 1;
        int countLines = 0;
        using (text)
        {

            string CountLine = text.ReadLine();
            while (CountLine != null)
            {
                countLines++;
                CountLine = text.ReadLine();
            }
        }
        string[] stringArray = new string[countLines / 2];
        StreamReader textTwo = new StreamReader("text.txt");
        

        using (textTwo)
        {
            string line = textTwo.ReadLine();
            int i = 0;
            while (line != null)
            {
                
                if (count % 2 == 1)
                {

                }
                else
                {
                    stringArray[i] = line;
                    i++;
                }
                count++;
                line = textTwo.ReadLine();

            }
        }
        StreamWriter textThree = new StreamWriter("text2.txt",false);
        using (textThree)
        {
            for (int i = 0; i < countLines / 2; i++)
            {
                textThree.WriteLine(stringArray[i]);
            }
        }
        
    }
}

