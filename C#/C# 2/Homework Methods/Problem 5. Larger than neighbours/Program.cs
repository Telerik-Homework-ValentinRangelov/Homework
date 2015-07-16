using System;


class Program
{
    //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
    static void NumLargerThanItsNeighbours(int num, int[] arr)
    {
        if (num == arr.Length - 1)
        {
            if (arr[num] > arr[num - 1])
            {
                Console.WriteLine("The number {0} is bigger than {1}.", arr[num], arr[num - 1]);
            }
            else
            {
                Console.WriteLine("The number {0} is not bigger than {1}.", arr[num], arr[num - 1]);
            }
        }
        else if (num == 0)
        {
            if (arr[num] > arr[num + 1])
            {
                Console.WriteLine("The number {0} is bigger than {1}.", arr[num], arr[num + 1]);
            }
            else
            {
                Console.WriteLine("The number {0} is not bigger than {1}.", arr[num], arr[num + 1]);
            }
        }
        else if (arr[num] > arr[num + 1] && arr[num] > arr[num - 1])
        {
            Console.WriteLine("The number {0} is bigger than {1} and {2}.", arr[num], arr[num - 1], arr[num + 1]);
        }
        else
        {
            Console.WriteLine("The number {0} is not bigger than {1} and {2}.", arr[num], arr[num - 1], arr[num + 1]);
        }
    }


    static void Main()
    {
        Console.Write("How much elements in the array do you want:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        //Random nums to the array
        Random randomNum = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = randomNum.Next(100);
        }
        //Printing the array
        for (int k = 0; k < n; k++)
        {
            Console.WriteLine("Index[{0}] : {1}", k, arr[k]);
        }
        //Enter the position of your chosen element
        Console.WriteLine("Enter the position(Index) of your chosen element. (ex. 0 , 1 , 2 etc..)");
        int chosenElement = int.Parse(Console.ReadLine());
        NumLargerThanItsNeighbours(chosenElement, arr);
    }
}
