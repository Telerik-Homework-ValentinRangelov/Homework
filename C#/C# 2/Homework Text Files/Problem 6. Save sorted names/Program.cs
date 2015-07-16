using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
    class Program
    {
        static void Main()
        {
            StreamReader input = new StreamReader("input.txt");
            StreamWriter output = new StreamWriter("output.txt");
            int count = 0;
            List<string> nameArray = new List<string>();
            using (input)
            {
                string line = input.ReadLine();
                while (line!=null)
                {
                    count++;
                    nameArray.Add(line);
                    line = input.ReadLine();
                }
            }
            Console.WriteLine("Unsorted:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nameArray[i]);
            }
            nameArray.Sort();
            Console.WriteLine("\nSorted:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nameArray[i]);
            }
            using (output)
            {
                for (int i = 0; i < count; i++)
                {
                    string newLine = nameArray[i];
                    output.WriteLine(newLine);
                }
            }
        }
    }

