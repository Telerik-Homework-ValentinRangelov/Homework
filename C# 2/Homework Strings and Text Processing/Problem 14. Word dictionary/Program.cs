using System;
        //A dictionary is stored as a sequence of text lines containing words and their explanations.
        //Write a program that enters a word and translates it by using the dictionary.

class Program
{
    static void Main()
    {
        string[] texts = new string[3];
        texts[0] = ".NET platform for applications from Microsoft";
        texts[1] = "CLR managed execution environment for .NET";
        texts[2] = "namespace hierarchical organization of classes";
        Console.WriteLine("Enter '.NET' , 'CLR' or 'namespace' to see what they means: ");
        string input = Console.ReadLine();
        for (int i = 0; i < texts.Length; i++)
        {
            int space = texts[i].IndexOf(' ');
            string word = texts[i].Substring(0,space);
            string means = texts[i].Substring(space + 1);
            if (input.Equals(word))
            {
                Console.WriteLine(means);
            }
        }
    }
}

