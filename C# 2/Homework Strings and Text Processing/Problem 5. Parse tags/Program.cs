using System;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
class Program
{
    static void Main()
    {
        string givenString = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
    start:
        //givenString = Console.ReadLine();          //<-----Untag this if u want your own string
        

        int upcaseStart = givenString.IndexOf("<upcase>");
        int upcaseEnd = givenString.IndexOf("</upcase>") + 9;
        if (upcaseStart == -1)
        {
            Console.WriteLine("Theres no <upcase>, please enter your text again:");
            goto start;
        }
        if (upcaseEnd == 8)
        {
            Console.WriteLine("Theres no </upcase>, please enter your text again:");
            goto start;

        }
        Console.WriteLine("Before changes:\n{0}", givenString);
        string subString = givenString.Substring(upcaseStart, upcaseEnd - upcaseStart);
        string upcaseString = subString.ToUpper();
        givenString = givenString.Replace(subString, upcaseString);
        for (int i = upcaseStart + 1; upcaseStart < givenString.LastIndexOf("<upcase>"); i++)
        {
            upcaseStart = givenString.IndexOf("<upcase>", i);
            upcaseEnd = givenString.IndexOf("</upcase>") + 9;
            subString = givenString.Substring(upcaseStart, upcaseEnd - upcaseStart);
            upcaseString = subString.ToUpper();
            givenString = givenString.Replace(subString, upcaseString);
        }
        givenString = givenString.Replace("<UPCASE>", "");
        givenString = givenString.Replace("</UPCASE>", "");



        Console.WriteLine("After changes:\n{0}", givenString);







    }
}

