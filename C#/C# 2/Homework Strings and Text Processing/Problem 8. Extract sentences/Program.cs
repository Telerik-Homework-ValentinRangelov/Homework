using System;
//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.
class Program
{
    static void Main()
    {
        string inputString = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        //Console.WriteLine("Please enter your string");inputString = Console.ReadLine();               //<---Untag this for your own string
        string wordForExtracting = "in";
        //Console.WriteLine("Please enter your word which you want to extract");wordForExtracting = Console.ReadLine();         //<---Untag this for your own string
        Console.WriteLine("The string is:\n{0}", inputString);
        Console.WriteLine("\nThe word is:{0}", wordForExtracting);
        int indexOfWord = inputString.IndexOf(wordForExtracting);
        int indexOfDot = inputString.IndexOf(".", indexOfWord);
        int indexOfLastDot = inputString.LastIndexOf(".", indexOfWord);
        if (indexOfLastDot == -1)
        {
            indexOfLastDot = 0;
        }
        string theWholeString = inputString.Substring(indexOfLastDot, indexOfDot - indexOfLastDot + 1);
        theWholeString = theWholeString.Trim();
        Console.WriteLine("\nThe sentances which cointain '{0}' in the text:",wordForExtracting);
        Console.WriteLine("\n"+theWholeString);
        for (int i = indexOfDot + 1; i < inputString.Length; )
        {
            if (indexOfDot + 1 == inputString.Length)
            {
                break;
            }
            i = indexOfDot + 1;
            indexOfWord = inputString.IndexOf(wordForExtracting, i);
            indexOfDot = inputString.IndexOf(".", indexOfWord);
            indexOfLastDot = inputString.LastIndexOf(".", indexOfWord);
            if (indexOfLastDot == -1)
            {
                indexOfLastDot = 0;
            }
            if (indexOfDot == inputString.Length - 1)
            {
                theWholeString = inputString.Substring(indexOfLastDot + 1, indexOfDot - indexOfLastDot);

            }
            else
            {
                theWholeString = inputString.Substring(indexOfLastDot + 1, indexOfDot - indexOfLastDot + 1);
            }
            theWholeString = theWholeString.Trim();            
            Console.WriteLine(theWholeString);
            if (indexOfWord == -1)
            {
                break;
            }
        }


    }
}

