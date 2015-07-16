using System;
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
    class Program
    {
        static void Main()
        {
            string[] forbiddenWords = new string[3];
            forbiddenWords[0]= "PHP";
            forbiddenWords[1]= "CLR";
            forbiddenWords[2]= "Microsoft";
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string forbiddenWord;
            for (int i = 0; i < forbiddenWords.Length; i++)
			{
                string asteriks=new string('*',forbiddenWords[i].Length);
                
                text=text.Replace(forbiddenWords[i],asteriks);
			}
            Console.WriteLine(text);
        }
    }

