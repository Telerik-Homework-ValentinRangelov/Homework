using System;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
    class Program
    {
        static int GetSum(string str)
        {
            string[] arrString = str.Split(' ');
            
            int[] arrInteger = new int[arrString.Length];
            for (int i = 0; i < arrString.Length; i++)
            {
                arrInteger[i] = int.Parse(arrString[i]);
            }
            int sum = 0;
            for (int i = 0; i < arrInteger.Length; i++)
            {
                sum += arrInteger[i];
            }
            return sum;
        }
        static void Main()
        {
            string str = Console.ReadLine();
            Console.WriteLine("The sum of {0} is {1}",str,GetSum(str));
            
        }
    }

