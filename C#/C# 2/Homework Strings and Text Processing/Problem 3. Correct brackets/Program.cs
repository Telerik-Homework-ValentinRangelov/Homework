using System;
        //Write a program to check if in a given expression the brackets are put correctly.
        //Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).


    class Program
    {
        static void Main()
        {
            string firstString = "((a+b)/5-d)";
            Console.WriteLine("Given expression: ((a+b)/5-d)");
            if (firstString.IndexOf(")(")==-1)
            {
                Console.WriteLine("There is no problem with the brackets in this expression!");
            }
            else
            {
                
                Console.WriteLine("There is problem with the brackets in this expression!");
            }

            string secondString = ")(a+b))";
            Console.WriteLine("Given expression: )(a+b))");
            if (secondString.IndexOf(")(") == -1)
            {
                Console.WriteLine("There is no problem with the brackets in this expression!");
            }
            else
            {

                Console.WriteLine("There is problem with the brackets in this expression!");
            }
            
        }
    }

