using System;


class Program
{
//      Write a method that counts how many times given number appears in given array.
//      Write a test program to check if the method is workings correctly.

    //Method 
    static int GivenNumberAppearsInArray(int num,int[] array)
    {
        int count = 0;
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k]==num)
            {
                count++;
            }
        }
        return count;

    }
    static void Main()
    {
        //Elements in array
        Console.Write("How many elements do you want in the array? :");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        //Randomize the numbers in the array
        Random randomNumber = new Random();
        for (int i = 0; i < elements; i++)
        {
            array[i] = randomNumber.Next(100);
        }
        //Print the numbers in the array
        for (int i = 0; i < elements; i++)
        {
            Console.WriteLine("Index:[{0}]: {1}",i,array[i]);
        }
        //Enter the number u wanna count
        Console.Write("Which number do you want to find how many times appears? :");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} appears {1} times.", number, GivenNumberAppearsInArray(number, array));
    }
}
