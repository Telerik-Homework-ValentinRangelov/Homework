﻿using System;
//Write a program that generates and prints to the console 10 random values in the range [100, 200].
class Program
{
    static void Main()
    {
        Random randomNum = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomNum.Next(100,201));
        }
    }
}

