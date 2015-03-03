using System;
using System.IO;

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
class ReplaceStartWithFinish
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line = line.Replace("start", "finish");
                    sw.WriteLine(line);
                }
            }
        }
    }
}   

