using System;
using System.Text;


class Program
{
    static void Main()
    {
        string text = "This is text";
       
        //text = Console.ReadLine(); //<------Untag this if u want ur own text
        Console.WriteLine(text);
        string[] textSplit = text.Split(' ');
        StringBuilder reversedText = new StringBuilder();
        for (int i = textSplit.Length-1; i >= 0; i--)
        {
            reversedText.Append(textSplit[i]+" ");

        }
        Console.WriteLine("Reversed:");
        Console.WriteLine(reversedText);
    }
}

