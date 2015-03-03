using System;
using System.IO;
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
class Program
{
    static void Main()
        {
            StreamReader firstText = new StreamReader("FirstText.txt");
            StreamReader secondText = new StreamReader("SecondText.txt");
            int countSame = 0;
            int countDifferent = 0;
            using (firstText)
            {
                using (secondText)
                {
                    string firstTextLine = firstText.ReadLine();
                    string secondTextLine = secondText.ReadLine();
                    

                    while (firstTextLine!=null)
                    {
                        
                        if (firstTextLine==secondTextLine)
                        {
                            countSame++;
                        }
                        else
                        {
                            countDifferent++;
                        }
                        firstTextLine = firstText.ReadLine();
                        secondTextLine = secondText.ReadLine();

                    }
                }
                
            }
            Console.WriteLine("The same lines are: {0}",countSame);
            Console.WriteLine("The different lines are: {0}", countDifferent);

        }
}

